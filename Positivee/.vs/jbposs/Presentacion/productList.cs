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


namespace jbposs.Presentacion
{

    public partial class productList : Form
    {
        //private jbposEntities context;
        //private List<Control> originalControls;
        filterProdList frmFilter;
        public string action = "";
        private frmProducts prodPrincipal;

        public productList(frmProducts pf)
        {
            InitializeComponent();

            frmFilter = new filterProdList(this);
            //context = new jbposEntities();
            prodPrincipal = pf;
        }
        public productList()
        {
            InitializeComponent();

            
        }

        private void productList_Load(object sender, EventArgs e)
        {
            loadProd();
            lblUsList.Text = "Listado de productos";
           using (jbposEntities db = new jbposEntities())
            {
                //Cargar categorias
                cbCateg.Items.Clear();
                cbCateg.Items.Add("Todos");
                foreach (categoria r in db.categoria)
                {
                    cbCateg.Items.Add(r.nombre);
                }

            }
        }

        public void loadProd()
        {
            using (jbposEntities db = new jbposEntities())
            {
                dataGridProd.Rows.Clear();
                dataGridProd.Columns.Clear();
                dataGridProd.Columns.Add("Codigo", "Codigo");
                dataGridProd.Columns.Add("Titulo", "Titulo");
                dataGridProd.Columns.Add("Descripción", "Descripción");
                dataGridProd.Columns.Add("Precio", "Precio");
                dataGridProd.Columns.Add("Stock", "Stock");
                dataGridProd.Columns.Add("Categoria", "Categoria");


                var prodQuery = from u in db.producto
                                    select new
                                    {
                                        u.codigo,
                                        u.titulo,
                                        u.descripcion,
                                        u.precio,
                                        u.stock,
                                        u.fecha_eliminado,
                                        u.categoria,
                                    };

                try
                {
                    foreach (var producto in prodQuery)
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(dataGridProd, producto.codigo, producto.titulo, producto.descripcion, producto.precio, producto.stock, producto.categoria?.nombre);
                        // Cambiar el color de fondo si está eliminado
                        if (producto.fecha_eliminado != null)
                        {
                            fila.DefaultCellStyle.BackColor = Color.Red;
                            fila.DefaultCellStyle.ForeColor = Color.White; // Puedes ajustar el color del texto según sea necesario
                        }
                        dataGridProd.Rows.Add(fila);
                    }
                    dataGridProd.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo cargar datos" + ex);
                }
            }

        }


        private void cbCateg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCateg.Text == "Todos")
            {
                loadProd();
            }
            else
            {
                using (jbposEntities db = new jbposEntities())
                {
                   
                    dataGridProd.Rows.Clear();
                    dataGridProd.Columns.Clear();
                    dataGridProd.Columns.Add("Codigo", "Codigo");
                    dataGridProd.Columns.Add("Titulo", "Titulo");
                    dataGridProd.Columns.Add("Descripción", "Descripción");
                    dataGridProd.Columns.Add("Stock", "Stock");
                    dataGridProd.Columns.Add("Precio", "Precio");
                    dataGridProd.Columns.Add("Categoria", "Categoria");


                    var prodQuery = from u in db.producto
                                    select new
                                    {
                                        u.codigo,
                                        u.titulo,
                                        u.descripcion,
                                        u.precio,
                                        u.stock,
                                        u.fecha_eliminado,
                                        u.categoria,
                                    };


                    foreach (var producto in prodQuery)
                    {
                        if (producto.categoria?.nombre == cbCateg.Text)
                        {
                            DataGridViewRow fila = new DataGridViewRow();
                            fila.CreateCells(dataGridProd, producto.codigo, producto.titulo, producto.descripcion, producto.precio, producto.stock, producto.categoria?.nombre);
                            // Cambiar el color de fondo si está eliminado
                            if (producto.fecha_eliminado != null)
                            {
                                fila.DefaultCellStyle.BackColor = Color.Red;
                                fila.DefaultCellStyle.ForeColor = Color.White; // Puedes ajustar el color del texto según sea necesario
                            }
                            dataGridProd.Rows.Add(fila);
                        }
                    }dataGridProd.Refresh();
                
                }


            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            frmFilter.ShowDialog(); 
        }


        private void btRefresh_Click(object sender, EventArgs e)
        {
            loadProd();
        }

        private void btnFilterProd_Click(object sender, EventArgs e)
        {

           frmFilter.ShowDialog(); 
        }

        private void dataGridProd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridProd.CurrentRow.Selected = true;
            if (action == "edit")
            {
                prodPrincipal.prodEd(dataGridProd.CurrentRow.Cells["Codigo"].Value.ToString());

            }
            else if (action == "delete")
            {
                prodPrincipal.deleteProd(dataGridProd.CurrentRow.Cells["Codigo"].Value.ToString());
            }
            else if (action == "restore")
            {
                prodPrincipal.restoreProd(dataGridProd.CurrentRow.Cells["Codigo"].Value.ToString());
            }
        }

        public void filter(string pRb, string pEl)
        {


            dataGridProd.Rows.Clear();
            dataGridProd.Columns.Clear();
            dataGridProd.Columns.Add("Codigo", "Codigo");
            dataGridProd.Columns.Add("Titulo", "Titulo");
            dataGridProd.Columns.Add("Descripción", "Descripción");
            dataGridProd.Columns.Add("Precio", "Precio");
            dataGridProd.Columns.Add("Stock", "Stock");
            dataGridProd.Columns.Add("Categoria", "Categoria");

            using (jbposEntities db = new jbposEntities())
            {

                var prodQuery = from u in db.producto
                                select new
                                {
                                    u.codigo,
                                    u.titulo,
                                    u.descripcion,
                                    u.precio,
                                    u.stock,
                                    u.fecha_eliminado,
                                    u.categoria,
                                };


                foreach (var producto in prodQuery)
                {if (pRb == "Codigo" && producto.codigo.Contains(pEl.Trim()))
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(dataGridProd, producto.codigo, producto.titulo, producto.descripcion, producto.precio, producto.stock, producto.categoria?.nombre);
                    // Cambiar el color de fondo si está eliminado
                        if (producto.fecha_eliminado != null)
                        {
                            fila.DefaultCellStyle.BackColor = Color.Red;
                            fila.DefaultCellStyle.ForeColor = Color.White; // Puedes ajustar el color del texto según sea necesario
                        }
                        dataGridProd.Rows.Add(fila);
                    }
                    else if (pRb == "Titulo" && producto.titulo.ToLower().Contains(pEl.ToLower().Trim()))
                    {

                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(dataGridProd, producto.codigo, producto.titulo, producto.descripcion, producto.precio, producto.stock, producto.categoria?.nombre);
                         // Cambiar el color de fondo si está eliminado
                        if (producto.fecha_eliminado != null)
                        {
                            fila.DefaultCellStyle.BackColor = Color.Red;
                            fila.DefaultCellStyle.ForeColor = Color.White; // Puedes ajustar el color del texto según sea necesario
                        }
                        dataGridProd.Rows.Add(fila);
                    }
                    else if (pRb == "Descripcion" && producto.descripcion.ToLower().Contains(pEl.ToLower().Trim()))
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(dataGridProd, producto.codigo, producto.titulo, producto.descripcion, producto.precio, producto.stock, producto.categoria?.nombre);
                        // Cambiar el color de fondo si está eliminado
                        if (producto.fecha_eliminado != null)
                        {
                            fila.DefaultCellStyle.BackColor = Color.Red;
                            fila.DefaultCellStyle.ForeColor = Color.White; // Puedes ajustar el color del texto según sea necesario
                        }
                        dataGridProd.Rows.Add(fila);
                    }
                    
                    else if (pEl == "")
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(dataGridProd, producto.codigo, producto.titulo, producto.descripcion, producto.precio, producto.stock, producto.categoria?.nombre);
                        // Cambiar el color de fondo si está eliminado
                        if (producto.fecha_eliminado != null)
                        {
                            fila.DefaultCellStyle.BackColor = Color.Red;
                            fila.DefaultCellStyle.ForeColor = Color.White; // Puedes ajustar el color del texto según sea necesario
                        }
                        dataGridProd.Rows.Add(fila);
                    }

                }
                dataGridProd.Refresh();
            }
        }

        private void btRefresh_Click_1(object sender, EventArgs e)
        {
            loadProd();
        }

        private void dataGridProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

