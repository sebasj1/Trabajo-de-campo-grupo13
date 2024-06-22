using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace Positive
{
    using System;
    using System.Collections.Generic;

    public partial class Rol
    {

        public int id_rol { get; set; }
        public string descripcion { get; set; }
        public string id_estado { get; set; }



        public List<Rol> lista_roles()
        {
            List<Rol> lista_roles = null;
            try
            {
                using (var db = new MySqlConnector.MySqlConnection(Conexion.get_string()))
            {
                var rolesQuery = db.Query<Rol>(
                              sql: "all_rols_d",
                              commandType: CommandType.StoredProcedure);

                lista_roles = rolesQuery.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar " + ex);
            }
            return lista_roles;
        }
    }
        
}
    
