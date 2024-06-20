using JBPOS.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jbposs.Presentacion
{
    public partial class salesList : Form
    {
        private List<Control> originalControls;
        private filterUserList frmFilter;
        public string action = "";
        private frmSales salePrincipal;
        public salesList(frmSales pf)
        {
            InitializeComponent();
            salePrincipal = pf;
           // frmFilter = new filterUserList(this);
        }

        private void salesList_Load(object sender, EventArgs e)
        {
            loadSales();
            tabPage1.Name="Productos";
            tabPage2.Name = "Medio Pago";
            dgvDetail.AllowUserToAddRows = false;

        }
        public void loadSales()
        {
            DataGridViewButtonColumn det = new DataGridViewButtonColumn();
            det.Name = "Detalles";
            det.Text = "Detalles";
            det.HeaderText = "Detalles";
            det.UseColumnTextForButtonValue = true;
            det.DefaultCellStyle.BackColor = Color.Red;
            using (jbposEntities db = new jbposEntities())
            {
                dgvSales.Rows.Clear();
                dgvSales.Columns.Clear();
                dgvSales.Columns.Add("Número venta", "Número venta");
                dgvSales.Columns.Add("Total", "Total");
                dgvSales.Columns.Add("Cliente", "Cliente");
                dgvSales.Columns.Add("Usuario", "Usuario");
                dgvSales.Columns.Add("Fecha", "Fecha");
                dgvSales.Columns.Add(det);



                try
                {
                    foreach (var venta in db.venta)
                    {
                        cliente client=db.cliente.First(u=>u.id_cliente==venta.id_cliente);
                        usuario usuari = db.usuario.First(u => u.id_usuario == venta.id_vendedor);
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(dgvSales, venta.id_venta, "$ " + venta.total_venta, client.apellido+" "+client.nombre+", "+client.dni,usuari.nombre_usuario, venta.fecha,"");
                        // Cambiar el color de fondo si está eliminado
                        if (venta.fecha_eliminado != null)
                        {
                            fila.DefaultCellStyle.BackColor = Color.Red;
                            fila.DefaultCellStyle.ForeColor = Color.White; // Puedes ajustar el color del texto según sea necesario
                        }
                        dgvSales.Rows.Add(fila);
                    }
                    dgvSales.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo cargar datos" + ex);
                }
            }

        }

        private void dgvSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void showDetails(string pNumVenta)
        {
            using (jbposEntities db = new jbposEntities())
            {
                dgvDetail.Rows.Clear();
                dgvDetail.Columns.Clear();
                dgvDetail.Columns.Add("Codigo", "Codigo");
                dgvDetail.Columns.Add("Producto", "Producto");
                dgvDetail.Columns.Add("Cantidad", "Cantidad");
                dgvDetail.Columns.Add("Precio", "Precio");
                dgvDetail.Columns.Add("Total", "Total");

                try 
                {
                    foreach (detalleVenta detalle in db.detalleVenta)
                    {
                        if (detalle.id_venta == int.Parse(pNumVenta)) {
                        
                        producto prod = db.producto.First(u => u.id_producto == detalle.id_producto);
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(dgvDetail, prod.codigo, prod.titulo,detalle.cantidad, "$ " + prod.precio, "$ " + detalle.subtotal);
                            // Cambiar el color de fondo si está eliminado
                            if (detalle.fecha_eliminado != null)
                            {
                                fila.DefaultCellStyle.BackColor = Color.Red;
                                fila.DefaultCellStyle.ForeColor = Color.White; // Puedes ajustar el color del texto según sea necesario
                            }
                        dgvDetail.Rows.Add(fila);
                    } }
                    dgvDetail.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo cargar datos" + ex);
                }

                ///
                dgvMedio.Rows.Clear();
                dgvMedio.Columns.Clear();
                dgvMedio.Columns.Add("Medio de pago", "Medio de pago");
                dgvMedio.Columns.Add("Pago", "Pago");
                try
                {
                    foreach (venta_mediopago vmp in db.venta_mediopago)
                    {
                        if (vmp.id_venta == int.Parse(pNumVenta))
                        {
                            medioPago medP = db.medioPago.First(u => u.id_medioPago == vmp.id_medioPago); 
                            DataGridViewRow fila = new DataGridViewRow();
                            fila.CreateCells(dgvMedio, medP.descripcion, "$ " + vmp.monto);
                            // Cambiar el color de fondo si está eliminado
                            if (vmp.fecha_eliminado != null)
                            {
                                fila.DefaultCellStyle.BackColor = Color.Red;
                                fila.DefaultCellStyle.ForeColor = Color.White; // Puedes ajustar el color del texto según sea necesario
                            }
                            dgvMedio.Rows.Add(fila);
                        }
                    }
                    dgvMedio.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo cargar datos" + ex);
                }
            }
        }
            private void dgvDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btRefresh_Click(object sender, EventArgs e)
        {
            loadSales();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (DateTime.Compare(dtp1.Value.Date, dtp2.Value.Date) > 0)
            {
                MessageBox.Show("La primera fecha no puede ser mayor que la segunda");
            }
            else
            {


                DataGridViewButtonColumn det = new DataGridViewButtonColumn();
                det.Name = "Detalles";
                det.Text = "Detalles";
                det.HeaderText = "Eliminar";
                det.UseColumnTextForButtonValue = true;
                det.DefaultCellStyle.BackColor = Color.Red;
                using (jbposEntities db = new jbposEntities())
                {
                    dgvSales.Rows.Clear();
                    dgvSales.Columns.Clear();
                    dgvSales.Columns.Add("Número venta", "Número venta");
                    dgvSales.Columns.Add("Monto", "Monto");
                    dgvSales.Columns.Add("Cliente", "Cliente");
                    dgvSales.Columns.Add("Usuario", "Usuario");
                    dgvSales.Columns.Add("Fecha", "Fecha");
                    dgvSales.Columns.Add(det);



                    try
                    {
                        foreach (var venta in db.venta)
                        {
                            if (DateTime.Compare(dtp1.Value.Date, venta.fecha.Value.Date) == 0 || DateTime.Compare(dtp2.Value.Date, venta.fecha.Value.Date) == 0)
                            {
                                cliente client = db.cliente.First(u => u.id_cliente == venta.id_cliente);
                                usuario usuari = db.usuario.First(u => u.id_usuario == venta.id_vendedor);
                                DataGridViewRow fila = new DataGridViewRow();
                                fila.CreateCells(dgvSales, venta.id_venta, venta.total_venta, client.apellido + " " + client.nombre + ", " + client.dni, usuari.nombre_usuario, venta.fecha, "");
                                // Cambiar el color de fondo si está eliminado
                                if (venta.fecha_eliminado != null)
                                {
                                    fila.DefaultCellStyle.BackColor = Color.Red;
                                    fila.DefaultCellStyle.ForeColor = Color.White; // Puedes ajustar el color del texto según sea necesario
                                }
                                dgvSales.Rows.Add(fila);
                            }
                            dgvSales.Refresh();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo cargar datos" + ex);
                    }
                }
            } }

        private void dgvSales_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          
        }

        private void dgvSales_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {  if (e != null)
            {

                dgvSales.CurrentRow.Selected = true;
                if (e.ColumnIndex == dgvSales.Columns[5].Index)
                {
                    showDetails(dgvSales.CurrentRow.Cells["Número venta"].Value.ToString());
                }

                else if (action == "delete")
                {
                    salePrincipal.delSale(dgvSales.CurrentRow.Cells["Número venta"].Value.ToString());

                }
                else if (action == "comprobante")
                {
                    showSale ss = new showSale();

                    ss.chargeComprobante(dgvSales.CurrentRow.Cells["Número venta"].Value.ToString());
                    ss.ShowDialog();
                }
            }

        }
    }

}
