
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
        private  string _connectionString = Conexion.get_string();
         Persona persona = new Persona();
        Contacto contacto = new Contacto();
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
            loadDropdownData();
        }

        private void loadDropdownData()  //Carga los datos del dropdown
        {
            try
            {
                using (var db = new MySqlConnector.MySqlConnection(_connectionString))
                {
                    var rolesQuery = db.Query<Rol>(
                                  sql: "all_rols_d",
                                  commandType: CommandType.StoredProcedure);
                   
                    cbRol.Items.Clear();
                    cbRol.DataSource = rolesQuery.ToList();
                    cbRol.DisplayMember = "descripcion";
                    cbRol.ValueMember = "id_rol";
                    cbRol.Refresh();

                    var tipo_doc = db.Query<Tipo_documento>(
                                 sql: "all_type_doc_d",
                                 commandType: CommandType.StoredProcedure);

                    cbTDoc.Items.Clear();
                    cbTDoc.DataSource = tipo_doc.ToList();
                    cbTDoc.DisplayMember = "descripcion";
                    cbTDoc.ValueMember = "id_tipo_documento";
                    cbTDoc.Refresh();

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

        private void btAddUser_Click(object sender, EventArgs e)
        {
            INSERTCONTROL();
        }

        private bool FINDUSER(string user)
        {
            bool exist = false;
            using (var db = new MySqlConnector.MySqlConnection(_connectionString))
            {
                var LISTEXIST = db.Query(
                           sql: "search_user",
                           param: new { p_user = user },
                           commandType: CommandType.StoredProcedure
                );
                if (LISTEXIST.Count() > 0)
                {
                    exist = true;
                }
            }
            return exist;
        }
        private bool FINDDNI(string dni)
        {
            bool exist = false;
            using (var db = new MySqlConnector.MySqlConnection(_connectionString))
            {
                var LISTEXIST = db.Query(
                           sql: "search_user_dni",
                           param: new { p_dni = dni },
                           commandType: CommandType.StoredProcedure
                );
                if (LISTEXIST.Count() > 0)
                {
                    exist = true;
                }
            }
            return exist;
        }

        private void INSERTCONTROL()
        {

            try
            {

               // this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;


                if (this.ValidateChildren(ValidationConstraints.Enabled) && !FINDDNI(tbDNI.Text))
                {

                    usuario.nombre_usuario = tbUser.Text.Trim();
                    usuario.password = tbPass.Text;
                    usuario.id_rol = cbRol.SelectedIndex + 1;
                    usuario.id_estado= cbStatus.SelectedIndex + 1;


                    persona.nombre = TBNombre.Text.Trim();
                    persona.apellido = textboxApellido.Text.Trim();
                    persona.numero_documento = tbDNI.Text.Trim();
                    persona.id_tipo_documento = cbTDoc.SelectedIndex + 1;


                    contacto.telefono = tbTel.Text.Trim();
                    contacto.email = tbEmail.Text.Trim();
                    DialogResult resp = MessageBox.Show("Se guardara el usuario", "Éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resp == DialogResult.Yes)
                    {
                        INSERTELEM();
                        MessageBox.Show("Este usuario se ha guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }



            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error."+ex, "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
                
            }
        

        private void INSERTELEM()
        {
            
            using (var db = new MySqlConnector.MySqlConnection(_connectionString))
            {

                var queryAdd = db.ExecuteReader(
                                   sql: "add_user",
                                   param: new
                                   {
                                       @p_email = contacto.email,
                                       @p_telefono = contacto.telefono,
                                       @p_nombre = persona.nombre,
                                       @p_apellido = persona.apellido,
                                       @p_tipo_doc = persona.id_tipo_documento,
                                       @p_numero_documento = persona.numero_documento,
                                       @p_id_rol = usuario.id_rol,
                                       @p_nombre_usuario = usuario.nombre_usuario,
                                         @p_password = usuario.password,
                                          @p_id_estado = usuario.id_estado,
                                   },
                                   commandType: CommandType.StoredProcedure);
             
            }
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
    
