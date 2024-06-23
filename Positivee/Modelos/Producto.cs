
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Dapper;
using Positivee;
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
{ using System;
    using System.Collections.Generic;

    public partial class Producto
    {

        public int id_producto { get; set; }
        [Required(ErrorMessage = "El titulo es obligatorio.")]
        [StringLength(50, ErrorMessage = "El titulo debe tener como máximo 50 caracteres.")]

        public string titulo { get; set; }
        public string descripcion { get; set; }
        public string codigo { get; set; }
        public decimal precio_compra { get; set; }
        public decimal precio_venta { get; set; }
        public int id_categoria { get; set; }
        public int id_estado { get; set; }
        public int stock { get; set; } 

         Seccion_productos _principal;
        string _connectionString = Conexion.get_string();
        string action = "";
        //    public void INSERTCONTROL(string p_nombre_usuario, string p_password, int p_id_rol, int p_id_estado,
        //                 string p_nombre, string p_apellido, string p_numero_documento,
        //                     int p_id_tipo_documento, string p_telefono, string p_email, Nuevo_usuario p_nuevo_usuario) {
            
        public void INSERTCONTROL(string p_codigo,string p_titulo,string p_descripcion,
        string p_id_categoria,string p_id_estado,string p_precio_compra, string p_precio_venta,
            string p_stock,Nuevo_producto p_nuevo_producto)
        {
            try
            {
                if (!FINDCOD(p_codigo) || p_codigo == ""|| p_codigo==null)
                {

                    codigo = p_codigo;//tbCodeProd.Text.Trim();
                    titulo = p_titulo;//tbTitleProd.Text.Trim();
                    descripcion = p_descripcion;//tbDescProd.Text;
                    id_categoria =int.Parse( p_id_categoria);//cbCategorie.SelectedIndex+1;
                    id_estado = int.Parse(p_id_estado);//cbStatus.SelectedIndex+1;
                    precio_compra =decimal.Parse( p_precio_compra);// decimal.Parse( tbPriceProd.Text);
                    precio_venta = decimal.Parse(p_precio_venta);//decimal.Parse(tbPrecV.Text); 
                    stock = int.Parse(p_stock);//int.Parse(tbStockProd.Text.Trim());
                    if (GUARDAR_PRODUCTO())
                    {
                        p_nuevo_producto.exito();
                    }
                    else
                    {
                        p_nuevo_producto.fallo();
                    }

                }
                else
                {
                    p_nuevo_producto.cod_ya_registrado();
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Ha ocurrido un error." + ex, "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        } 
     
                
            

      private bool FINDCOD(string p_cod)
        {
            bool exist = false;
            using (var db = new MySqlConnector.MySqlConnection(_connectionString))
            {
                var LISTEXIST = db.Query(
                           sql: "search_producto_cod",
                           param: new { p_cod = p_cod },
                           commandType: CommandType.StoredProcedure
                );
                if (LISTEXIST.Count() > 0)
                {
                    exist = true;
                }
            }
            return exist;
        }



        private bool GUARDAR_PRODUCTO()
        {
            bool ok = false;

            try
            {
                using (var db = new MySqlConnector.MySqlConnection(_connectionString))
                {

                    var queryAdd = db.Execute(
                                         sql: "add_product",
                                   param: new
                                   {
                                       @p_titulo = titulo,
                                       @p_descripcion = descripcion,
                                       @p_codigo = codigo,
                                       @p_precio_compra = precio_venta,
                                       @p_precio_venta = precio_venta,
                                       @p_id_categoria = id_categoria,
                                       @p_id_estado = id_estado,
                                       @p_stock = stock

                                   },
                                       commandType: CommandType.StoredProcedure);
                    ok = true;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error inesperado" + e);
            }
            return ok;
        }
       
        public List<dynamic> listar_productos(){
            
            try
            {   using (var db = new MySqlConnector.MySqlConnection(_connectionString))
                {
                    var LISTLOAD = db.Query(
                                   sql: "all_products",
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
        /// <summary>
        /// //
        /// </summary>
        /// <param name="p_id"></param>
        /// <param name="p_menu"></param>
          public void seleccion_editar(string p_id, Seccion_productos p_menu)
        {
            int ide = int.Parse(p_id);
            
            try
            {
                using (var db = new MySqlConnector.MySqlConnection(_connectionString))
                {
                    var PROD = db.QueryFirst(
                               sql: "search_producto_id",
                               param: new { @p_id_producto = ide },
                               commandType: CommandType.StoredProcedure
                    );
                    codigo = PROD.codigo;
                    descripcion = PROD.descripcion;
                    id_categoria = PROD.id_categoria;
                    id_estado = PROD.id_estado;
                    id_producto = PROD.id_producto;
                    precio_compra = PROD.precio_compra;
                    precio_venta = PROD.precio_venta;
                    stock = PROD.stock;
                    titulo = PROD.titulo;
                }
                Editar_producto editar_prod = new Editar_producto();
                editar_prod.cargar_datos(codigo,descripcion,id_categoria,id_estado,id_producto,precio_compra,precio_venta,stock,titulo);
                p_menu.mostrar_menu_editar(editar_prod);

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar " + ex);
            }

        }

       
        public void INSERTCONTROLEDIT(string p_codigo,string p_titulo,string p_descripcion,
        int p_id_categoria,int p_id_estado,string p_precio_compra, string p_precio_venta,
            string p_stock,Editar_producto p_editar_producto) {
            try
            {
                if (FINDCOD(p_codigo))
                {
                    codigo = p_codigo;//tbCodeProd.Text.Trim();
                    titulo = p_titulo;//tbTitleProd.Text.Trim();
                    descripcion = p_descripcion;//tbDescProd.Text;
                    id_categoria = p_id_categoria;//cbCategorie.SelectedIndex+1;
                    id_estado = p_id_estado;//cbStatus.SelectedIndex+1;
                    precio_compra = decimal.Parse(p_precio_compra);// decimal.Parse( tbPriceProd.Text);
                    precio_venta = decimal.Parse(p_precio_venta);//decimal.Parse(tbPrecV.Text); 
                    stock = int.Parse(p_stock);//int.Parse(tbStockProd.Text.Trim());
                    DialogResult resp = MessageBox.Show("Se actualizara el producto", "Éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resp == DialogResult.Yes)
                    {
                        GUARDAR_PRODUCTO_EDITADO();
                        MessageBox.Show("Este producto se ha guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error." + ex, "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void GUARDAR_PRODUCTO_EDITADO() {

            using (var db = new MySqlConnector.MySqlConnection(_connectionString))
            {

                var queryAdd = db.ExecuteReader(
                                   sql: "edit_product",
                                   param: new
                                   {
                                       @p_id_producto = id_producto,
                                       @p_titulo = titulo,
                                       @p_descripcion = descripcion,
                                       @p_codigo = codigo,
                                       @p_precio_compra = precio_compra,
                                       @p_precio_venta = precio_venta,
                                       @p_id_categoria = id_categoria,
                                       @p_id_estado = id_estado,

                                   },
                                   commandType: CommandType.StoredProcedure);

            }
        }
         public void eliminar_producto(string p_id)
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
                                  sql: "delete_producto_id",
                                  param: new { @p_id = id },
                                  commandType: CommandType.StoredProcedure);
                    }
                    MessageBox.Show("Eliminado correctamente ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo eliminar " + ex);
                } }
          }
           public string restaurar_producto(string p_id)
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
                                   sql: "restore_producto_id",
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
    
/////seccion pantalla venta
///  
    public List<dynamic> cargar_productos_venta()
        {
            List<dynamic> lista_prod;

            using (var db = new MySqlConnector.MySqlConnection(_connectionString))
            {
                var lista = db.Query<dynamic>(
                          sql: "all_products_sale",
                          commandType: CommandType.StoredProcedure);
                lista_prod = lista.ToList();
            }
            return lista_prod;
        }
    }
}
