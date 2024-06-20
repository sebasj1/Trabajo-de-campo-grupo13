using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jbposs.Presentacion
{
    public partial class editCustomer : Form
    {
         private frmCustomers userPrincipal;
        private bool active = true;
        public editCustomer(frmCustomers pUserPrincipal)
        {
            InitializeComponent();
                userPrincipal = pUserPrincipal;
        }

        private void editCustomer_Load(object sender, EventArgs e)
        {

        }

            private void btAdd_MouseMove(object sender, MouseEventArgs e)
            {
                btGuardar.BackColor = System.Drawing.Color.FromArgb(37, 88, 175);
            }

            private void bteditCustomer_MouseLeave(object sender, EventArgs e)
            {
                btGuardar.BackColor = System.Drawing.SystemColors.Highlight;
            }

            private void btClean_MouseMove(object sender, MouseEventArgs e)
            {
                btClean.BackColor = System.Drawing.Color.FromArgb(215, 115, 38);
            }

            private void btClean_MouseLeave(object sender, EventArgs e)
            {
                btClean.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
            }



            //carga el usuario si coincide el dni de la lista
            public void loadUser(string pDni)
            {
                loadDropdownData();

                using (jbposEntities db = new jbposEntities())
                {
                    cliente user = db.cliente.Where(u => u.dni == pDni).FirstOrDefault();
                    if (user.fecha_eliminado != null)
                    {
                       
                    active = false;
                    rbInactivo.Checked = true;
                }
                    else
                    {
                       
                        rbActivo.Checked = true;
                    }
                    TBNombre.Text = user.nombre;
                    textboxApellido.Text = user.apellido;
                    tbTel.Text = user.telefono;
                    tbDNI.Text = user.dni;
                    tbAdress.Text = user.domicilio;
                    tbEmail.Text = user.email;
                    cbProv.SelectedIndex = user.id_provincia - 1;
               

                }

            }

            private void loadDropdownData()//carga los dropdown
            {
                //Cargar roles
                using (jbposEntities db = new jbposEntities())
                {
                    //Cargar provincias
                    var provinciasQuery = from p in db.provincia
                                          select new { p.id_provincia, p.nombre };

                    cbProv.DataSource = provinciasQuery.ToList();
                    cbProv.DisplayMember = "nombre";
                    cbProv.ValueMember = "id_provincia";
                    cbProv.Refresh();
                }
            }

            private void userEdit_Load(object sender, EventArgs e)
            {
                // TODO: esta línea de código carga datos en la tabla 'jbposDataSet.provincia' Puede moverla o quitarla según sea necesario.
                

                loadDropdownData();

            }

            private void btBack_Click(object sender, EventArgs e)
            {
              //  userPrincipal.iconSelect(userPrincipal.btEditUser,userPrincipal.usList);
            }


            private bool chargeInfo()
            {
                this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
                bool ok = true;

                if (this.ValidateChildren(ValidationConstraints.Enabled))
                {
                using (jbposEntities db = new jbposEntities())
                {
                    cliente user = db.cliente.FirstOrDefault(u => u.dni == tbDNI.Text.Trim());
                    //usuario user = new usuario();
                    user.nombre = TBNombre.Text.Trim();
                    user.apellido = textboxApellido.Text.Trim();
                    user.telefono = tbTel.Text.Trim();
                    user.dni = tbDNI.Text.Trim();
                    user.domicilio = tbAdress.Text.Trim();
                    user.email = tbEmail.Text.Trim();
                    user.id_provincia = cbProv.SelectedIndex + 1;
              

                    if (rbInactivo.Checked == true && active==true)
                    {
                        user.fecha_eliminado = DateTime.Now;
                    }
                    else if (rbActivo.Checked == true && active == false)
                    {
                        user.fecha_eliminado = null;
                    }
                    active=true;
                    db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                }
                else
                {
                    ok = false;
                }
                return ok;
            }
            private void clean()
            {
                TBNombre.Clear();
                textboxApellido.Clear();
                tbEmail.Clear();
                tbAdress.Clear();
                cbProv.SelectedValue = 1;
                tbTel.Clear();
            }

            //Validaciones
            private void TBNombre_Validating(object sender, CancelEventArgs e)
            {
                if (TBNombre.Text == "")
                {
                    e.Cancel = true;
                    errorProvider1.SetError(TBNombre, "Ingresar Nombre");
                }
            }

            private void TBNombre_Validated(object sender, EventArgs e)
            {
                errorProvider1.SetError(TBNombre, "");
            }

            private void textboxApellido_Validating(object sender, CancelEventArgs e)
            {
                if (textboxApellido.Text == "")
                {
                    e.Cancel = true;
                    errorProvider1.SetError(textboxApellido, "Ingresar Apellido");
                }
            }

            private void textboxApellido_Validated(object sender, EventArgs e)
            {
                errorProvider1.SetError(textboxApellido, "");
            }

            private void tbAdress_Validating(object sender, CancelEventArgs e)
            {
                if (tbAdress.Text == "")
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbAdress, "Ingresar Domicilio");
                }
            }

            private void tbAdress_Validated(object sender, EventArgs e)
            {
                errorProvider1.SetError(tbAdress, "");
            }

            private void tbEmail_Validating(object sender, CancelEventArgs e)
            {
                if (tbEmail.Text != "")
                {
                    if ((!(tbEmail.Text.Contains("@") && tbEmail.Text.Contains("."))))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(tbEmail, "Ingresar Email");
                    }
                }
            }

            private void tbEmail_Validated(object sender, EventArgs e)
            {
                errorProvider1.SetError(tbEmail, "");
            }

           


            private void tbTel_Validating(object sender, CancelEventArgs e)
            {
                if (tbTel.Text == "" || !float.TryParse(tbTel.Text, out _))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbTel, "Ingresar Telefono(Solo números)");
                }
            }

            private void tbTel_Validated(object sender, EventArgs e)
            {
                errorProvider1.SetError(tbTel, "");
            }

            private void btClean_Click(object sender, EventArgs e)
            {
                clean();
            }

            private void back_Click(object sender, EventArgs e)
            {
                userPrincipal.refreshList(userPrincipal.btEditCustomer);

            }

        private void btGuardar_Click(object sender, EventArgs e)
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

        private void btClean_Click_1(object sender, EventArgs e)
        {
            clean();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void rbActivo_CheckedChanged(object sender, EventArgs e)
        {
           panel1.BackColor = gBEditUs.BackColor = gbEstado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        }

        private void rbInactivo_CheckedChanged(object sender, EventArgs e)
        {

          panel1.BackColor = gBEditUs.BackColor = gbEstado.BackColor = System.Drawing.Color.MistyRose;
        }
    }
        

    }


