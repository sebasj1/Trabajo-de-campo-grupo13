using Dapper;
using Positive.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Positive.Presentacion
{
    public partial class Lista_productos : Form
    { string _connectionString = "Server=mysql-proyectois2.alwaysdata.net;Database=proyectois2_puntoventa;User Id=362639;Password=Pollito1q;";
        string action = "";
        Seccion_productos _principal;
       
        public Lista_productos(Seccion_productos p_principal)
        {
            InitializeComponent();
            _principal = p_principal;
            LOADPRODUCTS();
        }
       

        private void Lista_productos_Load(object sender, EventArgs e)
        {

        }

        public void cargar_lista(string p_action)
        {
            switch (p_action)
            {
                case "edit":
                    action = "edit";
                    LABELPRINCIPAL.Text = "Seleccionar producto para editar";
                    break;
                case "delete":
                    action = "delete";
                    LABELPRINCIPAL.Text = "Seleccionar producto para eliminar";
                    break;
                case "restore":
                    action = "restore";
                    LABELPRINCIPAL.Text = "Seleccionar producto para restaurar";
                    break;
                default: LABELPRINCIPAL.Text = "Listado de productos"; break;
            }
            LOADPRODUCTS();


        }
        private void LOADPRODUCTS()
        {

            DATAGRIDCELL.Rows.Clear();
            DATAGRIDCELL.Columns.Clear();
            DATAGRIDCELL.Columns.Add("ID", "ID");
            DATAGRIDCELL.Columns.Add("Titulo", "Titulo");
            DATAGRIDCELL.Columns.Add("Descripción", "Descripción");
            DATAGRIDCELL.Columns.Add("Codigo", "Codigo");
            DATAGRIDCELL.Columns.Add("Precio compra", "Precio compra");
            DATAGRIDCELL.Columns.Add("Precio venta.", "Precio venta.");
            DATAGRIDCELL.Columns.Add("Categoría", "Categoría");
            DATAGRIDCELL.Columns.Add("Estado", "Estado");
            try
            {
                using (var db = new MySqlConnector.MySqlConnection(_connectionString))
                {
                    var LISTLOAD = db.Query(
                                  sql: "all_products",
                                  commandType: CommandType.StoredProcedure);

                    foreach (var ELEMLIST in LISTLOAD)
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(DATAGRIDCELL, ELEMLIST.id_producto, ELEMLIST.titulo, ELEMLIST.descripcion, ELEMLIST.codigo, ELEMLIST.precio_compra, ELEMLIST.precio_venta, ELEMLIST.categoria, ELEMLIST.estado);
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
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar datos" + ex);
            }

        }

        private void DATAGRIDCELL_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (action)
            {
                case "edit":
                    string id = DATAGRIDCELL.CurrentRow.Cells["ID"].Value.ToString();
                    _principal.seleccion_editar(id);
                    break;
                case "delete":
                    string id_del = DATAGRIDCELL.CurrentRow.Cells["ID"].Value.ToString();
                    _principal.seleccion_eliminar(id_del);
                    break;
                case "restore":
                    string id_res = DATAGRIDCELL.CurrentRow.Cells["ID"].Value.ToString();
                    _principal.seleccion_restaurar(id_res);
                    break;

            }
        }

        private void Lista_productos_Load_1(object sender, EventArgs e)
        {

        }
    }
}
