

namespace Positive
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producto
    {
    
        public int id_producto { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public string codigo { get; set; }
        public decimal precio_compra { get; set; }
        public decimal precio_venta { get; set; }
        public int id_categoria { get; set; }
        public int id_estado { get; set; }
        public Nullable<int> stock { get; set; }
    }
}
