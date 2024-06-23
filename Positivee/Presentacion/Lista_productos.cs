using Dapper;
using Positive.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Positive.Presentacion
{
    public partial class Lista_productos : Form
    {   string action="";
        Seccion_productos _principal;
        List<dynamic> LISTLOAD = null;
        Producto producto_action = new Producto();
        string p_tipo="todos" ;

        public Lista_productos(Seccion_productos p_principal)
        {
            InitializeComponent();
            _principal = p_principal;
        }
        private void Lista_productos_Load_1(object sender, EventArgs e)
        {

            LISTLOAD = producto_action.listar_productos();
            cbRol.Items.Clear();
            Categoria tipo_estado = new Categoria();
            cbRol.DataSource = tipo_estado.lista_categorias();
            cbRol.DisplayMember = "descripcion";
            cbRol.ValueMember = "id_estado"; 
            cbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRol.Refresh(); cbRol.DropDownStyle = ComboBoxStyle.DropDownList;

        }


        public void cargar_lista()
        {
           
            LISTLOAD = producto_action.listar_productos();
            LOADPRODUCTS();


        }
        
          private void btRefresh_Click(object sender, EventArgs e)
        {
            cargar_lista();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_action"></param>
        public void cargar_accion(string p_action)
        {
            switch (p_action)
            {
                case "edit":
                    action = "edit";
                    LABELPRINCIPAL.Text = "Seleccionar producto para editar";
                    break;
                case "delete":
                    action = "delete";
                    LABELPRINCIPAL.Text = "Seleccionar producto para eliminar";
                    break;
                case "restore":
                    action = "restore";
                    LABELPRINCIPAL.Text = "Seleccionar producto para restaurar";
                    break;
                default: LABELPRINCIPAL.Text = "Listado de productos"; break;
            }
            LOADPRODUCTS();


        }
        private void LOADPRODUCTS()
        {

            DATAGRIDCELL.Rows.Clear();
            DATAGRIDCELL.Columns.Clear();
            DATAGRIDCELL.Columns.Add("ID", "ID");
            DATAGRIDCELL.Columns.Add("Titulo", "Titulo");
            DATAGRIDCELL.Columns.Add("Descripción", "Descripción");
            DATAGRIDCELL.Columns.Add("Codigo", "Codigo");
            DATAGRIDCELL.Columns.Add("Precio compra", "Precio compra");
            DATAGRIDCELL.Columns.Add("Precio venta.", "Precio venta.");
            DATAGRIDCELL.Columns.Add("Categoría", "Categoría");
            DATAGRIDCELL.Columns.Add("Estado", "Estado");
            foreach (var ELEMLIST in LISTLOAD)
            {// Cambiar el color de fondo si está eliminado
                
                if (rbCli.Checked)
                {
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(DATAGRIDCELL, ELEMLIST.id_producto, ELEMLIST.titulo, ELEMLIST.descripcion,
                        ELEMLIST.codigo, ELEMLIST.precio_compra, ELEMLIST.precio_venta, ELEMLIST.categoria, ELEMLIST.estado);
                    // Cambiar el color de fondo si está eliminado

                    if (ELEMLIST.estado == "INACTIVO" || ELEMLIST.estado == "inactivo")
                    {
                        fila.DefaultCellStyle.BackColor = Color.Red;
                        fila.DefaultCellStyle.ForeColor = Color.White; // Puedes ajustar el color del texto según sea necesario
                    }
                    DATAGRIDCELL.Rows.Add(fila);
                }
                else if (p_tipo.ToLower() == ELEMLIST.categoria.ToLower())
                {
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(DATAGRIDCELL, ELEMLIST.id_producto, ELEMLIST.titulo, ELEMLIST.descripcion,
                        ELEMLIST.codigo, ELEMLIST.precio_compra, ELEMLIST.precio_venta, ELEMLIST.categoria, ELEMLIST.estado);
                    // Cambiar el color de fondo si está eliminado

                    if (ELEMLIST.estado == "INACTIVO" || ELEMLIST.estado == "inactivo")
                    {
                        fila.DefaultCellStyle.BackColor = Color.Red;
                        fila.DefaultCellStyle.ForeColor = Color.White; // Puedes ajustar el color del texto según sea necesario
                    }
                    DATAGRIDCELL.Rows.Add(fila);

                }
               
            }
            DATAGRIDCELL.Refresh();
        }

        private void DATAGRIDCELL_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (action)
            {
                case "edit":
                    string id = DATAGRIDCELL.CurrentRow.Cells["ID"].Value.ToString();
                    producto_action.seleccion_editar(id,_principal);
                    cargar_lista();
                    break;
                case "delete":
                    string id_del = DATAGRIDCELL.CurrentRow.Cells["ID"].Value.ToString();
                    producto_action.eliminar_producto(id_del);cargar_lista();
                    break;
                case "restore":
                    string id_res = DATAGRIDCELL.CurrentRow.Cells["ID"].Value.ToString();
                    producto_action.restaurar_producto(id_res);cargar_lista();
                    break;

            }
        }

        private void cbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            p_tipo = cbRol.SelectedText.ToString(); LOADPRODUCTS();
           
        }

        private void rbCli_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCli.Checked)
            {
               LOADPRODUCTS();
            }

        }

        private void cbRol_Click(object sender, EventArgs e)
        {
            rbCli.Checked = false;
            cbRol.Enabled = true;
          
            p_tipo = cbRol.Text.ToString();
            
            LOADPRODUCTS();
          
        }

       
    }
}
