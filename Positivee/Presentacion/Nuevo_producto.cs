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
                
        Categoria categoria = new Categoria();
        public Nuevo_producto()
        {
            InitializeComponent();
        }

        private void addProduct_Load(object sender, EventArgs e)
        {
           
            tbPriceProd.Text = "0";
            tbPrecV.Text = "0";
            tbStockProd.Text = "0"; 

            cbCategorie.Items.Clear();
            Categoria catego = new Categoria();
            cbCategorie.DataSource = catego.lista_categorias();
            cbCategorie.DisplayMember = "descripcion";
            cbCategorie.ValueMember = "id_categoria";
            cbCategorie.Refresh();

            cbStatus.Items.Clear();
            Estado tipo_estado = new Estado();
            cbStatus.DataSource = tipo_estado.lista_estados();
            cbStatus.DisplayMember = "descripcion";
            cbStatus.ValueMember = "id_estado";
            cbStatus.Refresh();
        }
        private void btAddProd_Click_1(object sender, EventArgs e)
        {
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                DialogResult resp = MessageBox.Show("Se guardara el cliente", "Éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    Producto producto = new Producto();
                    Cliente cliente = new Cliente();
                    producto.INSERTCONTROL(tbCodeProd.Text.Trim(), tbTitleProd.Text.Trim(), tbDescProd.Text, cbCategorie.SelectedValue.ToString(), cbStatus.SelectedValue.ToString()
                           , tbPriceProd.Text, tbPrecV.Text, tbStockProd.Text.Trim(), this);
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
        public void cod_ya_registrado()
        {
            MessageBox.Show("Este codigo de producto ya está registrado.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        
    }
}
