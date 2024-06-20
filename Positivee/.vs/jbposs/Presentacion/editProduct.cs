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
    public partial class editProduct : Form
    {
        private bool active = true;
        private frmProducts pForm;
        public editProduct(frmProducts pForm)
        {
            InitializeComponent();
            this.pForm = pForm;
        }

        private void editProduct_Load(object sender, EventArgs e)
        {


        }

        private void btAdd_MouseMove(object sender, MouseEventArgs e)
        {
            btOk.BackColor = System.Drawing.Color.FromArgb(37, 88, 175);
        }

        private void btAdd_MouseLeave(object sender, EventArgs e)
        {
            btOk.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void btClean_MouseMove(object sender, MouseEventArgs e)
        {
            btClean.BackColor = System.Drawing.Color.FromArgb(215, 115, 38);
        }

        private void btClean_MouseLeave(object sender, EventArgs e)
        {
            btClean.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
        }


        private void btBack_MouseMove(object sender, MouseEventArgs e)
        {
            btBack.BackColor = System.Drawing.Color.FromArgb(215, 115, 38);
        }

        private void btBack_MouseLeave(object sender, EventArgs e)
        {
            btBack.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
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
        public void loadProd(string pCodigo)
        {
            try{
                loadDropdownDataProd();

                using (jbposEntities db = new jbposEntities())
                {
                    producto prod = db.producto.Where(u => u.codigo == pCodigo).FirstOrDefault();
                    if (prod.fecha_eliminado != null)
                    {
                        panel1.BackColor = gbEdProd.BackColor = System.Drawing.Color.MistyRose;
                        active = false;
                        rbInactivo.Checked = true;
                    }
                    else
                    {
                        panel1.BackColor = gbEdProd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
                        rbActivo.Checked = true;
                    }
                    tbCodeProd.Text = prod.codigo;
                    tbTitleProd.Text = prod.titulo;
                    tbDescProd.Text = prod.descripcion;
                    tbPriceProd.Text = prod.precio.ToString();
                    tbStockProd.Text = prod.stock.ToString();
                    cbCategorie.SelectedIndex = prod.id_categoria - 1;


                }

            }
            catch(Exception e)
            {
                MessageBox.Show("No fue posible realizar la operación"+ e);
            }

        }

        private bool chargeInfo()
        {
            try
            {
                this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
                bool ok = true;

                if (this.ValidateChildren(ValidationConstraints.Enabled))
                {
                    using (jbposEntities db = new jbposEntities())
                    {

                        producto prod = db.producto.FirstOrDefault(u => u.codigo == tbCodeProd.Text.Trim());
                        //usuario user = new usuario();
                        prod.titulo = tbTitleProd.Text.Trim();
                        prod.descripcion = tbDescProd.Text.Trim();
                        prod.stock = Convert.ToInt32(tbStockProd.Text.Trim());

                        prod.precio = Convert.ToDecimal(tbPriceProd.Text.Trim());
                        prod.id_categoria = cbCategorie.SelectedIndex + 1;
                        if (rbInactivo.Checked == true && active == true)
                        {
                            prod.fecha_eliminado = DateTime.Now;
                        }
                        else if (rbActivo.Checked == true && active == false)
                        {
                            prod.fecha_eliminado = null;
                        }
                        active = true;
                        db.Entry(prod).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                }
                else
                {
                    ok = false;
                }
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
        private void btOk_Click(object sender, EventArgs e)
        {

            //usuario user = context.usuario.FirstOrDefault(u => u.dni == tbDNI.Text);
            DialogResult resp = MessageBox.Show("Se actualizaran los datos ingresados.¿Desea actualizarlos?", "Éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
                try
                {
                    if (chargeInfo())
                    {
                        MessageBox.Show("Datos actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Debe completar los campos correctamente, error al actualizar los datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No fue posible actualizar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
        }
        private void rbActivo_CheckedChanged(object sender, EventArgs e)
        {
            panel1.BackColor = gbEdProd.BackColor = label8.BackColor = gbEstado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        }

        private void rbInactivo_CheckedChanged(object sender, EventArgs e)
        {

            panel1.BackColor = label8.BackColor= gbEdProd.BackColor = gbEstado.BackColor = System.Drawing.Color.MistyRose;
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            pForm.backEdit();
        }

        private void cbCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
