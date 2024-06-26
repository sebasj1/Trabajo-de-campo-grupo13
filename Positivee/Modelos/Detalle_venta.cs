using Dapper;
using FontAwesome.Sharp;
using Positive.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Positive
{
    using System;
    using System.Collections.Generic;

    public partial class Detalle_venta
    {
        public int id_detalle_venta { get; set; }
        public int id_venta { get; set; }
        public int id_producto { get; set; }
        public int cantidad { get; set; }
        public decimal subtotal { get; set; }

        private List<Detalle_venta> carrito = new List<Detalle_venta>();
        private List<dynamic> lista_prod = null;
        private List<dynamic> lista_prod_carrito = new List<dynamic>();
        /*
        public void cargar_todos_los_productos()
        {
            Producto producto_para_cargar_todos = new Producto();
            lista_prod = producto_para_cargar_todos.cargar_productos_todos();
        }
        */
        string _connectionString = Conexion.get_string();
        public List<dynamic> cargar_carrito(string p_id_prod, string p_titulo, string p_precio, string p_stock)
        {
            int c_id = int.Parse(p_id_prod);
            decimal c_precio = decimal.Parse(p_precio);
            int c_stock = int.Parse(p_stock);
            
            

            if (!(lista_prod_carrito.Count(u => u.id_producto == c_id) > 0))
            {dynamic prod=new {id_producto=c_id,titulo= p_titulo, precio= c_precio, subtotal= c_precio, cantidad=1,stock= c_stock };
                
               
                lista_prod_carrito.Add(prod);
            }
            else
            { dynamic prod1 = lista_prod_carrito.First(u => u.id_producto == c_id);
                 dynamic prod= new {
                     id_producto = prod1.id_producto, 
                     titulo = prod1.titulo,
                     precio = prod1.precio, 
                     subtotal =prod1.subtotal+ c_precio, 
                     cantidad = prod1.cantidad+1, 
                     stock = prod1.stock
                 };
                lista_prod_carrito[lista_prod_carrito.FindIndex(u => u.id_producto == c_id)] = prod;
                
               //lista_prod_carrito.First(u => u.id_producto == c_id).subtotal += c_precio;
                
                //sumProd(carrito.IndexOf(indice));
            }
            return lista_prod_carrito;

        }

        public List<dynamic> restar_prod(int pProd)
        {

            if (pProd>= 0)
            {
                if (lista_prod_carrito[pProd].cantidad > 1)
                {
                    dynamic prod1 = lista_prod_carrito[pProd];
                    dynamic prod = new
                    {
                        id_producto = prod1.id_producto,
                        titulo = prod1.titulo,
                        precio = prod1.precio,
                        subtotal = prod1.subtotal - prod1.precio,
                        cantidad = prod1.cantidad - 1,
                        stock = prod1.stock
                    };
                    lista_prod_carrito[pProd] = prod;

                }
            }
            return lista_prod_carrito;
        }



        public List<dynamic> sumar_prod(int pProd)
        {
            if (pProd>= 0)
            {
               
                    dynamic prod1 = lista_prod_carrito[pProd];
                    dynamic prod = new
                    {
                        id_producto = prod1.id_producto,
                        titulo = prod1.titulo,
                        precio = prod1.precio,
                        subtotal = prod1.subtotal + prod1.precio,
                        cantidad = prod1.cantidad + 1,
                        stock = prod1.stock
                    };
                    lista_prod_carrito[pProd] = prod;

                
            }
            return lista_prod_carrito;

        }
        public List<dynamic> eliminar_prod(int pProd)
        {
            if (pProd >= 0)
            {
                lista_prod_carrito.Remove(lista_prod_carrito[pProd]);
                
            }return lista_prod_carrito;
        }

        public bool registrar_detalle_venta(int p_id_venta,List<dynamic> p_lista)
        {
            bool ok = false;
            Producto p = new Producto();
            try
            {
                using (var db = new MySqlConnector.MySqlConnection(_connectionString))
                {
                    foreach (dynamic prod in p_lista)
                    {
                        int id_p = prod.id_producto;
                        int cantidad_de_p=prod.cantidad; 

                        decimal subtotal_de_prod=prod.subtotal;
                        
                        var queryAdd = db.Execute(
                             sql: "add_sale_detail",
                                           param: new
                                           {
                                               @p_id_producto= id_p,
                                               @p_cantidad= cantidad_de_p,
                                               @p_id_venta= p_id_venta,
                                               @p_subtotal= subtotal_de_prod


                                           },
                                           commandType: CommandType.StoredProcedure);
                        p.actualizar_stock(id_p, cantidad_de_p);
                        ok = true;
                    }
                }
            }
            catch (Exception e) { MessageBox.Show("Ha ocurrido un error." + e, "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            return ok;
        }
    }
}
