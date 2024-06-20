using Dapper;
using MySqlX.XDevAPI;
using Positive;
using Positive.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Positivee.Presentacion
{
    public partial class Editar_producto : Form
    {
        string _connectionString = "Server=mysql-proyectois2.alwaysdata.net;Database=proyectois2_puntoventa;User Id=362639;Password=Pollito1q;";
        Producto producto = new Producto();
        Seccion_productos _principal;
        public Editar_producto(int p_id, Seccion_productos p_principal)
        {
            InitializeComponent();
            _principal = p_principal;
            FINDPROD(p_id);
        }
        private void FINDPROD(int p_id)
        {
            try
            {
                using (var db = new MySqlConnector.MySqlConnection(_connectionString))
                {
                    var PROD = db.QueryFirst(
                               sql: "search_producto_id",
                               param: new { @p_id_producto = p_id },
                               commandType: CommandType.StoredProcedure
                    );
                    producto.codigo = PROD.codigo;
                    producto.descripcion = PROD.descripcion;
                    producto.id_categoria = PROD.id_categoria;
                    producto.id_estado = PROD.id_estado;
                    producto.id_producto = PROD.id_producto;
                    producto.precio_compra = PROD.precio_compra;
                    producto.precio_venta = PROD.precio_venta;
                    producto.stock = PROD.stock;
                    producto.titulo = PROD.titulo;

                }
                busca_categorias();
                busca_estado();
                tbCodeProd.Text = producto.codigo;
                cbStatus.SelectedIndex = producto.id_estado - 1;
                cbCategorie.SelectedIndex = producto.id_categoria - 1;

                tbDescProd.Text = producto.descripcion;
                tbPriceProd.Text = producto.precio_compra.ToString();
                tbPrecV.Text = producto.precio_venta.ToString();
                tbStockProd.Text = producto.stock.ToString();


                tbTitleProd.Text = producto.titulo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar " + ex);
            }

        }

        private void busca_categorias()
        {
            using (var db = new MySqlConnector.MySqlConnection(_connectionString))
            {

                var rolesQuery = db.Query<Categoria>(
                          sql: "all_categories_d",
                          commandType: CommandType.StoredProcedure);
                cbCategorie.Items.Clear();
                cbCategorie.DataSource = rolesQuery.ToList();
                cbCategorie.DisplayMember = "descripcion";
                cbCategorie.ValueMember = "id_categoria";
                cbCategorie.Refresh();

                
            } }
        private void busca_estado()
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
        private bool FINDCODPROD(string dni)
        {
            bool exist = false;
            using (var db = new MySqlConnector.MySqlConnection(_connectionString))
            {
                var LISTEXIST = db.Query(
                           sql: "search_producto_cod",
                           param: new {@p_cod = dni },
                           commandType: CommandType.StoredProcedure
                );
                if (LISTEXIST.Count() > 0)
                {
                    exist = true;
                }
            }
            return exist;
        }
        private void guardar_cambios()
        {

            try
            {

                this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;


                if (this.ValidateChildren(ValidationConstraints.Enabled) && (tbCodeProd.Text==""|| FINDCODPROD(tbCodeProd.Text)))
                {

                    producto.titulo = tbTitleProd.Text.Trim();
                    producto.descripcion = tbDescProd.Text;
                    producto.id_categoria = cbCategorie.SelectedIndex + 1;
                    producto.id_estado = cbStatus.SelectedIndex + 1;
                    producto.precio_compra = decimal.Parse(tbPriceProd.Text);
                    producto.precio_venta = decimal.Parse(tbPrecV.Text);
                    producto.stock = int.Parse(tbStockProd.Text.Trim());
                    DialogResult resp = MessageBox.Show("Se guardaran los datos del producto", "Éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resp == DialogResult.Yes)
                    {
                        GUARDAR_PRODUCTO();
                        MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        _principal.recargar_lista("edit");
                        this.Dispose();
                    }
                }

            }

            catch (DbEntityValidationException ex)
            {
                var errorMessages = ex.EntityValidationErrors
              .SelectMany(x => x.ValidationErrors)
              .Select(x => x.ErrorMessage);

                var fullErrorMessage = string.Join(Environment.NewLine, errorMessages);
                MessageBox.Show($"Errores de validación:{Environment.NewLine}{fullErrorMessage}", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error." + ex, "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btAddProd_Click(object sender, EventArgs e)
        {
            guardar_cambios();
        }
        private void GUARDAR_PRODUCTO()
        {

            using (var db = new MySqlConnector.MySqlConnection(_connectionString))
            {

                var queryAdd = db.ExecuteReader(
                                   sql: "edit_product",
                                   param: new
                                   {
                                       @p_id_producto = producto.id_producto,
                                       @p_titulo = producto.titulo,
                                       @p_descripcion = producto.descripcion,
                                       @p_codigo = producto.codigo,
                                       @p_precio_compra = producto.precio_compra,
                                       @p_precio_venta = producto.precio_venta,
                                       @p_id_categoria = producto.id_categoria,
                                       @p_id_estado = producto.id_estado,

                                   },
                                   commandType: CommandType.StoredProcedure);

            }
        }

        private void editar_producto_Load(object sender, EventArgs e)
        {

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

            if (int.Parse(tbPriceProd.Text) < 0 || !decimal.TryParse(tbPriceProd.Text, out _))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbPriceProd, "Ingresar valores numericos");
            }
            else if (tbPriceProd.Text == "")
            {
                tbPriceProd.Text = "0";
            }
            else if (tbPrecV.Text == "")
            {
                tbPrecV.Text ="0";
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

    }
}
