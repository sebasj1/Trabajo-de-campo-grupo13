
namespace Positive
{
    using System;
    using System.Collections.Generic;
    
    public partial class Venta_medio_pago
    {
        public int id_venta_medio_pago { get; set; }
        public int id_venta { get; set; }
        public int id_medio_pago { get; set; }
        public decimal  monto { get; set; }
    }
}
