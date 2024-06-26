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
         Seccion_productos _principal;
        public Editar_producto()
        {
            InitializeComponent();
        }
    

        public void cargar_datos(string codigo, string descripcion,int id_categoria,int id_estado,int id_producto
            ,decimal precio_compra,decimal precio_venta,int stock, string titulo)
            {
                Categoria categoria = new Categoria();
                cbCategorie.Items.Clear();
                cbCategorie.DataSource = categoria.buscar_categorias();
                cbCategorie.DisplayMember = "descripcion";
                cbCategorie.ValueMember = "id_categoria";
                cbCategorie.Refresh();

                cbStatus.Items.Clear();
                Estado tipo_estado = new Estado();
                cbStatus.DataSource = tipo_estado.buscar_estado();
                cbStatus.DisplayMember = "descripcion";
                cbStatus.ValueMember = "id_estado";
                cbStatus.Refresh();

                tbCodeProd.Text = codigo;
                cbCategorie.SelectedIndex = id_categoria - 1;
                cbStatus.SelectedIndex = id_estado - 1;


                tbDescProd.Text = descripcion;
                tbPrecV.Text = precio_venta.ToString();
                tbPriceProd.Text = precio_compra.ToString();
                tbStockProd.Text = stock.ToString();
            tbTitleProd.Text = titulo;
            }
           

                
       
       
        

        private void btAddProd_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {

                DialogResult resp = MessageBox.Show("Se guardara el producto", "Éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    Producto producto_editado = new Producto();
                    producto_editado.insertar_producto_editado(tbCodeProd.Text.Trim(), tbTitleProd.Text.Trim(), tbDescProd.Text.Trim(), cbCategorie.SelectedIndex + 1, cbStatus.SelectedIndex + 1,
                    tbPriceProd.Text.Trim(), tbPrecV.Text.Trim(), tbStockProd.Text.Trim(), this);

                }
            }
        }
        public void exito()
        {
            MessageBox.Show("Se ha guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void fallo()
        {
            MessageBox.Show("No se pudo realizar la actualización.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void cod_no_registrado()
        {
            MessageBox.Show("Este codigo de producto no está registrado.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        {decimal _;

            if (int.Parse(tbPriceProd.Text) < 0 || !decimal.TryParse(tbPriceProd.Text, out _))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbPriceProd, "Ingresar valores numericos");
            }
            else if (tbPriceProd.Text == "0")
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
            int _;
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

        private void tbPriceProd_TextChanged(object sender, EventArgs e)
        {

           
            decimal resultado;
            if (!decimal.TryParse(tbPriceProd.Text, out resultado))
            {
                tbPriceProd.Text = "";
            }
            
        }

        private void tbPrecV_TextChanged(object sender, EventArgs e)
        { decimal resultado;
            if (!decimal.TryParse(tbPrecV.Text, out resultado))
            {
                tbPrecV.Text = "";
            }

        }

        private void tbStockProd_TextChanged(object sender, EventArgs e)
        {
            int resultado;
            if (!int.TryParse(tbStockProd.Text, out resultado))
            {
                tbStockProd.Text = "";
            }
        }
    }
}
