
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Dapper;
using Positive;
using Positive.Presentacion;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using MySqlX.XDevAPI;
using System.Diagnostics.Contracts;

    namespace Positive{
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

        /*public int id_estado { get; set; }


        Seccion_ventas _principal;
        string _connectionString = Conexion.get_string();
        string action = "";

 public void INSERTCONTROL(string id_venta,decimal monto_total,int id_usuario,int id_cliente,
 int id_estado, Nueva_venta p_nueva_venta) {
            try
            {
                if (crear_usuario(p_nombre_usuario, p_password, p_id_rol, p_id_estado,
                         p_nombre, p_apellido, p_numero_documento,
                             p_id_tipo_documento, p_telefono, p_email, p_nuevo_usuario) && !FINDDNI(p_numero_documento)) {
                    if (p_nuevo_usuario.confirmacion_consulta()) {
                        INSERTELEM();
                        p_nuevo_usuario.confirmacion();
                    } }
                else {
                    p_nuevo_usuario.negacion();
                }
                } 
            catch (Exception ex)
            { MessageBox.Show("Ha ocurrido un error." + ex, "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        } */
   

    } 
}