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
    
    public partial class Estado
    {
    
        public int id_estado { get; set; }
        public string descripcion { get; set; }
   

    public List<Estado> buscar_estado(){
        List<Estado> lista_estados=null;
         try
            {
                using (var db = new MySqlConnector.MySqlConnection(Conexion.get_string()))
                {

                    var estado = db.Query<Estado>(
                                sql: "all_status_d",
                                commandType: CommandType.StoredProcedure);
                    lista_estados = estado.ToList();
                }   
         }
          catch (Exception ex) { 
                MessageBox.Show("No se pudo cargar "+ ex);
            }
        return lista_estados;
    } }
}
