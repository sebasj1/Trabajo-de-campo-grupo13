using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JBPOS.Presentacion;
using FontAwesome.Sharp;
using jbposs.Presentacion;
using jbposs;

namespace JBPOS.Presentacion
{
    public partial class frmSales : Form
    {
        private salesList saleList;
        //private editProduct editProd;
        public frmSales()
        {
            InitializeComponent(); 
            saleList = new salesList(this);
            //editProd = new editProduct(this);
        }

        private void bNewProd_Click(object sender, EventArgs e)
        {
           // iconSelect((IconButton)sender, new newSale());
        }

        private void frmSales_Load(object sender, EventArgs e)
        {
            iconSelect(listSales, saleList);
            refreshList(listSales);
        }

        IconButton btnActive = null;
        private void iconSelect(IconButton buttonSelected, Form form)
        {
            if (btnActive != null)
            {
                btnActive.BackColor = System.Drawing.SystemColors.ControlLight;
            }

            buttonSelected.BackColor = System.Drawing.Color.Silver;
            panelUsersSales.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelUsersSales.Controls.Add(form);
            form.Show(); btnActive = buttonSelected;
        }

        private void bDevol_Click(object sender, EventArgs e)
        {
           iconSelect((IconButton)sender, saleList);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

            //iconSelect((IconButton)sender, new showVoucher());
        }

        public void delSale(string pNro)
        {
            using (jbposEntities db = new jbposEntities())
            {
                int Nro = int.Parse(pNro);
                venta ventaEliminar = db.venta.First(u => u.id_venta ==Nro );
                if (ventaEliminar != null)
                {
                    if (ventaEliminar.fecha_eliminado != null)
                    {
                        MessageBox.Show("Esta venta ya ha sido eliminado anteriormente.", "Ya eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar esta venta?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {
                            ventaEliminar.fecha_eliminado = DateTime.Now;

                            foreach (detalleVenta det in db.detalleVenta.Where(u => u.id_venta == Nro))
                            {
                                producto prod = db.producto.First(u => u.id_producto == det.id_producto); 
                                prod.stock += det.cantidad;
                                db.Entry(prod).State = System.Data.Entity.EntityState.Modified;
                                det.subtotal = 0;
                                ventaEliminar.total_venta = 0;
                                db.Entry(ventaEliminar).State = System.Data.Entity.EntityState.Modified;
                            } }
                            db.SaveChanges();

                            MessageBox.Show("Venta eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            refreshList(listSales);
                        saleList.lbSale.Text = "Lista de ventas";
                        saleList.action = "";

                    }
                    }

                
            }

        }
            

        public void refreshList(IconButton pBtn)
        {

            saleList.loadSales();
            iconSelect(pBtn, saleList);
        }
        private void bCancelSale_Click(object sender, EventArgs e)
        {
            saleList.lbSale.Text = "Seleccione una venta para eliminar";
            saleList.action = "delete";
            iconSelect((IconButton)sender, saleList);
        }

        private void listSales_Click(object sender, EventArgs e)
        {

            saleList.lbSale.Text = "Lista de ventas";
            saleList.action = "";
            iconSelect((IconButton)sender, saleList);
        }

        private void bVoucher_Click(object sender, EventArgs e)
        {
            saleList.lbSale.Text = "Seleccione una venta para mostrar comprobante";
            saleList.action = "comprobante";
            iconSelect((IconButton)sender, saleList);
            
            
        }
    }
}
