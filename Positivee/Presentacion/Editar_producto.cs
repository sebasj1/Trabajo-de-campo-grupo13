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

namespace Positive.Presentacion
{
    public partial class Editar_producto : Form
    {
        string _connectionString = "Server=mysql-proyectois2.alwaysdata.net;Database=proyectois2_puntoventa;User Id=362639;Password=Pollito1q;";
        Producto producto_en_editar = new Producto();
        Seccion_productos _principal;
        public Editar_producto()
        {
            InitializeComponent();
        }
    

        public void cargar_datos(Producto p_usuario_producto_editar)
            {
            producto_en_editar = p_usuario_producto_editar;



                Categoria categoria = new Categoria();
                cbCategorie.Items.Clear();
                cbCategorie.DataSource = categoria.lista_categorias();
                cbCategorie.DisplayMember = "descripcion";
                cbCategorie.ValueMember = "id_categoria";
                cbCategorie.Refresh();

             


                cbStatus.Items.Clear();
                Estado tipo_estado = new Estado();
                cbStatus.DataSource = tipo_estado.lista_estados();
                cbStatus.DisplayMember = "descripcion";
                cbStatus.ValueMember = "id_estado";
                cbStatus.Refresh();



                tbCodeProd.Text = producto_en_editar.codigo;
                cbCategorie.SelectedIndex = producto_en_editar.id_categoria - 1;
                cbStatus.SelectedIndex = producto_en_editar.id_estado - 1;


                tbDescProd.Text = producto_en_editar.descripcion;
                tbPrecV.Text = producto_en_editar.precio_venta.ToString();
                tbPriceProd.Text = producto_en_editar.precio_compra.ToString();
                tbStockProd.Text = producto_en_editar.stock.ToString();
            tbTitleProd.Text = producto_en_editar.titulo;
            }
           

                
       
       
        

        private void btAddProd_Click(object sender, EventArgs e)
        {
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;


            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
               
                producto_en_editar.INSERTCONTROLEDIT(tbCodeProd.Text.Trim(),tbTitleProd.Text.Trim() ,tbDescProd.Text.Trim(), cbCategorie.SelectedIndex + 1, cbStatus.SelectedIndex + 1,
                tbPriceProd.Text.Trim(), tbPrecV.Text.Trim(), tbStockProd.Text.Trim(),  this);

            }
        }
        // private void GUARDAR_PRODUCTO()
        // {

        //     using (var db = new MySqlConnector.MySqlConnection(_connectionString))
        //     {

        //         var queryAdd = db.ExecuteReader(
        //                            sql: "edit_product",
        //                            param: new
        //                            {
        //                                @p_id_producto = producto.id_producto,
        //                                @p_titulo = producto.titulo,
        //                                @p_descripcion = producto.descripcion,
        //                                @p_codigo = producto.codigo,
        //                                @p_precio_compra = producto.precio_compra,
        //                                @p_precio_venta = producto.precio_venta,
        //                                @p_id_categoria = producto.id_categoria,
        //                                @p_id_estado = producto.id_estado,

        //                            },
        //                            commandType: CommandType.StoredProcedure);

        //     }
        // }

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
