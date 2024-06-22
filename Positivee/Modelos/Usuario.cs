
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Dapper;
using Positive;
using Positive.Presentacion;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using MySqlX.XDevAPI;
using System.Diagnostics.Contracts;
namespace Positive
{


    public class Usuario : Persona
    {

        //atributos
        public int id_usuario { get; set; }
        public int id_rol { get; set; }

        [Required(ErrorMessage = "El nombre de usuario es obligatorio.")]
        [StringLength(50, ErrorMessage = "El nombre de usuario debe tener como máximo 50 caracteres.")]
        public string nombre_usuario { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "La contraseña debe tener entre 6 y 100 caracteres.")]
        public string password { get; set; }
        public int id_estado { get; set; }


        Seccion_usuarios _principal;
        string _connectionString = Conexion.get_string();
        string action = "";
        Contacto contacto = new Contacto();

        //metodos
        //validar usuario
        public void validar_usuario(string p_user, string p_pass, Login p_login) {

            string username = p_user;
            string password = p_pass;
            Usuario usuarioAutenticado;
            Login login = p_login;
            try
            {
                using (var db = new MySqlConnector.MySqlConnection(_connectionString))
                {
                    usuarioAutenticado = db.QueryFirst<Usuario>(
                              sql: "login",
                              param: new { p_username = username, p_password = password },
                              commandType: CommandType.StoredProcedure);
                }
                if (usuarioAutenticado != null)
                {
                    login.Hide();
                    //crear menu principal
                    // Muestra el formulario principal
                    Control.cargar_usuario(usuarioAutenticado);
                    Control.cargar_login(p_login);
                    Control.crear_menu_principal();
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar la busqueda del usuario " + ex);
            }
        }

        public void INSERTCONTROL(string p_nombre_usuario, string p_password, int p_id_rol, int p_id_estado,
                        string p_nombre, string p_apellido, string p_numero_documento,
                            int p_id_tipo_documento, string p_telefono, string p_email, Nuevo_usuario p_nuevo_usuario) {
            try
            {
                if(!FINDDNI(p_numero_documento)){
                    if (crear_usuario(p_nombre_usuario, p_password, p_id_rol, p_id_estado,
                            p_nombre, p_apellido, p_numero_documento,
                                p_id_tipo_documento, p_telefono, p_email, p_nuevo_usuario)) {
                        DialogResult resp = MessageBox.Show("Se guardara el usuario", "Éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resp == DialogResult.Yes)
                        {
                            INSERTELEM();
                            MessageBox.Show("Este usuario se ha guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                    }
                } }
            catch (Exception ex)
            { MessageBox.Show("Ha ocurrido un error." + ex, "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        } 


        private bool crear_usuario(string p_nombre_usuario, string p_password, int p_id_rol, int p_id_estado,
                        string p_nombre, string p_apellido, string p_numero_documento,
                            int p_id_tipo_documento, string p_telefono, string p_email, Nuevo_usuario p_nuevo_usuario)
        {
            bool ok=false;
            if (p_nuevo_usuario.ValidateChildren(ValidationConstraints.Enabled))
            {
                nombre_usuario = p_nombre_usuario; 
                password = p_password  ;
                id_rol = p_id_rol;
                id_estado= p_id_estado;
                nombre = p_nombre;
                apellido = p_apellido;
                numero_documento = p_numero_documento;
                id_tipo_documento = p_id_tipo_documento;
                contacto.telefono = p_telefono;
                contacto.email = p_email;
                ok=true;}
                return ok;
        }
         /*private bool FINDUSER(string user)
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
        }*/
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
                                       @p_nombre = nombre,
                                       @p_apellido = apellido,
                                       @p_tipo_doc = id_tipo_documento,
                                       @p_numero_documento = numero_documento,
                                       @p_id_rol = id_rol,
                                       @p_nombre_usuario = nombre_usuario,
                                         @p_password = password,
                                          @p_id_estado = id_estado,
                                   },
                                   commandType: CommandType.StoredProcedure);
             
            }
        }

        public List<dynamic> listar_usuarios(){
            
            try
            {   using (var db = new MySqlConnector.MySqlConnection(_connectionString))
                {
                    var LISTLOAD = db.Query(
                                  sql: "all_users",
                                  commandType: CommandType.StoredProcedure);

                    List<dynamic> listado_usuarios= LISTLOAD.ToList(); 
                   
                    return listado_usuarios;
                 }
            }
            catch (Exception ex){
                MessageBox.Show("No se pudo cargar datos" + ex);
                return null;
                }
                
             }

        public void seleccion_editar(string p_id, Seccion_usuarios p_menu)
        {
            int ide = int.Parse(p_id);
            
            try
            {
                using (var db = new MySqlConnector.MySqlConnection(_connectionString))
                {
                    var USER = db.QueryFirst(
                               sql: "search_user_edit",
                               param: new { @p_id_usuario = p_id },
                               commandType: CommandType.StoredProcedure
                    );
                    id_usuario = USER.id_usuario;
                   id_persona = USER.id_persona;
                    nombre_usuario = USER.nombre_usuario;
                    id_estado = USER.id_estado;
                    id_rol = USER.id_rol;
                    nombre = USER.nombre;
                    id_persona = USER.id_persona;
                    id_contacto = USER.id_contacto;
                    id_tipo_documento = USER.id_tipo_documento;
                    numero_documento = USER.numero_documento;
                    apellido = USER.apellido;
                    id_contacto = USER.id_contacto;
                    contacto.telefono = USER.telefono;
                    contacto.email = USER.email;
                }
                p_menu.seleccion_editar(this, contacto);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar " + ex);
            }

        }
        public void INSERTCONTROLEDIT(string tbUser,int cbRol,int cbStatus, string TBNombre, string textboxApellido,
        string  tbDNI,int cbTDoc,string tbTel,string tbEmail,Editar_usuario p_ed) {

            if (FINDDNI(tbDNI))
            {

                nombre_usuario = tbUser;
                id_rol = cbRol;
                id_estado = cbStatus;


                nombre = TBNombre;
                apellido = textboxApellido;
                numero_documento = tbDNI;
                id_tipo_documento = cbTDoc;


                contacto.telefono = tbTel;
                contacto.email = tbEmail;
                if (p_ed.confirmacion_consulta())
                {
                    GUARDAR_USUARIO();
                    p_ed.confirmacion();
                }
            }
            else
            {
                p_ed.negacion();
            }
            }

           
    private void GUARDAR_USUARIO()
    {

        using (var db = new MySqlConnector.MySqlConnection(_connectionString))
        {

            var queryAdd = db.ExecuteReader(
                               sql: "edit_user",
                               param: new
                               {
                                   @p_id_contacto = contacto.id_contacto,
                                   @p_email = contacto.email,
                                   @p_telefono = contacto.telefono,
                                   @p_id_persona = id_persona,
                                   @p_nombre = nombre,
                                   @p_apellido = apellido,
                                   @p_tipo_doc = id_tipo_documento,
                                   @p_numero_documento = numero_documento,
                                   @p_id_usuario = id_usuario,
                                   @p_id_rol = id_rol,
                                   @p_nombre_usuario = nombre_usuario,
                                   @p_id_estado = id_estado,
                               },
                               commandType: CommandType.StoredProcedure);

        }
    }

        public void eliminar_usuario(string p_id)
        {
           
            int id = int.Parse(p_id);
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este usuario?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    using (var db = new MySqlConnector.MySqlConnection(_connectionString))
                    {

                        var elem_eliminado = db.Execute(
                                  sql: "delete_user_id",
                                  param: new { @p_id = id },
                                  commandType: CommandType.StoredProcedure);
                    }
                    MessageBox.Show("Usuario eliminado ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo eliminar " + ex);
                } }
          }
        public string restaurar_usuario(string p_id)
        {
            string mensaje = "";
            int id = int.Parse(p_id);
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea restaurar a este usuario?", "Confirmar Restauración", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    using (var db = new MySqlConnector.MySqlConnection(_connectionString))
                    {

                        var elem_eliminado = db.Execute(
                                  sql: "restore_user_id",
                                  param: new { @p_id = id },
                                  commandType: CommandType.StoredProcedure);
                    }
                    MessageBox.Show("Usuario restaurado ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo restaurar " + ex);
                }
                
            }
            
            return mensaje;
        }
    }
    
}
