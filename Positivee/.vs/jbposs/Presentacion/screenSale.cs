using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using FontAwesome.Sharp;
using jbposs.Datos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace jbposs.Presentacion
{
    public partial class screenSale : Form
    {
        private static frmMain frmMainPrincipal;
        private usuario usuarioLog;
        private productList prodList;
        private jbposEntities db = new jbposEntities();
        private List<elementoVenta> carrito = new List<elementoVenta>();
        private List<registroMedioPago> listReg = new List<registroMedioPago>();
        private List<medioPago> medios = new List<medioPago>();
        private bool scV = true;
        public decimal total = 0;
        private cliente clien;
        private bool screenProd = true;



        public screenSale(frmMain pfrmMain, usuario pUser)
        {
            InitializeComponent();
            usuarioLog = pUser;
            frmMainPrincipal = pfrmMain;
            prodList = new productList();
            clientDefect();
            principal.screenSaleShow(pfrmMain, this);

        }
        public screenSale()
        {
            InitializeComponent();
            prodList = new productList();

        }

        public void refreshDB()
        {
            db.Dispose();
            db = new jbposEntities();
        }

        private void screenSale_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            lbTotal.Text = total.ToString();
            this.AutoScaleMode = AutoScaleMode.Dpi;
            dgvDetail.AllowUserToAddRows = false;
            dgvSales.AllowUserToAddRows = false;
            dgvMedio.AllowUserToAddRows = false;
            labelUsuario.Text = "Usuario: " + usuarioLog.nombre.ToString() + " " + usuarioLog.apellido.ToString();
           

        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lblClock_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss");
            lbDate.Text = DateTime.Now.ToLongDateString();

        }

        private void btMain_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("¿Desea salir al menú principal?", "Salir al menú", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resul == DialogResult.OK)
            {
                principal.mainShow();
            }
        }

        private void screenSale_FormClosing_1(object sender, FormClosingEventArgs e)
        {

            DialogResult resul = MessageBox.Show("¿Desea cerrar todas las ventanas?", "Cerrar ventanas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resul == DialogResult.Yes)
            {
                principal.closeAll();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btAdd_MouseMove(object sender, MouseEventArgs e)
        {
            btOk.BackColor = System.Drawing.Color.FromArgb(37, 88, 175);
        }

        private void btAdd_MouseLeave(object sender, EventArgs e)
        {
            btOk.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void btClean_MouseMove(object sender, MouseEventArgs e)
        {
            btClean.BackColor = System.Drawing.Color.FromArgb(215, 115, 38);
        }

        private void btClean_MouseLeave(object sender, EventArgs e)
        {
            btClean.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
        }

        private void btMain_MouseMove(object sender, MouseEventArgs e)
        {
            btMain.BackColor = System.Drawing.Color.DarkGray;
        }

        private void btMain_MouseLeave(object sender, EventArgs e)
        {
            btMain.BackColor = System.Drawing.Color.Gray;
        }

        private void tbBrow_TextChanged(object sender, EventArgs e)
        {
            if (tbBrow.Text == "")
            {
                pantallaVenta();

            }
            else
            {

                scV = false;
                filterScreen(tbBrow.Text);
            }
        }
        ///Pantall aprincipal
        public void filterScreen(string pText)
        {
            screenProd = true;
            dgvPrincipal.Rows.Clear();
            dgvPrincipal.Columns.Clear();
            dgvPrincipal.Columns.Add("Codigo", "Codigo");
            dgvPrincipal.Columns.Add("Titulo", "Titulo");
            dgvPrincipal.Columns.Add("Precio", "Precio");
            dgvPrincipal.Columns.Add("Stock", "Stock");

            dgvPrincipal.Columns["Titulo"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvPrincipal.Columns["Codigo"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvPrincipal.Columns["Precio"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvPrincipal.Columns["Stock"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvPrincipal.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPrincipal.Columns["Titulo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPrincipal.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPrincipal.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPrincipal.Columns["Stock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPrincipal.RowsDefaultCellStyle.BackColor = SystemColors.InactiveCaption;
            dgvPrincipal.RowsDefaultCellStyle.ForeColor = Color.Black;

            foreach (var producto in db.producto)
            {
                if (producto.fecha_eliminado == null)
                {
                    if (int.TryParse(pText, out _) && producto.codigo.Contains(pText.Trim()) || (producto.titulo.ToLower().Contains(pText.ToLower().Trim())))
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(dgvPrincipal, producto.codigo, producto.titulo, producto.precio, producto.stock);
                        // Cambiar el color de fondo si está eliminado
                        if (producto.stock <= 0)
                        {
                            fila.DefaultCellStyle.BackColor = Color.Red;
                        }

                        fila.Height = 50;
                        dgvPrincipal.Rows.Add(fila);

                        dgvPrincipal.Rows[0].Selected = false;

                    }

                    dgvPrincipal.Refresh();
                }
            }


        }



        private void cargar_carrito(string prod1)
        {
            producto prod = db.producto.First(u => u.codigo == prod1);
            int i = 0;
            elementoVenta prodCarrito = new elementoVenta();
            prodCarrito.cargar(prod, 1, prod.precio);
            if (!(carrito.Count(u => u.Producto == prod) > 0))
            {

                carrito.Add(prodCarrito);
            }
            else
            {
                elementoVenta el = carrito.First(u => u.Producto == prod);
                i = carrito.IndexOf(el);
                sumProd(i);
            }
            tbBrow.Text = "";

        }


        public void pantallaVenta()
        {
            screenProd = false;
            scV = true;
            DataGridViewButtonColumn min = new DataGridViewButtonColumn();
            DataGridViewButtonColumn max = new DataGridViewButtonColumn();
            DataGridViewButtonColumn del = new DataGridViewButtonColumn();
            min.Name = "min";
            min.Text = "-";
            min.HeaderText = "";
            min.UseColumnTextForButtonValue = true;

            max.Name = "max";
            max.Text = "+";
            max.HeaderText = "";
            max.UseColumnTextForButtonValue = true;

            del.Name = "Eliminar";
            del.Text = "X";
            del.HeaderText = "Eliminar";
            del.UseColumnTextForButtonValue = true;
            del.DefaultCellStyle.BackColor = Color.Red;

            dgvPrincipal.Rows.Clear();
            dgvPrincipal.Columns.Clear();
            dgvPrincipal.Columns.Add("Titulo", "Titulo");
            dgvPrincipal.Columns.Add(min);
            dgvPrincipal.Columns.Add("Cantidad", "Cantidad");
            dgvPrincipal.Columns.Add(max);
            dgvPrincipal.Columns.Add("Precio Unitario", "Precio Unitario");
            dgvPrincipal.Columns.Add("Subtotal", "Subtotal");
            dgvPrincipal.Columns.Add(del);
            dgvPrincipal.Columns["Titulo"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvPrincipal.Columns["Cantidad"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvPrincipal.Columns["Precio Unitario"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvPrincipal.Columns["Subtotal"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvPrincipal.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPrincipal.Columns["Titulo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPrincipal.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPrincipal.Columns["Precio Unitario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPrincipal.Columns["Subtotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPrincipal.Columns[1].Width = 50;
            dgvPrincipal.Columns[3].Width = 50;
            dgvPrincipal.Columns[6].Width = 80;

            total = 0;
            dgvPrincipal.RowsDefaultCellStyle.BackColor = SystemColors.Highlight;
            dgvPrincipal.RowsDefaultCellStyle.ForeColor = SystemColors.HighlightText;
            dgvPrincipal.Columns["Cantidad"].ReadOnly = false;
            foreach (var prodCar in carrito)
            {
                if (carrito.Count() > 0)
                {
                    total += prodCar.Subtotal;
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(dgvPrincipal, prodCar.Producto.titulo, "", prodCar.Cantidad, "", "$ " + prodCar.Producto.precio, "$ " + prodCar.Subtotal, "");

                    fila.Height = 70;
                    if (prodCar.Cantidad > prodCar.Producto.stock)
                    {
                        fila.DefaultCellStyle.BackColor = Color.Red;
                        fila.DefaultCellStyle.SelectionBackColor = Color.OrangeRed;
                        fila.DefaultCellStyle.ForeColor = Color.White; // Puedes ajustar el color del texto según sea necesario
                    }
                    dgvPrincipal.Rows.Add(fila); dgvPrincipal.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;


                    dgvPrincipal.Rows[0].Selected = false;

                }
            }
            lbTotal.Text = total.ToString();
        }

        private void dgvPrincipal_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e != null)
            {

                if (!scV)
                {
                    dgvPrincipal.CurrentRow.Selected = true;
                    cargar_carrito(dgvPrincipal.CurrentRow.Cells["Codigo"].Value.ToString());
                    pantallaVenta();
                    tbBrow.Text = "";
                }
                else if (e.ColumnIndex == dgvPrincipal.Columns[1].Index && scV)
                {
                    restProd(dgvPrincipal.CurrentRow.Index);
                }
                else if (e.ColumnIndex == dgvPrincipal.Columns[3].Index && scV)
                {
                    sumProd(dgvPrincipal.CurrentRow.Index);
                }
                else if (e.ColumnIndex == dgvPrincipal.Columns[6].Index && scV)
                {

                    DialogResult resultado = MessageBox.Show("¿Eliminar de la lista?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        delProd(dgvPrincipal.CurrentRow.Index);
                    }
                }

            }
        }




        private void sumProd(int pProd)
        {

            elementoVenta el = carrito[pProd];
            el.Cantidad += 1;
            el.Subtotal = el.Cantidad * el.Producto.precio;
            total += el.Producto.precio;
            carrito[pProd] = el;
            dgvPrincipal.Rows.Clear();
            foreach (var prodCar in carrito)
            {
                DataGridViewRow fila = new DataGridViewRow();

                fila.CreateCells(dgvPrincipal, prodCar.Producto.titulo, "", prodCar.Cantidad, "", "$ " + prodCar.Producto.precio, "$ " + prodCar.Subtotal, "");
                fila.Height = 70;
                if (prodCar.Cantidad > prodCar.Producto.stock)
                {
                    fila.DefaultCellStyle.BackColor = Color.Red;
                    fila.DefaultCellStyle.SelectionBackColor = Color.OrangeRed;
                    fila.DefaultCellStyle.ForeColor = Color.White;  // Puedes ajustar el color del texto según sea necesario
                }
                dgvPrincipal.Rows.Add(fila);
            }


            lbTotal.Text = total.ToString();
            dgvPrincipal.Rows[0].Selected = false;
            dgvPrincipal.Rows[pProd].Selected = true;


        }
        private void restProd(int pProd)
        {
            elementoVenta el = carrito[pProd];
            if (el.Cantidad > 1)
            {
                el.Cantidad -= 1;
                el.Subtotal = el.Cantidad * el.Producto.precio;
                total -= el.Producto.precio;
            }
            carrito[pProd] = el;
            dgvPrincipal.Rows.Clear();

            foreach (var prodCar in carrito)
            {
                DataGridViewRow fila = new DataGridViewRow();


                {
                    fila.CreateCells(dgvPrincipal, prodCar.Producto.titulo, "", prodCar.Cantidad, "", "$ " + prodCar.Producto.precio, "$ " + prodCar.Subtotal, "");
                    fila.Height = 70;
                    if (prodCar.Cantidad > prodCar.Producto.stock)
                        fila.DefaultCellStyle.BackColor = Color.Red;
                    fila.DefaultCellStyle.SelectionBackColor = Color.OrangeRed;
                    fila.DefaultCellStyle.ForeColor = Color.White;  // Puedes ajustar el color del texto según sea necesario
                }
                dgvPrincipal.Rows.Add(fila);

            }
            lbTotal.Text = total.ToString();
            dgvPrincipal.Rows[0].Selected = false;
            dgvPrincipal.Rows[pProd].Selected = true;
        }
        private void delProd(int pProd)
        {
            elementoVenta el = carrito[pProd];
            carrito.Remove(el);
            total -= el.Cantidad * el.Producto.precio;
            dgvPrincipal.Rows.Clear();


            foreach (var prodCar in carrito)
            {
                DataGridViewRow fila = new DataGridViewRow();

                fila.CreateCells(dgvPrincipal, prodCar.Producto.titulo, "", prodCar.Cantidad, "", prodCar.Producto.precio, prodCar.Subtotal, "");
                if (prodCar.Cantidad > prodCar.Producto.stock)
                {
                    fila.DefaultCellStyle.BackColor = Color.Red;
                    fila.DefaultCellStyle.SelectionBackColor = Color.OrangeRed;
                    fila.DefaultCellStyle.ForeColor = Color.White;  // Puedes ajustar el color del texto según sea necesario
                }
                fila.Height = 70;
                dgvPrincipal.Rows.Add(fila);

            }
            lbTotal.Text = total.ToString();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (total != 0)
            {

                cobrar cob = new cobrar(this);
                cob.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se han cargado productos");
            }



        }

        private void reset()
        {
            carrito.Clear();
            total = 0;
            dgvPrincipal.Columns.Clear();
            dgvPrincipal.Rows.Clear();
            clientDefect();


        }

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

        private void clientDefect()
        {
            try
            {
                cliente cl = (db.cliente.FirstOrDefault(u => u.apellido == "Eventual"));

                if (cl == null)
                {
                    cliente clienteDefault = new cliente();
                    List<provincia> provDef = db.provincia.ToList(); clienteDefault.id_provincia = provDef[0].id_provincia;
                    clienteDefault.apellido = "Eventual";
                    clienteDefault.nombre = "";
                    clienteDefault.domicilio = null;
                    clienteDefault.email = null;
                    clienteDefault.dni = "00000000";
                    clienteDefault.telefono = null;
                    clienteDefault.fecha_eliminado = null;
                    db.cliente.Add(clienteDefault);
                    db.SaveChanges();
                    clien = clienteDefault;
                }
                else
                {
                    if (cl.fecha_eliminado != null)
                    {
                        cl.fecha_eliminado = null;
                        db.Entry(cl).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                    clien = cl;
                }
                lbDniC.Text = "DNI: " + clien.dni;
                lbApC.Text = "Apellido: " + clien.apellido;
                lbNC.Text = "Nombre: " + clien.nombre;
            }
            catch(Exception e)
            {
                MessageBox.Show("No fue posible crear usuario por defecto "+e);

            }

        }

        public void cust(string pDni)
        {
            clien = db.cliente.FirstOrDefault(u => u.dni == pDni);
            lbDniC.Text = "DNI: " + clien.dni;
            lbApC.Text = "Apellido: " + clien.apellido;
            lbNC.Text = "Nombre: " + clien.nombre;

        }


        private void iconButton3_Click(object sender, EventArgs e)
        {
            searchCustomer sC = new searchCustomer(this);
            sC.ShowDialog();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvPrincipal_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && screenProd)
            {
                if (int.Parse(dgvPrincipal.Rows[e.RowIndex].Cells["Stock"].Value.ToString()) <= 0)
                {
                    dgvPrincipal.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.OrangeRed;
                }
                else
                {
                    dgvPrincipal.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Silver;
                }
            }


        }

        private void dgvPrincipal_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && screenProd)
            {
                if (int.Parse(dgvPrincipal.Rows[e.RowIndex].Cells["Stock"].Value.ToString()) <= 0)
                {
                    dgvPrincipal.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    dgvPrincipal.Rows[e.RowIndex].DefaultCellStyle.BackColor = SystemColors.InactiveCaption;
                }
            }
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
                det.HeaderText = "Detalles";
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
                                fila.CreateCells(dgvSales, venta.id_venta, "$ "+venta.total_venta, client.apellido + " " + client.nombre + ", " + client.dni, usuari.nombre_usuario, venta.fecha,"");
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
            }
        }

        private void dgvSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void showDetails(string pNumVenta)
        {

            int idVenta = int.Parse(pNumVenta);
           dgvDetail.Rows.Clear();
                dgvDetail.Columns.Clear();
                dgvDetail.Columns.Add("Codigo", "Codigo");
                dgvDetail.Columns.Add("Producto", "Producto");
                dgvDetail.Columns.Add("Cantidad", "Cantidad");
                dgvDetail.Columns.Add("Precio", "Precio");
            dgvDetail.Columns.Add("Subtotal", "Subtotal");
            
                try
                {
                    foreach (detalleVenta detalle in db.detalleVenta)
                    {
                        if (detalle.id_venta == int.Parse(pNumVenta))
                        {

                            producto prod = db.producto.First(u => u.id_producto == detalle.id_producto);
                            DataGridViewRow fila = new DataGridViewRow();
                            fila.CreateCells(dgvDetail, prod.codigo, prod.titulo, detalle.cantidad,"$ "+ prod.precio, "$ " + detalle.subtotal);
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            addCustomer custNew=new addCustomer();
            custNew.ShowDialog();
        }

        private void dgvSales_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e != null)
            {

                dgvSales.CurrentRow.Selected = true;
                if (e.ColumnIndex == dgvSales.Columns[5].Index)
                {
                    showDetails(dgvSales.CurrentRow.Cells["Número venta"].Value.ToString());
                }

            }
        }
    }
}

    
