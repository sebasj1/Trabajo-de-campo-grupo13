using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace jbposs.Presentacion
{
    public partial class frmProducts : Form
    {
        private productList prodList;
        private editProduct editProd;
        public frmProducts()
        {
            InitializeComponent();
            prodList = new productList(this);
            editProd = new editProduct(this);
        }


        IconButton btnActive = null;
        private void iconSelect(IconButton buttonSelected, Form form)
        {
            if (btnActive != null)
            {
                btnActive.BackColor = System.Drawing.SystemColors.ControlLight;
            }

            buttonSelected.BackColor = System.Drawing.Color.Silver;
            panelProducts.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelProducts.Controls.Add(form);
            form.Show(); btnActive = buttonSelected;
        }


        private void btDelProd_Click(object sender, EventArgs e)
        {
            prodList.lblUsList.Text = "Seleccionar producto para eliminar";
            prodList.action = "delete";
            iconSelect((IconButton)sender, prodList);

        }
        public void deleteProd(string pCod)
        {
            try
            {
                // Obtener el DNI del usuario seleccionado
                // string dniBuscar = dataGridUserList.SelectedRows[0].Cells["DNI"].Value.ToString();

                // Buscar el usuario por DNI
                using (jbposEntities db = new jbposEntities())
                {
                    producto prodEliminar = db.producto.First(u => u.codigo == pCod);

                    if (prodEliminar != null)
                    {
                        if (prodEliminar.fecha_eliminado != null)
                        {
                            MessageBox.Show("Este producto ya ha sido eliminado anteriormente.", "Ya eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        else
                        {
                            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este producto?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (resultado == DialogResult.Yes)
                            {
                                // Establecer la fecha de eliminación como la fecha y hora actual
                                prodEliminar.fecha_eliminado = DateTime.Now;


                                // Guardar los cambios en la base de datos
                                db.SaveChanges();

                                MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                refreshList(btDelProd);
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
        public void refreshList(IconButton pBtn)
        {

            prodList.loadProd();
            iconSelect(pBtn, prodList);
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            iconSelect(listProd, prodList);
        }


        private void listProd_Click(object sender, EventArgs e)
        {
            iconSelect((IconButton)sender, new productList(this));
        }

        private void bNewProd_Click(object sender, EventArgs e)
        {
            iconSelect((IconButton)sender, new addProduct());
        }


        private void btProdEd_Click(object sender, EventArgs e)
        {
            prodList.lblUsList.Text = "Seleccionar producto para editar";
            prodList.action = "edit";
            iconSelect((IconButton)sender, prodList);
        }

        public void backEdit()
        {
            iconSelect(btProdEd, prodList);
        }
        
        public void prodEd(string pDni)
        {
            
            editProd.loadProd(pDni);
            iconSelect(btProdEd, editProd);
        }

        private void btEditCat_Click(object sender, EventArgs e)
        {
            addCategorie ar = new addCategorie();
            ar.ShowDialog();
        }

        private void btRestP_Click(object sender, EventArgs e)
        {
            prodList.lblUsList.Text = "Seleccionar producto para restaurar";
            prodList.action = "restore";
            iconSelect((IconButton)sender, prodList);
        }
        public void restoreProd(string pCodigo)
        {
            try
            {
                // Obtener el DNI del usuario seleccionado
                //string dniBuscar = dataGridUserList.SelectedRows[0].Cells["DNI"].Value.ToString();
                using (jbposEntities db = new jbposEntities())
                {

                    // Buscar el usuario por DNI
                    producto prodRestaurar = db.producto.First(u => u.codigo == pCodigo);

                    if (prodRestaurar != null)
                    {
                        if (prodRestaurar.fecha_eliminado == null)
                        {
                            MessageBox.Show("Este producto no ha sido eliminado.", "No eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea restaurar este producto", "Confirmar Restauración", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (resultado == DialogResult.Yes)
                            {
                                // Elimina la fecha de eliminación 
                                prodRestaurar.fecha_eliminado = null;

                                // Guardar los cambios en la base de datos
                                db.SaveChanges();
                                MessageBox.Show("Producto restaurado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                panelProducts.Refresh();
                            }
                        }
                    }


                }
                refreshList(btRestP);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error al restaurar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelProducts_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
