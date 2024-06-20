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
{}/*
    public partial class customersList : Form
    {
        private filterCustList frmFilter;
        public string action = "";
        private frmCustomers customerPrincipal;
        public customersList(frmCustomers pf)
        {
            InitializeComponent();
            customerPrincipal = pf;
            frmFilter = new filterCustList(this);
        }

        private void customersList_Load(object sender, EventArgs e)
        {
            loadUsers();
           
        }

        public void loadUsers()
        {

            using (jbposEntities db = new jbposEntities())
            {
                dataGridUserList.Rows.Clear();
                dataGridUserList.Columns.Clear();

                dataGridUserList.Columns.Add("DNI", "DNI");
                dataGridUserList.Columns.Add("Nombre", "Nombre");
                dataGridUserList.Columns.Add("Apellido", "Apellido");
                dataGridUserList.Columns.Add("Email", "Email");
                dataGridUserList.Columns.Add("Domicilio", "Domicilio");
                dataGridUserList.Columns.Add("Provincia", "Provincia");


               
                try
                {
                    foreach (var usuario in db.cliente)
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(dataGridUserList, usuario.dni, usuario.nombre, usuario.apellido, usuario.email, usuario.domicilio,  usuario.provincia?.nombre);
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
                catch (Exception ex)
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
            dataGridUserList.Columns.Add("Provincia", "Provincia");

            using (jbposEntities db = new jbposEntities())
            {
                
                foreach (var usuario in db.cliente)
                {
                    if (pRb == "DNI" && usuario.dni.Contains(pEl.Trim()))
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(dataGridUserList, usuario.dni, usuario.nombre, usuario.apellido, usuario.email, usuario.domicilio,  usuario.provincia?.nombre);
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
                        fila.CreateCells(dataGridUserList, usuario.dni, usuario.nombre, usuario.apellido, usuario.email, usuario.domicilio,usuario.provincia?.nombre);
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
                        fila.CreateCells(dataGridUserList, usuario.dni, usuario.nombre, usuario.apellido, usuario.email, usuario.domicilio, usuario.provincia?.nombre);
                        // Cambiar el color de fondo si está eliminado
                        if (usuario.fecha_eliminado != null)
                        {
                            fila.DefaultCellStyle.BackColor = Color.Red;
                            fila.DefaultCellStyle.ForeColor = Color.White; // Puedes ajustar el color del texto según sea necesario
                        }
                        dataGridUserList.Rows.Add(fila);
                    }
                    else if (pEl == "")
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(dataGridUserList, usuario.dni, usuario.nombre, usuario.apellido, usuario.email, usuario.domicilio, usuario.provincia?.nombre);
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
            dataGridUserList.CurrentRow.Selected = true;
            if (action == "edit")
            {
                customerPrincipal.userEd(dataGridUserList.CurrentRow.Cells["DNI"].Value.ToString());

            }
            else if (action == "delete")
            {
                customerPrincipal.deleteUser(dataGridUserList.CurrentRow.Cells["DNI"].Value.ToString());
            }
            else if (action == "restore")
            {
                customerPrincipal.restoreUser(dataGridUserList.CurrentRow.Cells["DNI"].Value.ToString());
            }
        }

        private void panelUserList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbRol_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (cbRol.Text == "Todos")
            {
                loadUsers();
            }
            else if (cbRol.Text == "Activos")
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
                    dataGridUserList.Columns.Add("Provincia", "Provincia");



                    foreach (var usuario in db.cliente)
                    {
                        if (usuario.fecha_eliminado == null)
                        {

                            DataGridViewRow fila = new DataGridViewRow();
                            fila.CreateCells(dataGridUserList, usuario.dni, usuario.nombre, usuario.apellido, usuario.email, usuario.domicilio, usuario.provincia?.nombre);
                            // Cambiar el color de fondo si está eliminado

                            fila.DefaultCellStyle.BackColor = Color.Red;
                            fila.DefaultCellStyle.ForeColor = Color.White; // Puedes ajustar el color del texto según sea necesario

                            dataGridUserList.Rows.Add(fila);
                        }
                    }
                    dataGridUserList.Refresh();
                }
            }
            else if (cbRol.Text == "Inactivos")
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
                    dataGridUserList.Columns.Add("Provincia", "Provincia");



                    foreach (var usuario in db.cliente)
                    {
                        if (usuario.fecha_eliminado != null)
                        {

                            DataGridViewRow fila = new DataGridViewRow();
                            fila.CreateCells(dataGridUserList, usuario.dni, usuario.nombre, usuario.apellido, usuario.email, usuario.domicilio, usuario.provincia?.nombre);
                            // Cambiar el color de fondo si está eliminado

                            fila.DefaultCellStyle.BackColor = Color.Red;
                            fila.DefaultCellStyle.ForeColor = Color.White; // Puedes ajustar el color del texto según sea necesario

                            dataGridUserList.Rows.Add(fila);
                        }
                    }
                    dataGridUserList.Refresh();
                }


            }
        }
    }
}*/
