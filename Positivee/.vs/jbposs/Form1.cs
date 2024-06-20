using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jbposs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (jbposEntities db = new jbposEntities())
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("DNI", "DNI");
                dataGridView1.Columns.Add("Nombre", "Nombre");
                dataGridView1.Columns.Add("Apellido", "Apellido");
                dataGridView1.Columns.Add("Email", "Email");
                dataGridView1.Columns.Add("Domicilio", "Domicilio");
                dataGridView1.Columns.Add("Username", "Nombre de Usuario");
                dataGridView1.Columns.Add("Provincia", "Provincia");
                dataGridView1.Columns.Add("Rol", "Rol");


                var usuariosQuery = from u in db.usuario
                                    select new
                                    {
                                        u.id_usuario,
                                        u.nombre,
                                        u.apellido,
                                        u.email,
                                        u.nombre_usuario,
                                        u.fecha_eliminado,
                                        u.domicilio,
                                        u.provincia,
                                        u.rol,
                                        u.telefono,
                                        u.dni,
                                    };

                try
                {
                    foreach (var usuario in usuariosQuery)
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(dataGridView1, usuario.dni, usuario.nombre, usuario.apellido, usuario.email, usuario.domicilio, usuario.nombre_usuario, usuario.provincia?.nombre, usuario.rol?.descripcion);
                        // Cambiar el color de fondo si está eliminado
                        if (usuario.fecha_eliminado != null)
                        {
                            fila.DefaultCellStyle.BackColor = Color.Red;
                            fila.DefaultCellStyle.ForeColor = Color.White; // Puedes ajustar el color del texto según sea necesario
                        }
                        dataGridView1.Rows.Add(fila);
                    }
                    dataGridView1.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo cargar datos" + ex);
                }
            }
        }
    }
}
