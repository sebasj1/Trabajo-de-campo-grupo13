using Dapper;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Positive.Presentacion
{
    public partial class Nuevo_producto : Form
    { 
        private  string _connectionString =Conexion.get_string();
                Producto producto = new Producto();
        Categoria categoria = new Categoria();
        public Nuevo_producto()
        {
            InitializeComponent();
        }

        private void addProduct_Load(object sender, EventArgs e)
        {
            buscar_categorias();
            buscar_estado(); 
            tbPriceProd.Text = "0";
            tbPrecV.Text = "0";
            tbStockProd.Text = "0";
        }


        private void btAdd_MouseMove(object sender, MouseEventArgs e)
        {
            btAddProd.BackColor = System.Drawing.Color.FromArgb(37, 88, 175);
        }

        private void btAdd_MouseLeave(object sender, EventArgs e)
        {
            btAddProd.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void btClean_MouseMove(object sender, MouseEventArgs e)
        {
            btClean.BackColor = System.Drawing.Color.FromArgb(215, 115, 38);
        }

        private void btClean_MouseLeave(object sender, EventArgs e)
        {
            btClean.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
        }





        private void buscar_categorias()  //Carga los datos del dropdown estado
        {
            try
            {

                using (var db = new MySqlConnector.MySqlConnection(_connectionString))
                {
                    var CategoriaQuery = db.Query<Categoria>(
                                  sql: "all_categories_d",
                                  commandType: CommandType.StoredProcedure);

                    cbCategorie.Items.Clear();
                    cbCategorie.DataSource = CategoriaQuery.ToList();
                    cbCategorie.DisplayMember = "descripcion";
                    cbCategorie.ValueMember = "id_categoria";
                    cbCategorie.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar " + ex);
            } }

        private void buscar_estado()  //Carga los datos del dropdown estado
        {
            try
            {
                using (var db = new MySqlConnector.MySqlConnection(_connectionString))
                {
                    var estado = db.Query<Estado>(
                               sql: "all_status_d",
                               commandType: CommandType.StoredProcedure);

                        cbStatus.Items.Clear();
                        cbStatus.DataSource = estado.ToList();
                        cbStatus.DisplayMember = "descripcion";
                        cbStatus.ValueMember = "id_estado";
                        cbStatus.Refresh();


                }
               
            }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo cargar " + ex);
                }

            }




        private bool FINDCOD(string p_cod)
        {
            bool exist = false;
            using (var db = new MySqlConnector.MySqlConnection(_connectionString))
            {
                var LISTEXIST = db.Query(
                           sql: "search_producto_cod",
                           param: new { p_cod = p_cod },
                           commandType: CommandType.StoredProcedure
                );
                if (LISTEXIST.Count() > 0)
                {
                    exist = true;
                }
            }
            return exist;
        }
        private void INSERTCONTROL()
        {

            try
            {


                if (this.ValidateChildren(ValidationConstraints.Enabled) && (!FINDCOD(tbCodeProd.Text)||tbCodeProd.Text==""))
                {

                    producto.codigo = tbCodeProd.Text.Trim();
                    producto.titulo = tbTitleProd.Text.Trim();
                    producto.descripcion = tbDescProd.Text;
                    producto.id_categoria = cbCategorie.SelectedIndex+1;
                    producto.id_estado = cbStatus.SelectedIndex+1;
                    producto.precio_compra = decimal.Parse( tbPriceProd.Text);
                    producto.precio_venta = decimal.Parse(tbPrecV.Text); 
                    producto.stock = int.Parse(tbStockProd.Text.Trim());
               

                    DialogResult resp = MessageBox.Show("Se guardara el producto", "Éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resp == DialogResult.Yes)
                    {
                        INSERTELEM();
                        MessageBox.Show("Este producto se ha guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }



            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error." + ex, "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }



        private void INSERTELEM()
        {

            using (var db = new MySqlConnector.MySqlConnection(_connectionString))
            {

                var queryAdd = db.ExecuteReader(
                                   sql: "add_product",
                                   param: new
                                   {
                                       @p_titulo = producto.titulo,
                                       p_descripcion = producto.descripcion,
                                       p_codigo = producto.codigo,
                                       p_precio_compra = producto.precio_venta,
                                       p_precio_venta = producto.precio_venta,
                                       p_id_categoria = producto.id_categoria,
                                       p_id_estado = producto.id_estado,
                                       p_stock = producto.stock

                                   },
                                   commandType: CommandType.StoredProcedure);

            }
        }

        private void btClean_Click(object sender, EventArgs e)
        {

            tbTitleProd.Text="";
           tbDescProd.Text="";
            cbCategorie.SelectedIndex = cbCategorie.SelectedIndex+1;
            cbStatus.SelectedIndex = cbStatus.SelectedIndex + 1;
            tbPriceProd.Text = "0";
            tbPrecV.Text ="0";
            tbStockProd.Text="0";

        }
        

        private void tbTitleProd_Validating(object sender, CancelEventArgs e)
        {

            if (tbTitleProd.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(tbTitleProd, "Ingresar Titulo");
            }
        }

        private void tbTitleProd_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbTitleProd, "");
        }

        private void tbCodeProd_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void tbCodeProd_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbCodeProd, "");
        }

        private void tbPriceProd_Validating(object sender, CancelEventArgs e)
        {

            if (int.Parse(tbPriceProd.Text) <0 || !decimal.TryParse( tbPriceProd.Text,out _))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbPriceProd, "Ingresar valores numericos");
            }else if (tbPriceProd.Text == "")
            {
                tbPriceProd.Text = "0";
            }
            else if (tbPrecV.Text == "")
            {
                tbPrecV.Text = "0";
            }
        }

        private void tbPriceProd_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbPriceProd, "");
        }

        private void tbStockProd_Validating(object sender, CancelEventArgs e)
        {

            if (tbStockProd.Text == "" || !Int32.TryParse(tbStockProd.Text, out _))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbStockProd, "Ingresar valores numericos");
            }
        }

        private void tbStockProd_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbStockProd, "");
        }
       
        private void btAddProd_Click_1(object sender, EventArgs e)
        {
            INSERTCONTROL();
        }
    }
}
