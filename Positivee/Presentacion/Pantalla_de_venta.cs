using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Dapper;
using FontAwesome.Sharp;
using MagnaDB.MySQL;
using Mysqlx.Datatypes;
using MySqlX.XDevAPI;
using Positive;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Positive.Presentacion
{
    public partial class Pantalla_de_venta : Form
    {
        private static Menu_principal frmMainPrincipal;
        private Usuario usuarioLog;
        //private Lista_productos prodList = new Lista_productos();
        private List<Medio_pago> listReg = new List<Medio_pago>();

        private List<Medio_pago> medios = new List<Medio_pago>();
        private bool scV = true;
        public decimal total = 0;
        private Venta venta;
        private bool screenProd = true;
        private int id_cliente;
        private string nombre_cliente;
        private string apellido_cliente;
        private string numero_documento;
        private List<dynamic> lista_prod = new List<dynamic>();
        private List<dynamic> lista_prod_carrito;
        private Detalle_venta detalle_ventas = new Detalle_venta();
        private Cuadro_cobrar cob;


        public Pantalla_de_venta(Menu_principal pfrmMain, Usuario pUser)
        {
            InitializeComponent();
            usuarioLog = pUser;
            frmMainPrincipal = pfrmMain;
            //frmMainPrincipal.screenSaleShow(pfrmMain, this);

        }


        private void screenSale_Load(object sender, EventArgs e)
        {
            Producto producto_pantalla = new Producto();
            lista_prod = producto_pantalla.cargar_productos_venta();
            timer1.Enabled = true;
            lbTotal.Text = total.ToString();
            this.AutoScaleMode = AutoScaleMode.Dpi;
            dgvDetail.AllowUserToAddRows = false;
            dgvSales.AllowUserToAddRows = false;
            dgvMedio.AllowUserToAddRows = false;
            labelUsuario.Text = "Usuario: " + usuarioLog.nombre_usuario.ToString();

            //clientDefect();



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
                Control.pantalla_principal();
            }
        }

        private void screenSale_FormClosing_1(object sender, FormClosingEventArgs e)
        {

            DialogResult resul = MessageBox.Show("¿Desea cerrar todas las ventanas?", "Cerrar ventanas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resul == DialogResult.Yes)
            {
                Control.cerrar_todo(e);
            }
            else
            {
                e.Cancel = true;
            }
        }


        public void registrar_venta(List<dynamic> lista_de_medios_de_pago)
        {
            Venta venta = new Venta();
            //Venta.registrar_la_venta(usuarioLog.id_usuario,id_cliente,total);
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
                pantallaVenta(lista_prod_carrito);

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
            dgvPrincipal.Columns.Add("ID", "ID");
            dgvPrincipal.Columns.Add("Titulo", "Titulo");
            dgvPrincipal.Columns.Add("Codigo", "Codigo");
            dgvPrincipal.Columns.Add("Precio", "Precio");
            dgvPrincipal.Columns.Add("Stock", "Stock");
            dgvPrincipal.Columns["ID"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvPrincipal.Columns["Titulo"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvPrincipal.Columns["Codigo"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvPrincipal.Columns["Precio"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvPrincipal.Columns["Stock"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvPrincipal.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPrincipal.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPrincipal.Columns["Titulo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPrincipal.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPrincipal.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPrincipal.Columns["Stock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPrincipal.RowsDefaultCellStyle.BackColor = SystemColors.InactiveCaption;
            dgvPrincipal.RowsDefaultCellStyle.ForeColor = Color.Black;
            if (lista_prod != null)
            {
                foreach (dynamic product in lista_prod)
                {
                    if (pText.IsNumberType() && product.codigo.Contains(pText.Trim()) || product.titulo.ToLower().Contains(pText.ToLower().Trim()))
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(dgvPrincipal, product.id_producto, product.titulo, product.codigo, product.precio_venta, product.stock);
                        // Cambiar el color de fondo si está eliminado
                        if (product.stock <= 0)
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









        public void pantallaVenta(List<dynamic> p_listado_carrito)
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
            dgvPrincipal.Columns.Add("ID", "ID");
            dgvPrincipal.Columns.Add("Titulo", "Titulo");
            dgvPrincipal.Columns.Add(min);
            dgvPrincipal.Columns.Add("Cantidad", "Cantidad");
            dgvPrincipal.Columns.Add(max);
            dgvPrincipal.Columns.Add("Precio Unitario", "Precio Unitario");
            dgvPrincipal.Columns.Add("Subtotal", "Subtotal");
            dgvPrincipal.Columns.Add(del);
            dgvPrincipal.Columns["ID"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvPrincipal.Columns["Titulo"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvPrincipal.Columns["Cantidad"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvPrincipal.Columns["Precio Unitario"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvPrincipal.Columns["Subtotal"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvPrincipal.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPrincipal.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPrincipal.Columns["Titulo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPrincipal.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPrincipal.Columns["Precio Unitario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPrincipal.Columns["Subtotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPrincipal.Columns[2].Width = 50;
            dgvPrincipal.Columns[4].Width = 50;
            dgvPrincipal.Columns[7].Width = 80;

            total = 0;
            dgvPrincipal.RowsDefaultCellStyle.BackColor = SystemColors.Highlight;
            dgvPrincipal.RowsDefaultCellStyle.ForeColor = SystemColors.HighlightText;
            dgvPrincipal.Columns["Cantidad"].ReadOnly = false;
            if (p_listado_carrito != null)
            {
                if (p_listado_carrito.Count() > 0)
                {
                    {
                        foreach (dynamic prodCar in p_listado_carrito)
                        {


                            total += prodCar.subtotal;
                            DataGridViewRow fila = new DataGridViewRow();
                            fila.CreateCells(dgvPrincipal, prodCar.id_producto, prodCar.titulo, "", prodCar.cantidad, "", "$ " + prodCar.precio, "$ " + prodCar.subtotal, "");

                            fila.Height = 70;
                            if (prodCar.cantidad > prodCar.stock)
                            {
                                fila.DefaultCellStyle.BackColor = Color.Red;
                                fila.DefaultCellStyle.SelectionBackColor = Color.OrangeRed;
                                fila.DefaultCellStyle.ForeColor = Color.White; // Puedes ajustar el color del texto según sea necesario
                            }
                            dgvPrincipal.Rows.Add(fila); dgvPrincipal.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;


                            dgvPrincipal.Rows[0].Selected = false;


                        }
                    }

                }
                else { total = 0; }
            } lbTotal.Text = total.ToString();
        }

        private void dgvPrincipal_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e != null&&e.RowIndex!=-1)
            {

                if (!scV)
                {
                    dgvPrincipal.CurrentRow.Selected = true;
                    string idd = dgvPrincipal.CurrentRow.Cells["ID"].Value.ToString();
                    string ti = dgvPrincipal.CurrentRow.Cells["Titulo"].Value.ToString();
                    string pre = dgvPrincipal.CurrentRow.Cells["Precio"].Value.ToString();
                    string st = dgvPrincipal.CurrentRow.Cells["Stock"].Value.ToString();

                    lista_prod_carrito = detalle_ventas.cargar_carrito(idd, ti, pre, st);

                    pantallaVenta(lista_prod_carrito);
                    tbBrow.Text = "";
                }
                else if (e.ColumnIndex == dgvPrincipal.Columns[2].Index && scV)
                {
                    lista_prod_carrito = detalle_ventas.restProd(dgvPrincipal.CurrentRow.Index);
                    pantallaVenta(lista_prod_carrito);
                }
                else if (e.ColumnIndex == dgvPrincipal.Columns[4].Index && scV)
                {
                    lista_prod_carrito = detalle_ventas.sumProd(dgvPrincipal.CurrentRow.Index);
                    pantallaVenta(lista_prod_carrito);
                }
                else if (e.ColumnIndex == dgvPrincipal.Columns[7].Index && scV)
                {

                    DialogResult resultado = MessageBox.Show("¿Eliminar de la lista?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        lista_prod_carrito = detalle_ventas.delProd(dgvPrincipal.CurrentRow.Index);
                        pantallaVenta(lista_prod_carrito);
                    }
                }


            }
        }
        private void actualizar_Click_Click(object sender, EventArgs e)
        {
            Producto producto_pantalla = new Producto();
            lista_prod = producto_pantalla.cargar_productos_venta();
        }


      
        private void btOk_Click_1(object sender, EventArgs e)
        {
            if (total != 0)
            {

                cob = new Cuadro_cobrar(this);
                cob.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se han cargado productos");
            }

        }

            /* 
             private void btOk_Click(object sender, EventArgs e)
             {
                 CRUD manejador = new CRUD();
                 if (total == 0)
                 {
                     registrar_venta();
                     showSale comprobante = new showSale();
                     this.Dispose();
                 }
                 else
                 {
                     MessageBox.Show("No se alcanzo el monto total", "Pago incompleto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 }
             }

            private void INSERTCONTROL()
            {

                try
                {


                    if (this.ValidateChildren(ValidationConstraints.Enabled) && (!FINDCOD(tbCodeProd.Text)||tbCodeProd.Text==""))
                    {

                        producto.codigo = tbCodeProd.Text.Trim();
                        producto.titulo = tbTitleProd.Text.Trim();
                        producto.descripcion = tbDescProd.Text;
                        producto.id_categoria = cbCategorie.SelectedIndex+1;
                        producto.id_estado = cbStatus.SelectedIndex+1;
                        producto.precio_compra = decimal.Parse( tbPriceProd.Text);
                        producto.precio_venta = decimal.Parse(tbPrecV.Text); 
                        producto.stock = int.Parse(tbStockProd.Text.Trim());


                        DialogResult resp = MessageBox.Show("Se guardara el producto", "Éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resp == DialogResult.Yes)
                        {
                            INSERTELEM();
                            MessageBox.Show("Este producto se ha guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }



                catch (Exception ex)
                {

                    MessageBox.Show("Ha ocurrido un error." + ex, "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }*/
            /*
            private int registrar_venta() {
                using (var db = new MySqlConnector.MySqlConnection(_connectionString))
                {
                    var queryAdd = db.QueryFirst(
                         sql: "add_sale",
                                       param: new
                                       {
                                           @p_monto_total = total,
                                           @p_id_cliente = id_cliente,
                                           @p_id_usuario = usuarioLog.id_usuario,

                                       },
                                       commandType: CommandType.StoredProcedure);

                    return queryAdd.id_venta;
                }
            }



        private void registrar_venta(List<Venta_medio_pago> v, int p){
            using (var db = new MySqlConnector.MySqlConnection(_connectionString))
            {
                foreach (Venta_medio_pago v in listReg)
                {
                    var queryAdd = db.ExecuteReader(
                         sql: "add_sale_payment",
                                       param: new
                                       {
                                           @p_monto = v.monto,
                                           @p_id_medio_pago = v.id_medio_pago,
                                           @p_id_venta = v.id_venta,

                                       },
                                       commandType: CommandType.StoredProcedure);


                }
            } 
        }

    private registrar_medio_pago(){
        int id_venta=registrar_venta();

        registrar_venta_medio_pago(lista_venta_medio_pago,id_venta);

    }
     private void INSERTELEM()
            {

                using (var db = new MySqlConnector.MySqlConnection(_connectionString))
                {

                    var queryAdd = db.ExecuteReader(
                                       sql: "add_product",
                                       param: new
                                       {
                                           @p_titulo = producto.titulo,
                                           p_descripcion = producto.descripcion,
                                           p_codigo = producto.codigo,
                                           p_precio_compra = producto.precio_venta,
                                           p_precio_venta = producto.precio_venta,
                                           p_id_categoria = producto.id_categoria,
                                           p_id_estado = producto.id_estado,

                                       },
                                       commandType: CommandType.StoredProcedure);
                }
                }
     public void registSale()
             {
                 venta.monto_total = total;
                 venta.id_cliente = cliente.id_cliente;
                 venta.id_usuario=
                 try
                 {
                     using (var db = new MySqlConnector.MySqlConnection(_connectionString))
                     {
                         int addventa = db.ExecuteScalar<int>(
                                   sql: "add_sale",
                                   param: new { @p_monto_total = venta },
                                   commandType: CommandType.StoredProcedure);
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
                 catch (Exception e)
                 {
                     MessageBox.Show("No fue posible guardar la venta " + e);
                 }
             }
            
        }

        private bool buscar_cliente(string p_dni)
        { bool ok = false;
            
                try {
                    using (var db = new MySqlConnector.MySqlConnection(_connectionString))
                    {
                        var PROD = db.QueryFirst(
                                  sql: "search_client_dni",
                                   param: new { @p_dni = p_dni },
                                   commandType: CommandType.StoredProcedure
                        );
                        id_cliente = PROD.id_cliente;
                        lbNombre.Text = PROD.nombre;
                        lbApellido.Text =  PROD.apellido;
                        numero_documento = PROD.numero_documento;
                        ok = true;
                        if (PROD == null)
                        {
                            MessageBox.Show("No se encontro cliente ");
                        } } }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo cargar " + ex);
                }
                return ok;
            }
///Por ahora solo busca ya registrados
        
 
        private void clientDefect()
        {
            if (!buscar_cliente("00000000")) {

                INSERTCLIENTDEFECT();
            } }


        private void iconButton3_Click(object sender, EventArgs e)
        {
            if(!buscar_cliente(tbCliente.Text)){
		INSERTCLIENTDEFECT();
        }}

    private void INSERTCLIENTDEFECT()
        {

            using (var db = new MySqlConnector.MySqlConnection(_connectionString))
            {

                var queryAdd = db.ExecuteReader(
                                   sql: "add_client",
                                   param: new
                                   {
                                      @p_telefono= "null",
                                       @p_email= "null",
                                       @p_nombre= "EVENTUAL",
                                       @p_apellido= "",
                                       @p_tipo_doc= 1,
                                       @p_numero_documento= 0000000,
                                       @p_estado= 1,
                                      
                                   },
                                   commandType: CommandType.StoredProcedure);

            }
        }
        private int id_venta_registrada()
        {
            int id =0;
            using (var db = new MySqlConnector.MySqlConnection(_connectionString))
            {

                var queryAdd = db.QueryFirst(
                                   sql: "add_sale",
                                   param: new
                                   {
                                       @p_monto_total = total,
                                       @p_id_usuario = usuarioLog.id_usuario,
                                       @p_id_cliente = id_cliente
                                   },
                                   commandType: CommandType.StoredProcedure);
                
                id = int.Parse(queryAdd.id_venta.ToString()); 
            }
            return id;
        }

        public void registrar_venta(List<Venta_medio_pago> p_list)
        {
            bool ok = false;
            try
                {
                    int id_venta_detalle = id_venta_registrada(); MessageBox.Show(id_venta_detalle.ToString());
                using (var db = new MySqlConnector.MySqlConnection(_connectionString))
                {
                   

                    foreach (Venta_medio_pago ven in p_list)
                    {
                        var registra_medios_de_pago = db.Execute(
                                       sql: "add_sale_payment",
                                       param: new
                                       {
                                           @p_monto = ven.monto,
                                           @p_id_medio_pago = ven.id_medio_pago,
                                           @p_id_venta = id_venta_detalle
                                       },
                                       commandType: CommandType.StoredProcedure);
                    }
                    
                    foreach (Detalle_venta det in carrito)
                    {
                        var registra_productos = db.Execute(
                                       sql: "add_sale_detail",
                                       param: new
                                       {
                                           @p_id_producto = det.id_producto,
                                           @p_cantidad = det.cantidad,
                                           @p_id_venta = id_venta_detalle,
                                           @p_subtotal = det.subtotal
                                       },
                                       commandType: CommandType.StoredProcedure);
                    }
                    cob.Dispose();
                    reset();

                }

            }

                
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo cargar " + ex);
                }

            }
        private void reset()
        {
            carrito.Clear();
            total = 0;
            dgvPrincipal.Columns.Clear();
            dgvPrincipal.Rows.Clear();
            clientDefect();
            lbTotal.Text = total.ToString();


        }
        /*



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
}*/
        
    }
}

    
