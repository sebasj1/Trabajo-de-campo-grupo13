using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jbposs.Presentacion
{
    public partial class addProduct : Form
    {
        public addProduct()
        {
            InitializeComponent();
        }

        private void addProduct_Load(object sender, EventArgs e)
        {
            loadDropdownDataProd();
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

        private void btCancel_MouseMove(object sender, MouseEventArgs e)
        {
            btCancel.BackColor = System.Drawing.Color.FromArgb(201, 40, 40);
        }

        private void btCancel_MouseLeave(object sender, EventArgs e)
        {
            btCancel.BackColor = System.Drawing.Color.Red;
        }

        
        private void loadDropdownDataProd()  //Carga los datos del dropdown
        {
            try
            {
                using (jbposEntities db = new jbposEntities())
                {
                    //Cargar categorias
                    var CategoriaQuery = from r in db.categoria
                                         select new { r.id_categoria, r.nombre };
                   
                    cbCategorie.DataSource = CategoriaQuery.ToList();
                    cbCategorie.DisplayMember = "nombre";
                    cbCategorie.ValueMember = "id_categoria";
                    cbCategorie.Refresh();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No fue posible cargar categorias");
            }
        }
        private bool noExist(string pCodigo)
        {
            bool noExist = true;
            using (jbposEntities db = new jbposEntities())
            {
                if (db.producto.Count(us => us.codigo == pCodigo) > 0)
                {
                    noExist = false;
                    return noExist;
                }
                return noExist;
            }
        }

        private bool chargeInfoProd()
        {
            try
            {
                this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
                bool ok = true;

                if (this.ValidateChildren(ValidationConstraints.Enabled) && noExist(tbCodeProd.Text.Trim()))
                {
                    using (jbposEntities db = new jbposEntities())
                    {
                        producto prod = new producto();
                        prod.titulo = tbTitleProd.Text.Trim();
                        prod.descripcion = tbDescProd.Text.Trim();
                        prod.stock = Convert.ToInt32(tbStockProd.Text.Trim());
                        prod.codigo = tbCodeProd.Text.Trim();
                        prod.precio = Convert.ToDecimal(tbPriceProd.Text.Trim());
                        prod.id_categoria = cbCategorie.SelectedIndex + 1;
                        db.producto.Add(prod);
                        db.SaveChanges();
                    }
                }
                else { ok = false; }
                return ok;
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
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
return false;
        }

        private void btAddProd_Click(object sender, EventArgs e) 
        {

            DialogResult resp = MessageBox.Show("Se agregara el producto con los datos especificados.¿Desea guardar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
            {
                try

                {
                    if (!noExist(tbCodeProd.Text.Trim()))
                    {
                        MessageBox.Show("El codigo del producto ya está registrado, no se pudo guardar.", "Codigo ya registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if(chargeInfoProd())
                    {
                        MessageBox.Show("Producto creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No fue posible guardar el producto.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Debe completar los campos correctamente, error al guardar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
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
            if (tbCodeProd.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(tbCodeProd, "Ingresar Titulo");
            }
        }

        private void tbCodeProd_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbCodeProd, "");
        }

        private void tbPriceProd_Validating(object sender, CancelEventArgs e)
        {

            if (tbPriceProd.Text == "" || !decimal.TryParse( tbPriceProd.Text,out _))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbPriceProd, "Ingresar valores numericos");
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
        private void cbCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbPriceProd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
