using Positive.Presentacion;
using Positive;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;
using System.Windows.Controls;

namespace Positivee.Presentacion
{
    public partial class Lista_ventas : Form
    {
        string action = "";
        Seccion_ventas _principal;
        List<dynamic> LISTLOAD = null;
        Venta user_action = new Venta();
        public Lista_ventas(Seccion_ventas p_principal)
        {
            InitializeComponent();
            _principal = p_principal;
        }

        private void Lista_ventas_Load(object sender, EventArgs e)
        {

        }
        public void cargar_lista()
        {
            LISTLOAD = user_action.listar_ventas();
            DATAGRIDCELL.Refresh();
            LOAD();


        }
        public void cargar_accion(string p_action)
        {
            switch (p_action)
            {

                case "delete":
                    action = "delete";
                    LABELPRINCIPAL.Text = "Seleccionar venta para eliminar";
                    break;

                default: LABELPRINCIPAL.Text = "Listado de ventas"; break;
            }

            LOAD();
        }
            private void LOAD()
            {
                DATAGRIDCELL.Rows.Clear();
                DATAGRIDCELL.Columns.Clear();
                DATAGRIDCELL.Columns.Add("ID", "ID");
                DATAGRIDCELL.Columns.Add("Monto", "Monto");
                DATAGRIDCELL.Columns.Add("Fecha", "Fecha");
                DATAGRIDCELL.Columns.Add("Hora", "Hora");
                DATAGRIDCELL.Columns.Add("Nombre usuario.", "Nombre usuario");
                DATAGRIDCELL.Columns.Add("Cliente", "Cliente");
                DATAGRIDCELL.Columns.Add("Estado", "Estado");

                foreach (var ELEMLIST in LISTLOAD)
                {
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(DATAGRIDCELL, ELEMLIST.id_venta, ELEMLIST.monto_total, ELEMLIST.fecha,
                        ELEMLIST.hora, ELEMLIST.nombre_usuario, ELEMLIST.nombre+" "+ ELEMLIST.apellido,
                        ELEMLIST.estado);
                    // Cambiar el color de fondo si está eliminado

                    if (ELEMLIST.estado == "INACTIVO" || ELEMLIST.estado == "inactivo")
                    {
                        fila.DefaultCellStyle.BackColor = Color.Red;
                        fila.DefaultCellStyle.ForeColor = Color.White; // Puedes ajustar el color del texto según sea necesario
                    }
                    DATAGRIDCELL.Rows.Add(fila);
                }
                DATAGRIDCELL.Refresh();


            }

        private void DATAGRIDCELL_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (action)
            {
                
                case "delete":
                    string id_del = DATAGRIDCELL.CurrentRow.Cells["ID"].Value.ToString();
                    user_action.eliminar_venta(id_del);
                    cargar_lista();
                    break;
               

            }
        }

        private void DATAGRIDCELL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
