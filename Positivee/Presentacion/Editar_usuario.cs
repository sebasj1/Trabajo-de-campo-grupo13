using Dapper;
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
    public partial class Editar_usuario : Form
    {
        string _connectionString =Conexion.get_string();
        Usuario usuario_en_editar = new Usuario();
        Persona persona= new Persona();
        Contacto contacto=  new Contacto();
        Seccion_usuarios _principal;
        public Editar_usuario()
        {
            InitializeComponent();
        }

        private void editar_usuario_Load(object sender, EventArgs e)
        {

        }

      
        public void cargar_datos(Usuario p_usuario,Contacto p_contacto)
        {
            usuario_en_editar = p_usuario;
           


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
                cbStatus.DataSource = tipo_estado.buscar_estado();
                cbStatus.DisplayMember = "descripcion";
                cbStatus.ValueMember = "id_estado";
                cbStatus.Refresh();

            

            tbUser.Text = p_usuario.nombre_usuario;
            cbRol.SelectedIndex = p_usuario.id_rol-1;
            cbStatus.SelectedIndex = p_usuario.id_estado-1;


            TBNombre.Text = p_usuario.nombre;
            textboxApellido.Text = p_usuario.apellido;
            tbDNI.Text = p_usuario.numero_documento;
            cbTDoc.SelectedIndex =p_usuario.id_tipo_documento-1;


            tbTel.Text = p_contacto.telefono;
            tbEmail.Text = p_contacto.email;
        }
       
        private void btAddUser_Click(object sender, EventArgs e)
        {
            

            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;


            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                usuario_en_editar.insertar_usuario_editar(tbUser.Text.Trim(), cbRol.SelectedIndex + 1, cbStatus.SelectedIndex + 1,
                TBNombre.Text.Trim(), textboxApellido.Text.Trim(), tbDNI.Text.Trim(), cbTDoc.SelectedIndex + 1, tbTel.Text.Trim(),
             tbEmail.Text.Trim(), this);

            }
            
            //INSERTCONTROLEDITION();
        }
     
        public bool confirmacion_consulta()
        {
            bool ok = false;
            DialogResult resp = MessageBox.Show("Se actualizará el usuario", "Éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                ok = true;
            }
            return ok;
        }

        public void confirmacion()
        {
            MessageBox.Show("Este usuario se ha actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public void negacion()
        {
            MessageBox.Show("Este usuario ya se ha registrado anteriormente.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void clean()
        {
            TBNombre.Clear();
            textboxApellido.Clear();
            tbDNI.Clear();
            tbEmail.Clear();
            tbTel.Clear();
            tbUser.Clear();
        }

        private void panelAddUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btClean_Click(object sender, EventArgs e)
        {
            clean();
        }
    }
    }

