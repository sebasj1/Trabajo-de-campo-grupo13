using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jbposs.Presentacion
{
    public partial class frmCustomers : Form
    { public IconButton btnActive = null;
        public customersList custList;
        private editCustomer custEdit;
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            custList = new customersList(this);
            custEdit = new editCustomer(this);
            iconSelect(btlistCustomer, custList);
        }
        public void iconSelect(IconButton buttonSelected, Form form)
        {
            if (btnActive != null)
            {
                btnActive.BackColor = System.Drawing.SystemColors.ControlLight;
            }

            buttonSelected.BackColor = System.Drawing.Color.LightGray;
            panelUsers.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelUsers.Controls.Add(form);
            form.Show();
            btnActive = buttonSelected;
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            iconSelect((IconButton)sender, new addCustomer());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {


            //iconSelect((IconButton)sender, new usersList(this));

            iconSelect((IconButton)sender, new customersList(this));

        }
        public void userEdit_Click(object sender, EventArgs e)
        {

            custList.Text = "Seleccionar usuario para editar";
            custList.action = "edit";
            iconSelect((IconButton)sender, custList);
            custList.filter("", "");

        }

        //muestra lista desde useredit
        public void refreshList(IconButton pBtn)
        {

            custList.loadUsers();
            iconSelect(pBtn, custList);
        }


        //recibe el dni del usuario seleccionado y carga los campos en el formulario de editar
        public void userEd(string pDni)
        {
            custEdit.loadUser(pDni);
            iconSelect(btEditCustomer, custEdit);
        }


        //muestra la lista de usuarios
        private void frmUsers_Load(object sender, EventArgs e)
        {
            iconSelect(btlistCustomer, custList);
        }

        //Eliminar usuario
        private void delUser_Click(object sender, EventArgs e)
        {
            custList.lblCustList.Text = "Seleccionar usuario para eliminar";
            custList.action = "delete";
            iconSelect((IconButton)sender, custList);
            //iconSelect((IconButton)sender, delUs);

        }
        public void deleteUser(string pDni)
        {
            try
            {
                using (jbposEntities db = new jbposEntities())
                {
                    cliente clienteEliminar = db.cliente.First(u => u.dni == pDni);

                    if (clienteEliminar != null)
                    {
                        if (clienteEliminar.fecha_eliminado != null)
                        {
                            MessageBox.Show("Este usuario ya ha sido eliminado anteriormente.", "Ya eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        else
                        {
                            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este usuario?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (resultado == DialogResult.Yes)
                            {
                                // Establecer la fecha de eliminación como la fecha y hora actual
                                clienteEliminar.fecha_eliminado = DateTime.Now;


                                // Guardar los cambios en la base de datos
                                db.SaveChanges();

                                MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                refreshList(btlistCustomer);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void restUser_Click(object sender, EventArgs e)
        {
            custList.lblCustList.Text = "Seleccionar usuario para restaurar";
            custList.action = "restore";
            iconSelect((IconButton)sender, custList);
        }

        public void restoreUser(string pDni)
        {
            try
            {
                // Obtener el DNI del usuario seleccionado
                //string dniBuscar = dataGridUserList.SelectedRows[0].Cells["DNI"].Value.ToString();
                using (jbposEntities db = new jbposEntities())
                {

                    // Buscar el usuario por DNI
                    cliente clienteRestaurar = db.cliente.First(u => u.dni == pDni);

                    if (clienteRestaurar != null)
                    {
                        if (clienteRestaurar.fecha_eliminado == null)
                        {
                            MessageBox.Show("Este usuario no ha sido eliminado.", "No eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea restaurar este usuario?", "Confirmar Restauración", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (resultado == DialogResult.Yes)
                            {
                                // Elimina la fecha de eliminación 
                                clienteRestaurar.fecha_eliminado = null;

                                // Guardar los cambios en la base de datos
                                db.SaveChanges();
                                MessageBox.Show("Usuario restaurado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                panelUsers.Refresh();
                            }
                        }
                    }
                }
                refreshList(restCustomer);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error al restaurar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listUser_Click(object sender, EventArgs e)
        { custList.action = "";
            refreshList(btlistCustomer);
            custList.lblCustList.Text = "Lista de Clientes";

        }

        private void addUser_Click_1(object sender, EventArgs e)
        {
            iconSelect((IconButton)sender, new addCustomer());
        }

        private void btEditUser_Click(object sender, EventArgs e)
        {
            custList.lblCustList.Text = "Seleccionar cliente para editar";
            custList.action = "edit";
            iconSelect((IconButton)sender, custList);
            custList.filter("", "");
        }

        private void delCustomer_Click(object sender, EventArgs e)
        {
            custList.lblCustList.Text = "Seleccionar cliente para Eliminar";
            custList.action = "delete";
            iconSelect((IconButton)sender, custList);
            custList.filter("", "");
        }

        private void restCustomer_Click(object sender, EventArgs e)
        {
            custList.lblCustList.Text = "Seleccionar cliente para Restaurar";
            custList.action = "restore";
            iconSelect((IconButton)sender, custList);
            custList.filter("", "");
        }
    }
}
