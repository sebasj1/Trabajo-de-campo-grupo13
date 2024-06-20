using jbposs.Datos;
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
    public partial class addUser : Form
    {
        public addUser()
        {
            InitializeComponent();
        }

        private void panelAddUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userAdd_Load(object sender, EventArgs e)
        {
            loadDropdownData();
        }

        private void loadDropdownData()  //Carga los datos del dropdown
        {
            try
            {
                using (jbposEntities db = new jbposEntities())
                {
                    //Cargar roles
                    var rolesQuery = from r in db.rol
                                     select new { r.id_rol, r.descripcion };
                    cbRol.Items.Clear();
                    cbRol.DataSource = rolesQuery.ToList();
                    cbRol.DisplayMember = "descripcion";
                    cbRol.ValueMember = "id_rol";
                    cbRol.Refresh();

                    //Cargar provincias
                    var provinciasQuery = from p in db.provincia
                                          select new { p.id_provincia, p.nombre };
                    cbProv.Items.Clear();
                    cbProv.DataSource = provinciasQuery.ToList();
                    cbProv.DisplayMember = "nombre";
                    cbProv.ValueMember = "id_provincia";
                    cbProv.Refresh();
                }
            }
            catch (Exception ex) { 
                MessageBox.Show("No se pudo cargar "+ ex);
            }
        }

        private void btAdd_MouseMove(object sender, MouseEventArgs e)
        {
            btAddUser.BackColor = System.Drawing.Color.FromArgb(37, 88, 175);
        }

        private void btAdd_MouseLeave(object sender, EventArgs e)
        {
            btAddUser.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void btClean_MouseMove(object sender, MouseEventArgs e)
        {
            btClean.BackColor = System.Drawing.Color.FromArgb(215, 115, 38);
        }

        private void btClean_MouseLeave(object sender, EventArgs e)
        {
            btClean.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
        }

        private bool noExist(string pDni)
        {
            bool noExist = true;
            using (jbposEntities db = new jbposEntities())
            {
                if (db.usuario.Count(us => us.dni == pDni) > 0)
                {
                    noExist = false;
                    return noExist;
                }
                return noExist;
            }
        }


        private bool chargeInfo()
        {
            try
            {
                this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
                bool ok = true;

                if (this.ValidateChildren(ValidationConstraints.Enabled) && noExist(tbDNI.Text))
                {
                    using (jbposEntities db = new jbposEntities())
                    {
                        usuario user = new usuario();
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
                        if (rbInactivo.Checked == true)
                        {
                            user.fecha_eliminado = DateTime.Now;
                        }
                        db.usuario.Add(user);
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

        private void btAddUser_Click(object sender, EventArgs e)
        {

            DialogResult resp = MessageBox.Show("Se agregara el usuario con los datos especificados.¿Desea guardar?", "Éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
            {
                try

                { 
                    if (!noExist(tbDNI.Text.Trim()))
                    {
                        MessageBox.Show("El dni de usuario ya está registrado, no se pudo guardar.", "Dni ya registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (chargeInfo())
                    {
                        MessageBox.Show("Usuario creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No fue posible guardar el usuario.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Debe completar los campos correctamente, error al guardar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btClean_Click(object sender, EventArgs e)
        {
            clean();

        }


        private void clean()
        {
            TBNombre.Clear();
            textboxApellido.Clear();
            tbDNI.Clear();
            tbEmail.Clear();
            tbAdress.Clear();
            cbProv.SelectedValue = 1;
            cbRol.SelectedValue = 1;
            tbTel.Clear();
            tbUser.Clear();
            tbPass.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

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
            using (jbposEntities db = new jbposEntities())
            {
                if (db.usuario.Count(usu => usu.dni == tbDNI.Text.Trim()) > 0)
                {
                }

                if (tbDNI.Text == "" || !int.TryParse(tbDNI.Text.Trim(), out _) || !(tbDNI.Text.Trim().Length >5 && tbDNI.Text.Trim().Length <10))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbDNI, "Ingresar DNI(Solo números)");
                    { }
                }
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
            if (!(tbPass.Text.Length >= 5 && tbPass.Text.Length <= 100))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbPass, "Debe contener entre 5 y 100 caracteres");
            }
        }

        private void tbPass_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbPass, "");
        }

        private void gbEstado_Enter(object sender, EventArgs e)
        {

        }

        private void rbActivo_CheckedChanged(object sender, EventArgs e)
        {
            panelAddUser.BackColor = groupBox1.BackColor = groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        }

        private void rbInactivo_CheckedChanged(object sender, EventArgs e)
        {

            panelAddUser.BackColor = groupBox1.BackColor = groupBox2.BackColor = System.Drawing.Color.MistyRose;
        }

        private void cbProv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
    
