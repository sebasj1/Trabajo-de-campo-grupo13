using Dapper;
using Mysqlx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Positive.Presentacion
{
    public partial class Nueva_categoria : Form
    {

        public Nueva_categoria()
        {
            InitializeComponent();
            actual = btNewRol;
        }

        private string ACTION = "new";
        private Categoria AUX;
        private Button actual;
        string _connectionString = "Server=mysql-proyectois2.alwaysdata.net;Database=proyectois2_puntoventa;User Id=362639;Password=Pollito1q;";

        private void addCategorie_Load(object sender, EventArgs e)
        {

            colorCam(btNewRol);
            LOAD();

        }


        private void colorCam(Button pB)
        {
            actual.BackColor = System.Drawing.SystemColors.Highlight;
            actual = pB;
            actual.BackColor = System.Drawing.Color.Green;
        }


        private void LOAD() {

            DATAGRIDCELL.Rows.Clear();
            DATAGRIDCELL.Columns.Clear();
            DATAGRIDCELL.Columns.Add("ID", "ID");
            DATAGRIDCELL.Columns.Add("Categoria", "Categoria");
            DATAGRIDCELL.Columns.Add("Estado", "Estado");
            try
            {
                using (var db = new MySqlConnector.MySqlConnection(_connectionString))
                {
                    var LISTLOAD = db.Query(
                                  sql: "all_categories",
                                  commandType: CommandType.StoredProcedure); 
                

                    foreach (var ELEMLIST in LISTLOAD)
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(DATAGRIDCELL, ELEMLIST.id_categoria, ELEMLIST.descripcion, ELEMLIST.estado);
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
            
            lbAction.Text = "Listado de Categorias";
            btAddRol.Text = "Agregar";
            tbAddRol.Text = "";
            AUX = null;
        }
        private bool EXIST()
        {
            bool exist = false;
            using (var db = new MySqlConnector.MySqlConnection(_connectionString))
            {
                var LISTEXIST = db.Query<Categoria>(
                           sql: "search_category",
                           param: new { p_category = tbAddRol.Text },
                           commandType: CommandType.StoredProcedure
                );
                if (LISTEXIST.Count()>0)
                {
                    exist = true;
                }
            }
            return exist;
        }

        

        private void INSERTCONTROL()
        {
            //SQL que ejecutara Dapper, aquí puedes jugar con los orders que quieras.         

            if (EXIST())
            {
                MessageBox.Show("Ya existe una categoria con ese nombre");
            }
            else if (tbAddRol.Text == "")
            {
                MessageBox.Show("No se puede guardar vacio");
            }
            else
            {
                DialogResult resp = MessageBox.Show("Se guardara la categoria", "Éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resp == DialogResult.Yes)
                {
                    try
                    {
                        INSERTELEM();
                        MessageBox.Show("Esta categoria se ha guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Ha ocurrido un error.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void INSERTELEM()
        {
            using (var db = new MySqlConnector.MySqlConnection(_connectionString))
            {
                var queryAdd = db.Execute(
                              sql: "add_category",
                              param: new { p_category = tbAddRol.Text.Trim() },
                              commandType: CommandType.StoredProcedure);
             }
        }


        private void btAddRol_Click(object sender, EventArgs e)
        {
            if (ACTION == "edit")
            {
                EDITCONTROL(tbAddRol.Text);
                LOAD();
            }
            else if (ACTION == "new")
            {
                INSERTCONTROL();
                LOAD();
            }

        }
  


        private void delRol_Click(object sender, EventArgs e)
        {
            colorCam(btDelRol);
            ACTION = "delete";
            lbAction.Text = "Seleccione una categoria para eliminar";
            btAddRol.Visible = false;
            tbAddRol.Enabled = false;
        }
        private void edRol_Click(object sender, EventArgs e)
        {
            colorCam(btEdRol);
            tbAddRol.Enabled = false;
            lbAction.Text = "Seleccione una categoria para editar";
            ACTION = "edit";
            btAddRol.Visible = false;
            tbAddRol.Enabled = false;


        }

        private void EDITCONTROL(string pRol)
        {
            {
              
                if (pRol == "")
                {
                    MessageBox.Show("No se puede guardar vacio");
                }
                else
                {
                    DialogResult resp = MessageBox.Show("Se actualizará la categoria", "Éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resp == DialogResult.Yes)
                    {
                        try
                        {
                            SAVEEDIT(pRol);
                            MessageBox.Show("Esta categoria se ha guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Ha ocurrido un error.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }

            
        }
        private Categoria FIND(string pRol)
            {
            Categoria categ;
            using (var db = new MySqlConnector.MySqlConnection(_connectionString))
            {
                categ = db.QueryFirst<Categoria>(
                          sql: "search_category",
                          param: new { p_category = pRol },
                          commandType: CommandType.StoredProcedure);
            }
            return categ;
        }

        private void SAVEEDIT(string pRol)
        {
            using (var db = new MySqlConnector.MySqlConnection(_connectionString))
            {
                var queryAdd = db.Execute(
                          sql: "edit_category",
                          param: new {p_id=AUX.id_categoria, p_category = pRol.Trim(), p_status=AUX.id_estado },
                          commandType: CommandType.StoredProcedure);
            }
        }

        private void DELELEM()
        {
            using (var db = new MySqlConnector.MySqlConnection(_connectionString))
            {
                var queryAdd = db.Execute(
                          sql: "delete_category",
                          param: new { p_id = AUX.id_categoria },
                          commandType: CommandType.StoredProcedure);
            }
        }
        private void DELCONTROL()
        {
            if (AUX.id_estado == 2)
            {
                MessageBox.Show("Esta categoria ya ha sido eliminado anteriormente.", "Ya eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar esta categoria?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        DELELEM();
                        MessageBox.Show("Categoria eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LOAD();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar categoria: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void RESTOREELEM()
        {
            using (var db = new MySqlConnector.MySqlConnection(_connectionString))
            {
                var queryAdd = db.Execute(
                          sql: "restore_category",
                          param: new { p_id = AUX.id_categoria },
                          commandType: CommandType.StoredProcedure);
            }
        }
        private void RESTORECONTROL()
        {
            if (AUX.id_estado == 1)
            {
                MessageBox.Show("Esta categoria no ha sido eliminado anteriormente.", "No eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea restaurar esta categoria?", "Confirmar Restauración", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        RESTOREELEM();
                        MessageBox.Show("Categoria restaurada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LOAD();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al restaurar categoria: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            colorCam(btRestoreRol);
            lbAction.Text = "Seleccione una categoria para restaurar";
            ACTION = "restore";
            btAddRol.Visible = false;
            tbAddRol.Enabled = false;

        }

        private void btNewRol_Click(object sender, EventArgs e)
        {
            Medio_pago mp = new Medio_pago();
            colorCam(btNewRol); 
            lbAction.Text = "Nuevo Rol";
            ACTION = "new";
            btAddRol.Visible = true;
            tbAddRol.Enabled = true;
        }

       

        private void dataGridRol_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string rol = DATAGRIDCELL.CurrentRow.Cells["Categoria"].Value.ToString();

            DATAGRIDCELL.CurrentRow.Selected = true;
            if (ACTION == "edit")
            {
                
                tbAddRol.Text =rol ;
                AUX=FIND(rol);
                btAddRol.Text = "Guardar";
                btAddRol.Visible = true;
                tbAddRol.Enabled = true;
               
            }
            else if (ACTION == "delete")
            {
                AUX = FIND(rol);
                DELCONTROL();
            }
            else if (ACTION == "restore")
            {
                AUX = FIND(rol);
                RESTORECONTROL();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
