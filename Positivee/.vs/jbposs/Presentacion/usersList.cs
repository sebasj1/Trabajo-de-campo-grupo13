using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using jbposs.Presentacion;


namespace jbposs.Presentacion
{   
    
    public partial class usersList : Form
    {
        //private jbposEntities context;
        private List<Control> originalControls;
        private filterUserList frmFilter;
        public string action = "";
        private frmUsers userPrincipal;

        public usersList(frmUsers pf)
        { 
            InitializeComponent();
            userPrincipal = pf;
            frmFilter = new filterUserList(this);lblUsList.Text = "Lista de usuarios";
        }

        private void usersList_Load(object sender, EventArgs e)
        {
            loadUsers();
            using (jbposEntities db = new jbposEntities())
            {
                //Cargar roles
                cbRol.Items.Clear();
                cbRol.Items.Add("Todos");
                foreach (rol r in db.rol)
                {
                    cbRol.Items.Add(r.descripcion);
                }

            }
        }

        public void loadUsers()
        {
            
            using ( jbposEntities db = new jbposEntities())
            {
                dataGridUserList.Rows.Clear();
                dataGridUserList.Columns.Clear();

                dataGridUserList.Columns.Add("DNI", "DNI");
                dataGridUserList.Columns.Add("Nombre", "Nombre");
                dataGridUserList.Columns.Add("Apellido", "Apellido");
                dataGridUserList.Columns.Add("Email", "Email");
                dataGridUserList.Columns.Add("Domicilio", "Domicilio");
                dataGridUserList.Columns.Add("Username", "Nombre de Usuario");
                dataGridUserList.Columns.Add("Provincia", "Provincia");
                dataGridUserList.Columns.Add("Rol", "Rol"); 


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
                        fila.CreateCells(dataGridUserList, usuario.dni, usuario.nombre, usuario.apellido, usuario.email, usuario.domicilio, usuario.nombre_usuario, usuario.provincia?.nombre, usuario.rol?.descripcion);
                        // Cambiar el color de fondo si está eliminado
                        if (usuario.fecha_eliminado != null)
                        {
                            fila.DefaultCellStyle.BackColor = Color.Red;
                            fila.DefaultCellStyle.ForeColor = Color.White; // Puedes ajustar el color del texto según sea necesario
                        }
                        dataGridUserList.Rows.Add(fila);
                    }
                    dataGridUserList.Refresh();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("No se pudo cargar datos" + ex);
                }
        }

            }

        private void usersList_Paint(object sender, PaintEventArgs e)
        {
            loadUsers();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (cbRol.Text == "Todos")
            {
                loadUsers();
            }
            else
            {
                using (jbposEntities db = new jbposEntities())
                {
                    //List<usuario> listaUsuarios = context.usuario.ToList();
                    dataGridUserList.Rows.Clear();
                    dataGridUserList.Columns.Clear();

                    dataGridUserList.Columns.Add("DNI", "DNI");
                    dataGridUserList.Columns.Add("Nombre", "Nombre");
                    dataGridUserList.Columns.Add("Apellido", "Apellido");
                    dataGridUserList.Columns.Add("Email", "Email");
                    dataGridUserList.Columns.Add("Domicilio", "Domicilio");
                    dataGridUserList.Columns.Add("Username", "Nombre de Usuario");
                    dataGridUserList.Columns.Add("Provincia", "Provincia");
                    dataGridUserList.Columns.Add("Rol", "Rol");


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
                                            u.dni
                                        };

                    foreach (var usuario in usuariosQuery)
                    {
                        if (usuario.rol?.descripcion == cbRol.Text)
                        {
                            DataGridViewRow fila = new DataGridViewRow();
                            fila.CreateCells(dataGridUserList, usuario.dni, usuario.nombre, usuario.apellido, usuario.email, usuario.domicilio, usuario.nombre_usuario, usuario.provincia?.nombre, usuario.rol?.descripcion);
                            // Cambiar el color de fondo si está eliminado
                            if (usuario.fecha_eliminado != null)
                            {
                                fila.DefaultCellStyle.BackColor = Color.Red;
                                fila.DefaultCellStyle.ForeColor = Color.White; // Puedes ajustar el color del texto según sea necesario
                            }
                            dataGridUserList.Rows.Add(fila);
                        }
                    }
                    dataGridUserList.Refresh();
                }
            
                
            }
        }
       
        private void btnFilter_Click(object sender, EventArgs e)
        {
            frmFilter.ShowDialog(); 
        }

        public void filter(string pRb, string pEl)
        {
            
            dataGridUserList.Rows.Clear();
            dataGridUserList.Columns.Clear();
            dataGridUserList.Columns.Add("DNI", "DNI");
            dataGridUserList.Columns.Add("Nombre", "Nombre");
            dataGridUserList.Columns.Add("Apellido", "Apellido");
            dataGridUserList.Columns.Add("Email", "Email");
            dataGridUserList.Columns.Add("Domicilio", "Domicilio");
            dataGridUserList.Columns.Add("Username", "Nombre de Usuario");
            dataGridUserList.Columns.Add("Provincia", "Provincia");
            dataGridUserList.Columns.Add("Rol", "Rol");

            using (jbposEntities db = new jbposEntities())
            {
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
                                        u.dni
                                    };

                foreach (var usuario in usuariosQuery)
                {
                    if (pRb == "DNI" && usuario.dni.Contains(pEl.Trim()))
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(dataGridUserList, usuario.dni, usuario.nombre, usuario.apellido, usuario.email, usuario.domicilio, usuario.nombre_usuario, usuario.provincia?.nombre, usuario.rol?.descripcion);
                        // Cambiar el color de fondo si está eliminado
                        if (usuario.fecha_eliminado != null)
                        {
                            fila.DefaultCellStyle.BackColor = Color.Red;
                            fila.DefaultCellStyle.ForeColor = Color.White; // Puedes ajustar el color del texto según sea necesario
                        }
                        dataGridUserList.Rows.Add(fila);
                    }
                    else if (pRb == "Usuario" && usuario.nombre_usuario.ToLower().Contains(pEl.ToLower().Trim()))
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(dataGridUserList, usuario.dni, usuario.nombre, usuario.apellido, usuario.email, usuario.domicilio, usuario.nombre_usuario, usuario.provincia?.nombre, usuario.rol?.descripcion);
                        // Cambiar el color de fondo si está eliminado
                        if (usuario.fecha_eliminado != null)
                        {
                            fila.DefaultCellStyle.BackColor = Color.Red;
                            fila.DefaultCellStyle.ForeColor = Color.White; // Puedes ajustar el color del texto según sea necesario
                        }
                        dataGridUserList.Rows.Add(fila);
                    }
                    else if (pRb == "Apellido" && usuario.apellido.ToLower().Contains(pEl.ToLower().Trim()))
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(dataGridUserList, usuario.dni, usuario.nombre, usuario.apellido, usuario.email, usuario.domicilio, usuario.nombre_usuario, usuario.provincia?.nombre, usuario.rol?.descripcion);
                        // Cambiar el color de fondo si está eliminado
                        if (usuario.fecha_eliminado != null)
                        {
                            fila.DefaultCellStyle.BackColor = Color.Red;
                            fila.DefaultCellStyle.ForeColor = Color.White; // Puedes ajustar el color del texto según sea necesario
                        }
                        dataGridUserList.Rows.Add(fila);
                    }
                    else if (pRb == "Nombre" && usuario.nombre.ToLower().Contains(pEl.ToLower().Trim()))
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(dataGridUserList, usuario.dni, usuario.nombre, usuario.apellido, usuario.email, usuario.domicilio, usuario.nombre_usuario, usuario.provincia?.nombre, usuario.rol?.descripcion);
                        // Cambiar el color de fondo si está eliminado
                        if (usuario.fecha_eliminado != null)
                        {
                            fila.DefaultCellStyle.BackColor = Color.Red;
                            fila.DefaultCellStyle.ForeColor = Color.White; // Puedes ajustar el color del texto según sea necesario
                        }
                        dataGridUserList.Rows.Add(fila);
                    }
                    else if(pEl=="")
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(dataGridUserList, usuario.dni, usuario.nombre, usuario.apellido, usuario.email, usuario.domicilio, usuario.nombre_usuario, usuario.provincia?.nombre, usuario.rol?.descripcion);
                        // Cambiar el color de fondo si está eliminado
                        if (usuario.fecha_eliminado != null)
                        {
                            fila.DefaultCellStyle.BackColor = Color.Red;
                            fila.DefaultCellStyle.ForeColor = Color.White; // Puedes ajustar el color del texto según sea necesario
                        }
                        dataGridUserList.Rows.Add(fila);
                    }

                }
                dataGridUserList.Refresh();
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            loadUsers();
        }

      
        private void dataGridUserList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            dataGridUserList.CurrentRow.Selected=true;
            if (action == "edit")
            {   
              userPrincipal.userEd(dataGridUserList.CurrentRow.Cells["DNI"].Value.ToString());
               
            }
            else if (action == "delete")
            {
                userPrincipal.deleteUser(dataGridUserList.CurrentRow.Cells["DNI"].Value.ToString());
            }
            else if (action == "restore")
            {
                userPrincipal.restoreUser(dataGridUserList.CurrentRow.Cells["DNI"].Value.ToString());
            }
        }

        private void dataGridUserList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}

