using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jbposs.Presentacion
{
    public partial class frmBackup : Form
    {
        public frmBackup()
        {
            InitializeComponent();
        }



        private void bBackupFileDialog_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos de copia de seguridad (*.bak)|*.bak|Todos los archivos (*.*)|*.*";
                saveFileDialog.Title = "Seleccionar ubicación de la copia de seguridad";
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Configura la ruta seleccionada en el TextBox
                    tbBackupPath.Text = saveFileDialog.FileName;
                }
            }
        }


        private void bCreateBackup_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new jbposEntities())
                {
                    // Asegúrate de que el contexto esté configurado para no crear una nueva base de datos.
                    context.Database.CreateIfNotExists();

                    // Obtén la cadena de conexión del contexto
                    string connectionString = context.Database.Connection.ConnectionString;

                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        sqlConnection.Open();
                        string databaseName = context.Database.Connection.Database;
                        string backupPath = tbBackupPath.Text;
                        string backupQuery = "BACKUP DATABASE @DatabaseName TO DISK = @BackupPath";

                        using (SqlCommand sqlCommand = new SqlCommand(backupQuery, sqlConnection))
                        {
                            sqlCommand.Parameters.Add(new SqlParameter("@DatabaseName", databaseName));
                            sqlCommand.Parameters.Add(new SqlParameter("@BackupPath", backupPath));

                            sqlCommand.ExecuteNonQuery();
                        }

                        sqlConnection.Close();
                    }

                    MessageBox.Show("El respaldo se ha creado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el respaldo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bRestoreFileDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de respaldo de SQL Server (*.bak)|*.bak|Todos los archivos (*.*)|*.*";
            openFileDialog.Title = "Seleccionar archivo de respaldo";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Mostrar la ruta del archivo seleccionado en el TextBox
                tbRestorePath.Text = openFileDialog.FileName;
            }
        }
        private void setRestoreStatusText(string text)
        {

            labelRestoreStatus.Text = text;
            labelRestoreStatus.Refresh();
        }
        private void bRestoreBackup_Click(object sender, EventArgs e)
        {
            bRestoreBackup.Enabled = false;
           
            string connectionString = ConfigurationManager.ConnectionStrings["jbposEntitiesServer"].ConnectionString;
            string databaseName = "DBJBPOS";
            string restorePath = tbRestorePath.Text; // Ruta del archivo de respaldo

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    setRestoreStatusText("Conectando a la base de datos...");
                    sqlConnection.Open();

                    setRestoreStatusText("Preparando...");
                    // Poner la base de datos en modo de usuario único
                    string singleUserQuery = $"ALTER DATABASE [{databaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                    using (SqlCommand sqlCommand = new SqlCommand(singleUserQuery, sqlConnection))
                    {
                        sqlCommand.ExecuteNonQuery();
                    }
                    setRestoreStatusText("Restaurando datos...");
                    // Realizar la restauración
                    string restoreQuery = $"RESTORE DATABASE [{databaseName}] FROM DISK = @RestorePath WITH FILE = 1, NOUNLOAD, REPLACE, STATS = 5";
                    using (SqlCommand sqlCommand = new SqlCommand(restoreQuery, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@RestorePath", restorePath);
                        sqlCommand.ExecuteNonQuery();
                    }

                    setRestoreStatusText("Finalizando...");
                    // Poner la base de datos de nuevo en modo de usuario múltiple
                    string multiUserQuery = $"ALTER DATABASE [{databaseName}] SET MULTI_USER";
                    using (SqlCommand sqlCommand = new SqlCommand(multiUserQuery, sqlConnection))
                    {
                        sqlCommand.ExecuteNonQuery();
                    }
                    setRestoreStatusText("Restauracion exitosa...");
                    MessageBox.Show("La restauración se ha completado con éxito.");
                }
            }
            catch (Exception ex)
            {
                setRestoreStatusText("Error al restaurar la base de datos: " + ex.Message);
                MessageBox.Show("Error al restaurar la base de datos: " + ex.Message);
            }
            bRestoreBackup.Enabled = true;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmBackup_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

