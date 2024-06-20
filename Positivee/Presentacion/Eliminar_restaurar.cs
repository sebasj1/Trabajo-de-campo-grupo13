using Dapper;
using Positive;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Positive.Presentacion
{
    internal class Eliminar_restaurar
    {
        string _connectionString = "Server=mysql-proyectois2.alwaysdata.net;Database=proyectois2_puntoventa;User Id=362639;Password=Pollito1q;";

        public string eliminar_usuario(string p_id)
        {
            string mensaje = "";
            int id = int.Parse(p_id);

            try{
                using (var db = new MySqlConnector.MySqlConnection(_connectionString))
                {

                    var elem_eliminado = db.Execute(
                              sql: "delete_user_id",
                              param: new { @p_id = id },
                              commandType: CommandType.StoredProcedure);
                }
                mensaje = "Eliminado correctamente";
            }
            catch(Exception ex)
            {
                mensaje = "No se pudo eliminar "+ex;
            }
            return mensaje;
        }
        public string restaurar_usuario(string p_id)
        {
            string mensaje = "";
            int id = int.Parse(p_id);

            try
            {
                using (var db = new MySqlConnector.MySqlConnection(_connectionString))
                {

                    var elem_eliminado = db.Execute(
                              sql: "restore_user_id",
                              param: new { @p_id = id },
                              commandType: CommandType.StoredProcedure);
                }
                mensaje = "Restaurado correctamente";
            }
            catch (Exception ex)
            {
                mensaje = "No se pudo restaurar " + ex;
            }
            return mensaje;
        }
        //productos
        public string eliminar_producto(string p_id)
        {
            string mensaje = "";
            int id = int.Parse(p_id);

            try
            {
                using (var db = new MySqlConnector.MySqlConnection(_connectionString))
                {

                    var elem_eliminado = db.Execute(
                              sql: "delete_producto_id",
                              param: new { @p_id = id },
                              commandType: CommandType.StoredProcedure);
                }
                mensaje = "Eliminado correctamente";
            }
            catch (Exception ex)
            {
                mensaje = "No se pudo eliminar " + ex;
            }
            return mensaje;
        }
        public string restaurar_producto(string p_id)
        {
            string mensaje = "";
            int id = int.Parse(p_id);

            try
            {
                using (var db = new MySqlConnector.MySqlConnection(_connectionString))
                {

                    var elem_eliminado = db.Execute(
                              sql: "restore_producto_id",
                              param: new { @p_id_producto = id },
                              commandType: CommandType.StoredProcedure);
                }
                mensaje = "Restaurado correctamente";
            }
            catch (Exception ex)
            {
                mensaje = "No se pudo restaurar " + ex;
            }
            return mensaje;
        }

        public void registrar_venta(List<Venta_medio_pago> lista_venta_medio_pago)
        {

        }





    }
}
