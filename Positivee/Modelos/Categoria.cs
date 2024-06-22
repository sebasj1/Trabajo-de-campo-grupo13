

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Dapper;
using Positivee;
using Positive.Presentacion;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using MySqlX.XDevAPI;
using System.Diagnostics.Contracts;
namespace Positive
{
    using System;
    using System.Collections.Generic;
    
    public partial class Categoria
    {
    
        public int id_categoria { get; set; }
        public string descripcion { get; set; }
        public int id_estado { get; set; }

        public List<Categoria> lista_categorias()
        {
            List<Categoria> lista_estados = null;
            try
            {
                using (var db = new MySqlConnector.MySqlConnection(Conexion.get_string()))
                {

                    var estado = db.Query<Categoria>(
                                sql: "all_categories_d",
                                commandType: CommandType.StoredProcedure);
                    lista_estados = estado.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar " + ex);
            }
            return lista_estados;
        }
    }


}
