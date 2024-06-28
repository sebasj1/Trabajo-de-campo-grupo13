
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
    using Savage.Data;
    using System;
    using System.Collections.Generic;
    
    public partial class Venta
    {
     
        public int id_venta { get; set; }
        public Time hora { get; set; }
        public DateTime fecha { get; set; }
        public decimal monto_total { get; set; }
        public int id_usuario { get; set; }
        public int id_cliente { get; set; }

        public int id_estado { get; set; }

       
        string _connectionString = Conexion.get_string();
        public int registrar_la_venta(int p_id_usuario,int p_id_cliente, decimal p_total)
        {
            int id=-1;
            try
            {
                using (var db = new MySqlConnector.MySqlConnection(_connectionString))
                {
                    int queryAdd = db.ExecuteScalar<int>(
                         sql: "add_sale",
                                       param: new
                                       {
                                           @p_monto_total = p_total,
                                           @p_id_cliente = p_id_cliente,
                                           @p_id_usuario = p_id_usuario

                                       },
                                       commandType: CommandType.StoredProcedure);

                    id = queryAdd;
                }
            }
            catch(Exception e) { MessageBox.Show("Ha ocurrido un error." + e, "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            return id;
        }

        public List<dynamic> listar_ventas()
        {

            try
            {
                using (var db = new MySqlConnector.MySqlConnection(_connectionString))
                {
                    var LISTLOAD = db.Query(
                                  sql: "all_sales",
                                  commandType: CommandType.StoredProcedure);

                    List<dynamic> listado_usuarios = LISTLOAD.ToList();

                    return listado_usuarios;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar datos" + ex);
                return null;
            }

        }
        public void eliminar_venta(string p_id)
        {

            int id = int.Parse(p_id);
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar esta venta?", "Confirmar anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    using (var db = new MySqlConnector.MySqlConnection(_connectionString))
                    {

                        var elem_eliminado = db.Execute(
                                  sql: "delete_sale_id",
                                  param: new { @p_id = id },
                                  commandType: CommandType.StoredProcedure);
                    }
                    MessageBox.Show("Venta anulada ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo eliminar " + ex);
                }
            }
        }
    } 
}
