
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Positivee.Modelos;

namespace Positive.Presentacion
{
    public partial class Cuadro_cobrar : Form
    {
       
        Pantalla_de_venta principal;
        private decimal total;
        private decimal montoInicial;
        private List<dynamic> lista_venta_medio_pago = new List<dynamic>();
        private List<Medio_pago> lista_medio_pago = new List<Medio_pago>();
        private Venta venta = new Venta();
        private decimal vuelto = 0; 
        List<Medio_pago> medio;
        Venta_medio_pago det=new Venta_medio_pago();
        public Cuadro_cobrar(Pantalla_de_venta frmPrin)
        {
            InitializeComponent();
            principal = frmPrin;
        }


        private void chargeDgv()
        {

            DataGridViewButtonColumn del = new DataGridViewButtonColumn();

            del.Name = "Eliminar";
            del.Text = "X";
            del.HeaderText = "Eliminar";
            del.DefaultCellStyle.BackColor = Color.Red;
            del.UseColumnTextForButtonValue = true;

            dgvMP.Rows.Clear();
            dgvMP.Columns.Clear();
            dgvMP.Columns.Add("Medio de pago", "Medio de pago");
            dgvMP.Columns.Add("Monto", "Monto");
            dgvMP.Columns.Add(del);
            dgvMP.Columns["Medio de pago"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvMP.Columns["Monto"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvMP.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMP.Columns["Medio de pago"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMP.Columns["Monto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMP.Columns[2].Width = 50;
 if (lista_venta_medio_pago.Count() > 0)
                {
            foreach (var rMdP in lista_venta_medio_pago)
            {
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(dgvMP,rMdP.descripcion, "$ " + rMdP.monto);

                    fila.Height = 40;

                    dgvMP.Rows.Add(fila);


                    dgvMP.Rows[0].Selected = false;

                }
            }
           
            lbVuelto.Text = det.obtener_vuelto().ToString();
            tbMonto.Text = det.obtener_restante().ToString();
        }

        private void cobrar_Load(object sender, EventArgs e)
        {
            
            total = principal.total;
            tbMonto.Text = total.ToString();
            montoInicial = total;
            lbVuelto.Text = vuelto.ToString();

            dgvMP.AllowUserToAddRows = false;

            Medio_pago mdp = new Medio_pago();
            cbMedioP.DataSource = mdp.lista_medio_pagos();
            cbMedioP.DisplayMember = "descripcion";
            cbMedioP.ValueMember = "id_medio_pago";
            cbMedioP.Refresh();

        

        cbMedioP.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMedioP.SelectedItem = 0;
            
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
           
            

        }
        private void addPago()
        {
           
            lista_venta_medio_pago=det.calcular_montos(total,tbMonto.Text,cbMedioP.SelectedValue.ToString(), cbMedioP.Text.ToString());
           total= det.obtener_restante();
            chargeDgv();
        }
        private void tbMonto_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(tbMonto.Text, out _))
            {
                tbMonto.Text = "";
            }
            else if (cbMedioP.Text.ToLower() != "efectivo" && decimal.Parse(tbMonto.Text) > total)
            {
                tbMonto.Text = total.ToString();
            }
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {

            addPago(); chargeDgv();
        }
        private void dgvMP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (total == 0)
            {
                Venta venta = new Venta();
                principal.registrar_venta(det.obtener_lista_de_medios_de_pago());
          //  principal.registrar_venta(lista_venta_medio_pago);

            }
            else
            {

                MessageBox.Show("Todavia no se alcanzo el monto total");
            }
        }

        private void dgvMP_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e != null && e.ColumnIndex == dgvMP.Columns[2].Index)
            {
                det.quitar_forma_pago(dgvMP.CurrentRow.Index); total = det.obtener_restante();
                chargeDgv();
            }

        }
        /*
        
public void registSale(List<registroMedioPago> pListReg)
{
   try
   {
       listReg = pListReg;
       int idVenta;
       venta vent = new venta();
       vent.id_cliente = clien.id_cliente;
       vent.id_vendedor = 1;
       vent.total_venta = total;
       vent.fecha_eliminado = null;
       vent.fecha = DateTime.Now;
       db.venta.Add(vent);
       db.SaveChanges();
       detalleVenta detSale = new detalleVenta();
       idVenta = vent.id_venta;
       detSale.id_venta = idVenta;
       foreach (elementoVenta eV in carrito)
       {

           detSale.id_producto = eV.Producto.id_producto;
           producto proEdStock = db.producto.FirstOrDefault(u => u.id_producto == detSale.id_producto);
           proEdStock.stock -= eV.Cantidad;
           db.Entry(proEdStock).State = System.Data.Entity.EntityState.Modified;
           detSale.cantidad = eV.Cantidad;
           detSale.subtotal = eV.Subtotal;
           detSale.fecha_eliminado = null;
           db.detalleVenta.Add(detSale);
           db.SaveChanges();
       }
       venta_mediopago ventaMediopago = new venta_mediopago();
       foreach (registroMedioPago registro in listReg)
       {
           ventaMediopago = registro.Venta_Medio;
           ventaMediopago.id_venta = idVenta;
           db.venta_mediopago.Add(ventaMediopago);
           db.SaveChanges();
       }
       showSale comprobante = new showSale();
       comprobante.chargeComprobante(idVenta.ToString());
       comprobante.ShowDialog();
       reset();
   }
   catch(Exception e)
   {
       MessageBox.Show("No fue posible guardar la venta "+e);
   }
}

                  
                    private void cbMedioP_SelectedIndexChanged(object sender, EventArgs e)
                    {

                        if (cbMedioP.DisplayMember.ToLower() != "efectivo" && decimal.Parse(tbMonto.Text) > total)
                        {
                            tbMonto.Text = total.ToString();
                        }

                    }




                    private void btClean_Click(object sender, EventArgs e)
                    {
                        total = montoInicial;
                        dgvMP.Rows.Clear();
                        dgvMP.Columns.Clear();
                        vuelto = 0;

                    }

                    private void cobrar_KeyDown(object sender, KeyEventArgs e)
                    {
                        if(e.KeyData== Keys.Enter)
                        {
                            addPago();
                        }
                    }

                    private void lbVuelto_Click(object sender, EventArgs e)
                    {

                    }

            }*/

    }
}

