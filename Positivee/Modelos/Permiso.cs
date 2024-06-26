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
    
    public partial class Permiso
    {
        public int id_permiso { get; set; }
        public Nullable<int> id_rol { get; set; }
        public string descripcion { get; set; }
        public string nombreMenu { get; set; }
    

    public  IEnumerable<string> obtener_permisos(Usuario usuarioLogueado)
    {
        IEnumerable<string> Permissions;
        using (var db = new MySqlConnector.MySqlConnection(Conexion.get_string()))
        {

            Permissions = db.Query<string>(
                      sql: "user_permissions",
                      param: new { p_rol = usuarioLogueado.id_rol },
                      commandType: CommandType.StoredProcedure);
        }
        return Permissions;
    }}
}
