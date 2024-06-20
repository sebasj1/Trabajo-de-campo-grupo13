using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jbposs.Datos
{
    public class registroMedioPago
    {

        public venta_mediopago Venta_Medio { get; set; }
        public decimal Monto { get; set; }
        public string NombreMedio { get; set; }

        public void cargar(venta_mediopago ventM,string pnombre,  decimal pSubtotal)
        {
            Venta_Medio = ventM;
            Monto = pSubtotal;
            NombreMedio = pnombre;
        }
    }
}
