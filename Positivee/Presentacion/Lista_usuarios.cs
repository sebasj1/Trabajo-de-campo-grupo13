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

namespace Positive.Presentacion
{
    public partial  class Lista_usuarios : Form
    {
        string _connectionString = "Server=mysql-proyectois2.alwaysdata.net;Database=proyectois2_puntoventa;User Id=362639;Password=Pollito1q;";
        string action = "";
        Seccion_usuarios _principal;
        public Lista_usuarios(Seccion_usuarios p_principal)
        {
            InitializeComponent();
            _principal = p_principal;
            LOAD();
        }

        private void lista_Load(object sender, EventArgs e)
        {

        }

        public void cargar_lista(string p_action)
        {
            switch (p_action)
            {
                case "edit":
                action = "edit";
                LABELPRINCIPAL.Text = "Seleccionar usuario para editar";
                 break;
                case "delete":
                    action = "delete";
                    LABELPRINCIPAL.Text = "Seleccionar usuario para eliminar";
                 break;
                case "restore":
                    action = "restore";
                    LABELPRINCIPAL.Text = "Seleccionar usuario para restaurar";
                    break;
                default:LABELPRINCIPAL.Text = "Listado de usuarios";break;
            }
            LOAD();
            
                 
        }
        private void LOAD()
        {

            DATAGRIDCELL.Rows.Clear();
            DATAGRIDCELL.Columns.Clear();
            DATAGRIDCELL.Columns.Add("ID", "ID");
            DATAGRIDCELL.Columns.Add("Nombre", "Nombre");
            DATAGRIDCELL.Columns.Add("Apellido", "Apellido");
            DATAGRIDCELL.Columns.Add("Nombre Usuario", "Nombre Usuario");
            DATAGRIDCELL.Columns.Add("Tipo doc.", "Tipo doc.");
            DATAGRIDCELL.Columns.Add("Nro. Documento", "Nro. Document");
            DATAGRIDCELL.Columns.Add("Cargo", "Cargo");
            DATAGRIDCELL.Columns.Add("Teléfono", "Teléfono");
            DATAGRIDCELL.Columns.Add("Email", "Email");
            DATAGRIDCELL.Columns.Add("Estado", "Estado");
            try
            {
                using (var db = new MySqlConnector.MySqlConnection(_connectionString))
                {
                    var LISTLOAD = db.Query(
                                  sql: "all_users",
                                  commandType: CommandType.StoredProcedure);

                    foreach (var ELEMLIST in LISTLOAD)
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(DATAGRIDCELL, ELEMLIST.id_usuario,ELEMLIST.nombre, ELEMLIST.apellido, ELEMLIST.nombre_usuario, ELEMLIST.tipo_doc, ELEMLIST.numero_documento, ELEMLIST.descripcion, ELEMLIST.telefono, ELEMLIST.email, ELEMLIST.estado);
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
                switch (action )
                {
                 case  "edit":
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
    }
}
