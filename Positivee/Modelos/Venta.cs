
namespace Positive
{
    using Org.BouncyCastle.Asn1.X509;
    using System;
    using System.Collections.Generic;
    
    public partial class Venta
    {
    
        public int id_venta { get; set; }
        public Time hora { get; set; }
        public DateTime fecha { get; set; }
        public Nullable<decimal> monto_total { get; set; }
        public int id_usuario { get; set; }
        public int id_cliente { get; set; }

        public int id_estado { get; set; }
    }
}
