
using Dapper;
using MySqlX.XDevAPI;
using Mysqlx;
using Positive;
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

namespace Positive.Presentacion
{
    public partial class Nuevo_usuario : Form
    {
        //  Persona persona = new Persona();
        // Contacto contacto = new Contacto();
        Usuario usuario = new Usuario();
        public Nuevo_usuario()
        {
            InitializeComponent();
        }

        private void panelAddUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userAdd_Load(object sender, EventArgs e)
        {
             
                 cbTDoc.Items.Clear();
                Tipo_documento tipo_doc = new Tipo_documento();
                cbTDoc.DataSource = tipo_doc.lista_tipo_doc();
                cbTDoc.DisplayMember = "descripcion";
                cbTDoc.ValueMember = "id_tipo_documento";
                cbTDoc.Refresh();

                cbRol.Items.Clear();
                Rol tipo_rol = new Rol();
            cbRol.DataSource = tipo_rol.lista_roles();
            cbRol.DisplayMember = "descripcion";
            cbRol.ValueMember = "id_rol";
            cbRol.Refresh();

                    
                cbStatus.Items.Clear();
                Estado tipo_estado = new Estado();
            cbStatus.DataSource = tipo_estado.lista_estados();
                cbStatus.DisplayMember = "descripcion";
                 cbStatus.ValueMember = "id_estado";
                 cbStatus.Refresh();
           

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

        private void btClean_MouseLeave(object sender, EventArgs e){
            btClean.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
        }

        private void btAddUser_Click(object sender, EventArgs e){
            Usuario usuario = new Usuario();
           usuario.INSERTCONTROL(tbUser.Text.Trim(), tbPass.Text, cbRol.SelectedIndex + 1, cbStatus.SelectedIndex + 1,
               TBNombre.Text.Trim(), textboxApellido.Text.Trim(),tbDNI.Text.Trim(), cbTDoc.SelectedIndex + 1 ,tbTel.Text.Trim(), 
            tbEmail.Text.Trim(),this );
        }

        

        public bool confirmacion_consulta(){
            bool ok=false;
             DialogResult resp = MessageBox.Show("Se guardara el usuario", "Éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                ok = true;
            }
            return ok;
        }

        public void confirmacion(){
            MessageBox.Show("Este usuario se ha guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clean();
        }
        public void negacion(){
            MessageBox.Show("Este usuario ya se ha registrado anteriormente.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

private void btClean_Click_1(object sender, EventArgs e)
{
   clean();
            
            }


private void clean()
{
   TBNombre.Clear();
   textboxApellido.Clear();
   tbDNI.Clear();
   tbEmail.Clear();
   tbTel.Clear();
   tbUser.Clear();
   tbPass.Clear();
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
  
       if (tbDNI.Text == "" || !int.TryParse(tbDNI.Text.Trim(), out _) || !(tbDNI.Text.Trim().Length >5 && tbDNI.Text.Trim().Length <10))
       {
           e.Cancel = true;
           errorProvider1.SetError(tbDNI, "Ingresar DNI(Solo números)");
           
       }
   
}
private void tbDNI_Validated(object sender, EventArgs e)
{
   errorProvider1.SetError(tbDNI, "");
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
   if (!(tbPass.Text.Length >= 3 && tbPass.Text.Length <= 100))
   {
       e.Cancel = true;
       errorProvider1.SetError(tbPass, "Debe contener entre 3 y 100 caracteres");
   }
}

private void tbPass_Validated(object sender, EventArgs e)
{
   errorProvider1.SetError(tbPass, "");
}


    }
}
    
