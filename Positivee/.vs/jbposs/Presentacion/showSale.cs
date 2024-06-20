using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jbposs.Presentacion
{
    public partial class showSale : Form
    {
        public showSale()
        {
            InitializeComponent();
        }
        //declare event handler for printing in constructor
       // printdoc1.PrintPage += new PrintPageEventHandler(printdoc1_PrintPage);

        //Rest of the code
        Bitmap MemoryImage;
        public void GetPrintArea(Panel pnl)
        {
            MemoryImage = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(MemoryImage, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (MemoryImage != null)
            {
                e.Graphics.DrawImage(MemoryImage, 0, 0);
                base.OnPaint(e);
            }
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(MemoryImage, (pagearea.Width / 2) - (this.panel1.Width / 2), this.panel1.Location.Y);
        }
        public void Print(Panel pnl)
        {
           
            GetPrintArea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
  
        private void buttonPrint_Click(object sender, EventArgs e)
        {
            Print(this.panel1);
        }

        private void showSale_Load(object sender, EventArgs e)
        {
            dgvDetail.AllowUserToAddRows = false;

        }
        public void chargeComprobante(string pNumVenta)
        {
            lbNroVenta.Text = "Nro. venta: "+pNumVenta;
        using (jbposEntities db = new jbposEntities())
            {
            try
                { int i = int.Parse(pNumVenta);
                    venta ven = db.venta.First(u => u.id_venta ==i );
                    cliente client = db.cliente.First(u => u.id_cliente == ven.id_cliente);
                    usuario usuari = db.usuario.First(u => u.id_usuario == ven.id_vendedor);
                    lbTotal.Text = "Total: $ " + ven.total_venta.ToString();
                    lbFecha.Text = "Fecha : "+ven.fecha.Value.ToString();
                    lbCliente.Text ="Cliente: "+ ven.cliente.apellido.ToString()+", " + ven.cliente.nombre.ToString();
                    lbUsuario.Text = "Usuario: " + usuari.nombre_usuario;
                    dgvDetail.Rows.Clear();
                    dgvDetail.Columns.Clear();
                    dgvDetail.Columns.Add("Producto", "Producto");
                    dgvDetail.Columns.Add("Cantidad", "Cantidad");
                    dgvDetail.Columns.Add("Precio", "Precio");
                    dgvDetail.Columns.Add("Subtotal", "Subtotal");
                
                
                    foreach (detalleVenta detalle in db.detalleVenta)
                    {
                        if (detalle.id_venta == int.Parse(pNumVenta))
                        {

                            producto prod = db.producto.First(u => u.id_producto == detalle.id_producto);
                            DataGridViewRow fila = new DataGridViewRow();
                            fila.Height = 20;
                            fila.CreateCells(dgvDetail, prod.titulo, detalle.cantidad, prod.precio, detalle.subtotal);
                            // Cambiar el color de fondo si está eliminado
                            if (detalle.fecha_eliminado != null)
                            {   
                                fila.DefaultCellStyle.BackColor = Color.Red;
                                fila.DefaultCellStyle.ForeColor = Color.White; // Puedes ajustar el color del texto según sea necesario
                            }
                            dgvDetail.Rows.Add(fila);
                        }
                    }
                    dgvDetail.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo cargar datos" + ex);
                }

                ///
               
            }
        }
    }
}
