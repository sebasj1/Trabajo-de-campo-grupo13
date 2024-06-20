using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace jbposs.Presentacion
{
    public partial class searchCustomer : Form
    {
        
        screenSale sCSale;
        public searchCustomer(screenSale sCS)
        {
            InitializeComponent();
            sCSale=sCS;

        }

        private void tbCust_TextChanged(object sender, EventArgs e)
        {
            if (tbCust.TextLength == 0)
            {

                dataGridCust.Rows.Clear(); 
            }
            else
            {
                loadCustomers();
            }

        }
        private void loadCustomers()
        {

            using (jbposEntities db = new jbposEntities())
            {
                dataGridCust.Rows.Clear();
                dataGridCust.Columns.Clear();
                dataGridCust.Columns.Add("DNI", "DNI");
                dataGridCust.Columns.Add("Apellido", "Apellido");
                dataGridCust.Columns.Add("Nombre", "Nombre");


                var clientQuery = db.cliente.ToList();

                try
                {
                    foreach (var cliP in clientQuery)
                    {
                       if (cliP.fecha_eliminado == null && (cliP.dni.Contains(tbCust.Text.Trim()) || (cliP.apellido.ToLower().Contains(tbCust.Text.ToLower().Trim()))))

                        {
                            DataGridViewRow fila = new DataGridViewRow();
                            fila.CreateCells(dataGridCust, cliP.dni, cliP.apellido, cliP.nombre);
                            dataGridCust.Rows.Add(fila);
                        }

                    }
                    dataGridCust.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo cargar datos" + ex);
                }
            }
        }


        private void dataGridCust_Click(object sender, EventArgs e)
        {   
            sCSale.cust(dataGridCust.CurrentRow.Cells["DNI"].Value.ToString());
            this.Dispose();
                
        }

        private void searchCustomer_Load(object sender, EventArgs e)
        {
        }
    }
}
