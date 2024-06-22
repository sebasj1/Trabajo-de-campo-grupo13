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

        private void cargar_carrito(string id_prod)
        {
            int id = int.Parse(id_prod);
            dynamic prod = lista_prod.First(u => u.id_producto == id);
            int i = 0;

            if (!(carrito.Count(u => u.id_producto == prod.id_producto) > 0))
            {
                id_producto = prod.id_producto;
                cantidad = 1;
                subtotal = prod.precio_venta;

                carrito.Add(prodCarrito);
                lista_prod_carrito.Add(prod);
            }
            else
            {
                carrito.First(u => u.id_producto == id).cantidad += 1;
                carrito.First(u => u.id_producto == id).subtotal += prod.precio_venta;
                Detalle_venta indice = carrito.First(u => u.id_producto == id);
                //sumProd(carrito.IndexOf(indice));
            }


        }*/
    }
}
