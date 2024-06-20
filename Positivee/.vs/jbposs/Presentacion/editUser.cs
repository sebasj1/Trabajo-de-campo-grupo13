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
    public partial class editUser : Form
    {
        private frmUsers userPrincipal;
        private bool active = true;
        public editUser(frmUsers pUserPrincipal)
        {
            InitializeComponent();
            userPrincipal = pUserPrincipal;
        }

        private void editUser_Load(object sender, EventArgs e)
        {

        }

        private void btAdd_MouseMove(object sender, MouseEventArgs e)
        {
            btGuardar.BackColor = System.Drawing.Color.FromArgb(37, 88, 175);
        }

        private void btEditUser_MouseLeave(object sender, EventArgs e)
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
                usuario user = db.usuario.Where(u => u.dni == pDni).FirstOrDefault();
                if (user.fecha_eliminado != null)
                {
                    panel1.BackColor = gBEditUs.BackColor = gBEditUs2.BackColor = System.Drawing.Color.MistyRose;
                    active = false;
                    rbInactivo.Checked = true;
                }
                else
                {
                    panel1.BackColor = gBEditUs.BackColor = gBEditUs2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
                    rbActivo.Checked = true;
                }
                TBNombre.Text = user.nombre;
                textboxApellido.Text = user.apellido;
                tbTel.Text = user.telefono;
                tbDNI.Text = user.dni;
                tbAdress.Text = user.domicilio;
                tbEmail.Text = user.email;
                cbProv.SelectedIndex = user.id_provincia - 1;
                cbRol.SelectedIndex = user.id_rol - 1;
                tbUser.Text = user.nombre_usuario;
                tbPass.Text = user.pass;



            }

        }

        private void loadDropdownData()//carga los dropdown
        {
            //Cargar roles
            using (jbposEntities db = new jbposEntities())
            {
                var rolesQuery = from r in db.rol
                                 select new { r.id_rol, r.descripcion };

                cbRol.DataSource = rolesQuery.ToList();
                cbRol.DisplayMember = "descripcion";
                cbRol.ValueMember = "id_rol";
                cbRol.Refresh();

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
            userPrincipal.iconSelect(userPrincipal.btEditUser, userPrincipal.usList);
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
                        usuario user = db.usuario.FirstOrDefault(u => u.dni == tbDNI.Text.Trim());
                        //usuario user = new usuario();
                        user.nombre = TBNombre.Text.Trim();
                        user.apellido = textboxApellido.Text.Trim();
                        user.telefono = tbTel.Text.Trim();
                        user.dni = tbDNI.Text.Trim();
                        user.domicilio = tbAdress.Text.Trim();
                        user.email = tbEmail.Text.Trim();
                        user.id_provincia = cbProv.SelectedIndex + 1;
                        user.id_rol = cbRol.SelectedIndex + 1;
                        user.nombre_usuario = tbUser.Text.Trim();
                        user.pass = tbPass.Text;
                        if (rbInactivo.Checked == true && active == true)
                        {
                            user.fecha_eliminado = DateTime.Now;
                        }
                        else if (rbActivo.Checked == true && active == false)
                        {
                            user.fecha_eliminado = null;
                        }
                        active = true;
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
        private void clean()
        {
            TBNombre.Clear();
            textboxApellido.Clear();
            tbEmail.Clear();
            tbAdress.Clear();
            cbProv.SelectedValue = 1;
            cbRol.SelectedValue = 1;
            tbTel.Clear();
            tbUser.Clear();
            tbPass.Clear();
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

        private void tbDNI_Validating(object sender, CancelEventArgs e)
        {

            if (tbDNI.Text == "" || !int.TryParse(tbDNI.Text, out _) || !(tbDNI.Text.Length >= 8 && tbDNI.Text.Length <= 9))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbDNI, "Ingresar DNI(Solo números)");
                { }
            }
        }
        private void tbDNI_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbDNI, "");
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
            if (tbTel.Text != "" && !float.TryParse(tbTel.Text, out _))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbTel, "Ingresar Telefono(Solo números)");
            }
        }

        private void tbTel_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbTel, "");
        }

        private void tbUser_Validating(object sender, CancelEventArgs e)
        {
            if (tbUser.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(tbUser, "Ingresar Nombre usuario");
            }
        }

        private void tbUser_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbUser, "");
        }

        private void tbPass_Validating(object sender, CancelEventArgs e)
        {
            if (!(tbPass.Text.Length >= 6 && tbPass.Text.Length <= 100))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbPass, "Debe contener entre 6 y 100 caracteres");
            }
        }

        private void tbPass_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbPass, "");
        }

        private void TBNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btClean_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void back_Click(object sender, EventArgs e)
        {
            userPrincipal.refreshList(userPrincipal.btEditUser);

        }

        private void gBEditUs_Enter(object sender, EventArgs e)
        {

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
            panel1.BackColor = gBEditUs.BackColor = gBEditUs2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        }

        private void rbInactivo_CheckedChanged(object sender, EventArgs e)
        {

            panel1.BackColor = gBEditUs.BackColor = gBEditUs2.BackColor = System.Drawing.Color.MistyRose;
        }
    }


}


