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
    
    public partial class Medio_pago
    {
    
        public int id_medio_pago { get; set; }
        public string descripcion { get; set; }

        public List<Medio_pago> lista_medio_pagos()
        {
            List<Medio_pago> lista_medios=null;
            try
            {
                using (var db = new MySqlConnector.MySqlConnection(Conexion.get_string()))
                {

                    var estado = db.Query<Medio_pago>(
                                sql: "all_payment_method",
                                commandType: CommandType.StoredProcedure);
                    lista_medios = estado.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar " + ex);
            }
            return lista_medios;
        }

    }
}
