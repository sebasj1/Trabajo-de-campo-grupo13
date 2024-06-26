
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
        public Seccion_clientes _principal; 

         string _connectionString = Conexion.get_string();
         string action = "";
        Contacto contacto = new Contacto();

        public void insertar_cliente(int p_estado, string p_nombre, string p_apellido,
        string p_nro_doc, int p_tipo_doc, string p_tel, string p_email,Nuevo_cliente p_cliente_Nuevo)
        {

            if (!buscar_nro_doc(p_nro_doc))
            {

                id_estado = p_estado;
                nombre = p_nombre;
                apellido = p_apellido;
                numero_documento = p_nro_doc;
                id_tipo_documento = p_tipo_doc;
                contacto.telefono = p_tel;
                contacto.email = p_email;
                if (guardar_cliente())
                {
                    p_cliente_Nuevo.exito();
                }
                else
                {
                    p_cliente_Nuevo.fallo();
                }


            }
            else
            {
                p_cliente_Nuevo.nro_ya_encontrado();
            }

        }
     

         private bool buscar_nro_doc(string dni)
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
    private bool guardar_cliente()
        {
            bool ok = false;
            try { 
                using (var db = new MySqlConnector.MySqlConnection(_connectionString))
                {
                    var queryAdd = db.Execute(
                                sql: "add_client",
                                param: new
                                {
                                    @p_email = contacto.email,
                                    @p_telefono = contacto.telefono,
                                    @p_nombre = nombre,
                                    @p_apellido = apellido,
                                    @p_tipo_doc = id_tipo_documento,
                                    @p_numero_documento = numero_documento,


                                    @p_estado = id_estado,
                                },
                                    commandType: CommandType.StoredProcedure);
                    ok = true;
                }

            }
            catch(Exception e)
            {
                MessageBox.Show("Error inesperado" + e);
            }
            return ok;
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
                edit_cliente.cargar_datos(nombre,apellido, id_tipo_documento, numero_documento,
                    contacto.telefono, contacto.email, id_cliente, id_estado, id_persona, id_contacto);
                p_menu.mostrar_menu_editar(edit_cliente);
                
               
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar " + ex);
            }

        } 
        public void guardar_cliente_editado(int cbStatus, string TBNombre, string textboxApellido,
        string  tbDNI,int cbTDoc,string tbTel,string tbEmail,int  p_id_cliente,int p_id_persona,int p_id_contacto,Editar_cliente p_edit) {

            if (buscar_nro_doc(tbDNI))
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
                if (guardar_cliente_edit())
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
  private bool guardar_cliente_edit()
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
                MessageBox.Show("Error inesperado" + e);
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
 public void restaurar_cliente(string p_id)
        {
            
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
            
            
        }

        private List<dynamic> buscar_cliente_nro_doc(string p_nro_doc)
        {
            List<dynamic> datos_cliente = new List<dynamic>();
           
            try
            {
                using (var db = new MySqlConnector.MySqlConnection(_connectionString))
                {
                    var LISTEXIST = db.Query(
                               sql: "search_client_nro_active",
                               param: new { @p_dni = p_nro_doc },
                               commandType: CommandType.StoredProcedure
                    );
                    datos_cliente = LISTEXIST.ToList();
                }
                
            }
            catch(Exception e)
            {
                MessageBox.Show("Error " + e);
            }return datos_cliente;
        }

         public List<dynamic> listar_clientes_activos()
        {
            List<dynamic> datos_cliente = new List<dynamic>();

            try
            {
                using (var db = new MySqlConnector.MySqlConnection(_connectionString))
                {
                    var LISTEXIST = db.Query(
                               sql: "search_clients_active",
                               param: new {  },
                               commandType: CommandType.StoredProcedure
                    );
                    datos_cliente = LISTEXIST.ToList();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e);
            }
            return datos_cliente;
        }
        private List<dynamic> buscar_cliente_apellido(string p_apellido)
        {
            List<dynamic> datos_cliente = new List<dynamic>();

            try
            {
                using (var db = new MySqlConnector.MySqlConnection(_connectionString))
                {
                    var LISTEXIST = db.Query(
                               sql: "search_client_surname",
                               param: new { @p_apellido = p_apellido },
                               commandType: CommandType.StoredProcedure
                    );
                    datos_cliente = LISTEXIST.ToList();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e);
            }
            return datos_cliente;
        }
        public List<dynamic> busca_datos_cliente(string p_busca)
        {
            List<dynamic> datos_cliente =new  List<dynamic>();
            int numero;
            if (Int32.TryParse(p_busca, out numero))
            {
                datos_cliente=buscar_cliente_nro_doc(p_busca);
            }
            else
            {
                datos_cliente=buscar_cliente_apellido(p_busca);
            }
            return datos_cliente;
        }
    }
}
