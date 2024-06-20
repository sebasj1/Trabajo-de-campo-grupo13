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
        string _connectionString = "Server=mysql-proyectois2.alwaysdata.net;Database=proyectois2_puntoventa;User Id=362639;Password=Pollito1q;";
        Usuario usuario = new Usuario();
        Persona persona= new Persona();
        Contacto contacto=  new Contacto();
        Seccion_usuarios _principal;
        public Editar_usuario(int p_id,Seccion_usuarios p_principal)
        {
            InitializeComponent();
            _principal = p_principal;
            FINDUSERID(p_id);
        }

        private void editar_usuario_Load(object sender, EventArgs e)
        {

        }

        private void FINDUSERID(int p_id)
        {
            try
            {
                using (var db = new MySqlConnector.MySqlConnection(_connectionString))
                {
                    var USER = db.QueryFirst(
                               sql: "search_user_edit",
                               param: new { @p_id_usuario = p_id },
                               commandType: CommandType.StoredProcedure
                    );
                    usuario.id_usuario = USER.id_usuario;
                    usuario.id_persona = USER.id_persona;
                    usuario.nombre_usuario = USER.nombre_usuario;
                    usuario.id_estado = USER.id_estado;
                    usuario.id_rol = USER.id_rol;
                    persona.nombre = USER.nombre;
                    persona.id_persona = USER.id_persona;
                    persona.id_contacto = USER.id_contacto;
                    persona.id_tipo_documento = USER.id_tipo_documento;
                    persona.numero_documento = USER.numero_documento;
                    persona.apellido = USER.apellido;
                    contacto.id_contacto = USER.id_contacto;
                    contacto.telefono = USER.telefono;
                    contacto.email = USER.email;
                }
                cargar_datos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar " + ex);
            }

    }
        private void cargar_datos()
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

            tbUser.Text = usuario.nombre_usuario;
            cbRol.SelectedIndex = usuario.id_rol-1;
            cbStatus.SelectedIndex = usuario.id_estado-1;


            TBNombre.Text = persona.nombre;
            textboxApellido.Text = persona.apellido;
            tbDNI.Text = persona.numero_documento;
            cbTDoc.SelectedIndex = persona.id_tipo_documento-1;


            tbTel.Text = contacto.telefono;
            tbEmail.Text = contacto.email;
        }
        private bool FINDDNIUSER(string dni)
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

        private void btAddUser_Click(object sender, EventArgs e)
        {
            INSERTCONTROLEDITION();
        }
        private void INSERTCONTROLEDITION()
        {

            try
            {

                this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;


                if (this.ValidateChildren(ValidationConstraints.Enabled) && FINDDNIUSER(tbDNI.Text))
                {

                    usuario.nombre_usuario = tbUser.Text.Trim();
                    usuario.id_rol = cbRol.SelectedIndex + 1;
                    usuario.id_estado = cbStatus.SelectedIndex + 1;


                    persona.nombre = TBNombre.Text.Trim();
                    persona.apellido = textboxApellido.Text.Trim();
                    persona.numero_documento = tbDNI.Text.Trim();
                    persona.id_tipo_documento = cbTDoc.SelectedIndex + 1;


                    contacto.telefono = tbTel.Text.Trim();
                    contacto.email = tbEmail.Text.Trim();
                    DialogResult resp = MessageBox.Show("Se guardaran los datos del usuario", "Éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resp == DialogResult.Yes)
                    {
                        GUARDAR_USUARIO();
                        MessageBox.Show("Este usuario se ha actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        _principal.recargar_lista("edit"); 
                        this.Dispose();
                    }
                }
            
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

                MessageBox.Show("Ha ocurrido un error." + ex, "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void GUARDAR_USUARIO()
        {

            using (var db = new MySqlConnector.MySqlConnection(_connectionString))
            {

                var queryAdd = db.ExecuteReader(
                                   sql: "edit_user",
                                   param: new
                                   {    @p_id_contacto=contacto.id_contacto,
                                       @p_email = contacto.email,
                                       @p_telefono = contacto.telefono,
                                       @p_id_persona=persona.id_persona,
                                       @p_nombre = persona.nombre,
                                       @p_apellido = persona.apellido,
                                       @p_tipo_doc = persona.id_tipo_documento,
                                       @p_numero_documento = persona.numero_documento,
                                       @p_id_usuario = usuario.id_usuario,
                                       @p_id_rol = usuario.id_rol,
                                       @p_nombre_usuario = usuario.nombre_usuario,
                                       @p_id_estado = usuario.id_estado,
                                   },
                                   commandType: CommandType.StoredProcedure);

            }
        }

        private void panelAddUser_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

