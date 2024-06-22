
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
    
    public partial class Tipo_documento
    {
        public int id_tipo_documento { get; set; }
        public string descripcion { get; set; }
    
    public List<Tipo_documento> lista_tipo_doc(){
        List<Tipo_documento> lista_doc=null;
            try
            {
                using (var db = new MySqlConnector.MySqlConnection(Conexion.get_string()))
                {

                    var tipo_doc = db.Query<Tipo_documento>(
                                 sql: "all_type_doc_d",
                                 commandType: CommandType.StoredProcedure);
                   lista_doc=tipo_doc.ToList();
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error."+ex, "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
            } return lista_doc;
}}}
