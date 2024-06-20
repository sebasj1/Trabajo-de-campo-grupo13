

namespace Positive
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producto_venta
    {
    
        public int id_producto { get; set; }
        public string titulo { get; set; }
        public string codigo { get; set; }
        public decimal precio_venta { get; set; }
        public string categoria { get; set; }
        public Nullable<int> stock { get; set; }
    }
}
