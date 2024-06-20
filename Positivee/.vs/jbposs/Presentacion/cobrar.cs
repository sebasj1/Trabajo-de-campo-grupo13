using JBPOS.Presentacion;
using jbposs.Datos;
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
    public partial class cobrar : Form
    {
        screenSale principal;
        private decimal total;
        private decimal montoInicial;
        private List<venta_mediopago> list = new List<venta_mediopago>();
        private List<registroMedioPago> listReg = new List<registroMedioPago>();
        private decimal vuelto = 0;
        public cobrar(screenSale frmPrin)
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

            foreach (var rMdP in listReg)
            {
                if (listReg.Count() > 0)
                {
                    
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(dgvMP, rMdP.NombreMedio, "$ " + rMdP.Monto);

                    fila.Height = 40;

                    dgvMP.Rows.Add(fila);


                    dgvMP.Rows[0].Selected = false;

                }
            }
            tbMonto.Text = total.ToString();
        }

        private void cobrar_Load(object sender, EventArgs e)
        {
            total = principal.total;
            tbMonto.Text = total.ToString();
            montoInicial = total;
            lbVuelto.Text = vuelto.ToString();

            dgvMP.AllowUserToAddRows = false;
            using (jbposEntities db = new jbposEntities())
            {
                List<medioPago> medio = db.medioPago.ToList();


                var medioQuery = from r in db.medioPago
                                 select new { r.id_medioPago, r.descripcion };

                cbMedioP.DataSource = medioQuery.ToList();
                cbMedioP.DisplayMember = "descripcion";
                cbMedioP.ValueMember = "id_medioPago";
                cbMedioP.Refresh();

            } 
           
            cbMedioP.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMedioP.SelectedItem = 0;
            
        }

        private void addPago()
        {
            if (total > 0) { 
            decimal cuantoPaga = decimal.Parse(tbMonto.Text);
            decimal montoPago; ;
             registroMedioPago regMP = new registroMedioPago();
                venta_mediopago med = new venta_mediopago();
                med.id_medioPago = int.Parse(cbMedioP.SelectedValue.ToString());
                if (cuantoPaga > total)
                {
                    med.monto = total;
                    montoPago = total;
                }
                else
                {
                med.monto = cuantoPaga;
                montoPago = cuantoPaga;
                }
                med.fecha_eliminado = null;
                med.fecha_creacion = DateTime.Now; 
                list.Add(med);
                regMP.cargar(med, cbMedioP.Text, montoPago);

                if (!(listReg.Count(u => u.NombreMedio == regMP.NombreMedio) > 0))
                {
                    listReg.Add(regMP);
                    chargeDgv();
                }
                else
                {

                    registroMedioPago el = listReg.FirstOrDefault(u => u.NombreMedio == regMP.NombreMedio);
                    venta_mediopago ven=list.FirstOrDefault(u => u.id_medioPago == regMP.Venta_Medio.id_medioPago);
                    int i = listReg.IndexOf(el); 
                    int j = list.IndexOf(ven);
                    listReg[i].Monto += regMP.Monto;
                    list[j].monto +=regMP.Monto;
                    chargeDgv();
                }
               
                total -= cuantoPaga;

                
                if (total >= 0)
                { if (vuelto > total)
                    {
                       vuelto-=cuantoPaga;

                    }
                    else
                    {vuelto = 0;

                    }
                        
                }
                else
                {
                   vuelto = cuantoPaga - montoPago;
                   total = 0;
                   chargeDgv();
                }
                 lbVuelto.Text = "Vuelto: $ " + vuelto;
            }
            else
            {
                MessageBox.Show("Ya se alcanzó el monto a cubrir");

            }

            tbMonto.Text = total.ToString();
        }

    

        private void iconButton1_Click(object sender, EventArgs e)
        {
            addPago();
        }

        private void tbMonto_TextChanged(object sender, EventArgs e)
        {
            if(!decimal.TryParse(tbMonto.Text,out _))
            {
                tbMonto.Text = "";
            }
            else if (cbMedioP.Text.ToLower() != "efectivo"&&decimal.Parse(tbMonto.Text)>total)
            {
                tbMonto.Text = total.ToString();
            }
        }
        private void cbMedioP_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbMedioP.DisplayMember.ToLower() != "efectivo" && decimal.Parse(tbMonto.Text) > total)
            {
                tbMonto.Text = total.ToString();
            }

        }

        private void dgvMP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
               if (e.ColumnIndex == dgvMP.Columns[2].Index )
                {
              
                    restFormPago(dgvMP.CurrentRow.Index);
                }
         }
        private void restFormPago(int pInd)
        {
            registroMedioPago el = listReg[pInd];
            total += el.Monto;
            if (el.NombreMedio.ToLower() == "efectivo")
            {
               
                    vuelto += el.Monto;
               
            }
            listReg.Remove(el);
            dgvMP.Rows.Clear();
            chargeDgv();
            tbMonto.Text = total.ToString();
            lbVuelto.Text = "Vuelto: $ " + vuelto.ToString();


        
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (total == 0) { 
            principal.registSale(listReg); 
            showSale comprobante = new showSale();
            this.Dispose();
            }
            else
            {
                MessageBox.Show("No se alcanzo el monto total","Pago incompleto",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
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
    }
}

