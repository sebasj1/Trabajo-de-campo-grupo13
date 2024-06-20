using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace jbposs.Datos
{
    internal class elementoVenta
    {
          
          
            public producto Producto { get; set; }
            public decimal Subtotal { get; set; }
            public int Cantidad { get; set; }

        public void cargar(producto  pProd,int pCant,decimal pSubtotal)
        {
            Producto = pProd;
            Cantidad = pCant;
            Subtotal = pSubtotal;
        }


        // Remaining implementation of Person class.
    }


}

