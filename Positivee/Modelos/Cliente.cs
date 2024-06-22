
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
using Positive.Presentacion;
namespace Positive
{
    using Mysqlx;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Cliente : Persona
    {


        public int id_cliente { get; set; }
        public int id_estado { get; set; }
        Seccion_clientes _principal;
        string _connectionString = Conexion.get_string();
        string action = "";
        Contacto contacto = new Contacto();

        public void INSERTCONTROL(int p_id_estado,
                         string p_nombre, string p_apellido, string p_numero_documento,
                             int p_id_tipo_documento, string p_telefono, string p_email, Nuevo_cliente p_nuevo_cliente)
        {
            try
            {
                if (!FINDDNI(p_numero_documento))
                {
                    if (crear_cliente(p_id_estado,
                         p_nombre, p_apellido, p_numero_documento,
                             p_id_tipo_documento, p_telefono, p_email,
                              p_nuevo_cliente))
                    {
                        DialogResult resp = MessageBox.Show("Se guardara el usuario", "Éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resp == DialogResult.Yes)
                        {
                            INSERTELEM();
                            MessageBox.Show("Este cliente se ha guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                    }


                }
                else
                {
                    MessageBox.Show("Este cliente ya se ha registrado anteriormente.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error." + ex, "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private bool crear_cliente(int p_id_estado,
                        string p_nombre, string p_apellido, string p_numero_documento,
                        int p_id_tipo_documento, string p_telefono, string p_email, Nuevo_cliente p_nuevo_cliente)
        {
            bool ok=false;
            if (p_nuevo_cliente.ValidateChildren(ValidationConstraints.Enabled))
            {
                
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

         private bool FINDDNI(string dni)
        {
            bool exist = false;
            using (var db = new MySqlConnector.MySqlConnection(_connectionString))
            {
                var LISTEXIST = db.Query(
                           sql: "search_client_dni",
                           param: new { @p_dni = dni },
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
                                   sql: "add_client",
                                   param: new
                                   {
                                       @p_email = contacto.email,
                                       @p_telefono = contacto.telefono,
                                       @p_nombre = nombre,
                                       @p_apellido = apellido,
                                       @p_tipo_doc = id_tipo_documento,
                                       @p_numero_documento = numero_documento,
                                      
                                      
                                          @p_id_estado = id_estado,
                                   },
                                   commandType: CommandType.StoredProcedure);
             
            }
        }
        public List<dynamic> listar_clientes()
        {

            try
            {
                using (var db = new MySqlConnector.MySqlConnection(_connectionString))
                {
                    var LISTLOAD = db.Query(
                                  sql: "all_clients",
                                  commandType: CommandType.StoredProcedure);

                    List<dynamic> listado_clientes = LISTLOAD.ToList();

                    return listado_clientes;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar datos" + ex);
                return null;
            }
        }
             
             public void seleccion_editar(string p_id, Seccion_clientes p_menu)
        {
            int ide = int.Parse(p_id);
            
            try
            {
                using (var db = new MySqlConnector.MySqlConnection(_connectionString))
                {
                    var USER = db.QueryFirst(
                               sql: "search_client_edit",
                               param: new { @p_id_cliente = p_id },
                               commandType: CommandType.StoredProcedure
                    );
                    id_cliente = USER.id_cliente;
                   id_persona = USER.id_persona;
                    
                    id_estado = USER.id_estado;
                   
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
                Editar_cliente edit_cliente = new Editar_cliente();
                p_menu.mostrar_menu_editar(edit_cliente);
                edit_cliente.cargar_datos(nombre,apellido, id_tipo_documento, numero_documento,
                    contacto.telefono, contacto.email, id_cliente, id_estado, id_persona, id_contacto);
               
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar " + ex);
            }

        } 
        public void INSERTCONTROLEDIT(int cbStatus, string TBNombre, string textboxApellido,
        string  tbDNI,int cbTDoc,string tbTel,string tbEmail,int  p_id_cliente,int p_id_persona,int p_id_contacto,Editar_cliente p_edit) {

            if (FINDDNI(tbDNI))
            {
                
                id_estado = cbStatus;
                nombre = TBNombre;
                apellido = textboxApellido;
                numero_documento = tbDNI;
                id_tipo_documento = cbTDoc;

                id_cliente = p_id_cliente;
                id_persona = p_id_persona;
                id_contacto = p_id_contacto;
                contacto.telefono = tbTel;
                contacto.email = tbEmail;
                if (GUARDAR_CLIENTE())
                {
                    p_edit.exito();
                }
                else
                {
                    p_edit.fallo();
                }


            }
            else
            {
                p_edit.dni_no_encontrado();
            }
            
        }
  private bool GUARDAR_CLIENTE()
    { bool ok = false;

            try { using (var db = new MySqlConnector.MySqlConnection(_connectionString))
                {

                    var queryAdd = db.Execute(
                                       sql: "edit_client",
                                       param: new
                                       {
                                           @p_telefono = contacto.telefono,
                                           @p_email = contacto.email,
                                           @p_id_contacto = contacto.id_contacto,
                                           @p_apellido = apellido,
                                           @p_nombre = nombre,
                                           @p_tipo_doc = id_tipo_documento,
                                           @p_id_persona = id_persona,

                                           @p_id_estado = id_estado,
                                           @p_id_cliente = id_cliente,

                                       },
                                       commandType: CommandType.StoredProcedure);
                    ok = true;
                }

            }
            catch(Exception e)
            {
                
            }
            return ok;
    }  
    public void eliminar_cliente(string p_id)
        {
           
            int id = int.Parse(p_id);
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este cliente?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    using (var db = new MySqlConnector.MySqlConnection(_connectionString))
                    {

                        var elem_eliminado = db.Execute(
                                  sql: "delete_client_id",
                                  param: new { @p_id = id },
                                  commandType: CommandType.StoredProcedure);
                    }
                    MessageBox.Show("Cliente eliminado ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo eliminar " + ex);
                } }
          }
 public string restaurar_cliente(string p_id)
        {
            string mensaje = "";
            int id = int.Parse(p_id);
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea restaurar a este cliente?", "Confirmar Restauración", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    using (var db = new MySqlConnector.MySqlConnection(_connectionString))
                    {

                        var elem_eliminado = db.Execute(
                                  sql: "restore_client_id",
                                  param: new { @p_id = id },
                                  commandType: CommandType.StoredProcedure);
                    }
                    MessageBox.Show("Cliente restaurado ");
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
