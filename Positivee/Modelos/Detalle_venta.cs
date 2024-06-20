
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
    }
}
