using Dapper;
using FontAwesome.Sharp;
using Positive.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Positive
{
    using System;
    using System.Collections.Generic;

    public partial class Venta_medio_pago
    {
        public int id_venta_medio_pago { get; set; }
        public int id_venta { get; set; }
        public int id_medio_pago { get; set; }
        public decimal monto { get; set; }

        public decimal vuelto=0;

        public decimal restante = 0;

        List<dynamic> lista_vmp = new List<dynamic>();
        string _connectionString = Conexion.get_string();
        public List<dynamic> calcular_montos(decimal p_total, string p_tbMonto, string p_mp, string p_desc_mp)
        {
            decimal total = p_total;//500

            if (p_total > 0)
            {

                decimal cuantoPaga = decimal.Parse(p_tbMonto);//300
                decimal restantePago;
                int id_mp = int.Parse(p_mp);
                string desc = p_desc_mp;
                decimal c_vuelto = 0;


                restantePago = total - cuantoPaga;//200
                if (restantePago >= 0)//200
                {

                    total = restantePago;//200

                    restante = restantePago;
                }
                else//-500
                {
                    cuantoPaga = total;

                    if (p_desc_mp.ToLower() == "efectivo")
                    {
                        c_vuelto = restantePago * -1;
                        vuelto = c_vuelto;
                    }
                    restante=total = 0;
                }
                if (!(lista_vmp.Count(u => u.id_medio_pago == id_mp) > 0))
                {
                    dynamic vmp = new { id_medio_pago = id_mp, descripcion = desc, monto = cuantoPaga};//500
                    lista_vmp.Add(vmp);
                }
                else
                {
                    dynamic vmp = lista_vmp.First(u => u.id_medio_pago == id_mp);//500
                    dynamic vmp_nuevo = new
                    {
                        id_medio_pago = vmp.id_medio_pago,
                        descripcion = desc,
                        monto = vmp.monto + cuantoPaga
                    };//500
                    lista_vmp[lista_vmp.FindIndex(u => u.id_medio_pago == id_mp)] = vmp_nuevo; ;

                }

            }
            else
            {
                MessageBox.Show("Ya se alcanzó el monto a cubrir");

            }
            return lista_vmp;

        }

        public decimal obtener_vuelto()
        {
            return vuelto;
        }
        public decimal obtener_restante()
        {
            return restante;
        }
        public List<dynamic> obtener_lista_de_medios_de_pago()
        {
            return lista_vmp;
        }
        public decimal quitar_forma_pago(int p_index)
        { try
            {
                if (lista_vmp[p_index].descripcion.ToLower() == "efectivo")
                {   decimal monto_descontado_vuelto=vuelto-lista_vmp[p_index].monto;
                    if (monto_descontado_vuelto < 0)
                    {
                        vuelto = 0;
                    }
                    else
                    {
                        vuelto=monto_descontado_vuelto;
                    }

                }
                restante = restante + lista_vmp[p_index].monto;
                lista_vmp.Remove(lista_vmp[p_index]);
                decimal i = restante;
                return restante;
            }
            catch(Exception e){
                return p_index;
            }
        }
        public bool registrar_detalle_venta_medio_pago(int p_id_venta, List<dynamic> p_lista)
        {
            bool ok = false; try
            { using (var db = new MySqlConnector.MySqlConnection(_connectionString))
                {
                    foreach (dynamic prod in p_lista)
                    {
                        int id_mp = prod.id_medio_pago;
                        decimal p_monto = prod.monto;

                        var queryAdd = db.Execute(
                             sql: "add_sale_payment",
                                           param: new
                                           {
                                               @p_monto = p_monto,
                                               @p_id_medio_pago = id_mp,
                                               @p_id_venta = p_id_venta


                                           },
                                           commandType: CommandType.StoredProcedure);


                    }ok = true;
                }
            }
            catch (Exception e) { MessageBox.Show("Ha ocurrido un error." + e, "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            return ok;
        }

    }
}
