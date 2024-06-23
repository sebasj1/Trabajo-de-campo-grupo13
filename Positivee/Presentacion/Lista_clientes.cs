using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Positive;
using FontAwesome.Sharp;

namespace Positive.Presentacion
{
    public partial class Lista_clientes : Form
    {
      
          public Lista_clientes(Seccion_clientes p_principal)
        {
            InitializeComponent();
            _principal = p_principal;
        }
        string action="";
        Seccion_clientes _principal;
        List<dynamic> LISTLOAD = null;
        Cliente client_action = new Cliente();
        int p_tipo=0;
        private void Lista_clientes_Load(object sender, EventArgs e)
        {
            LISTLOAD = client_action.listar_clientes();
            cbRol.Items.Clear();
            Estado tipo_estado = new Estado();
            cbRol.DataSource = tipo_estado.lista_estados();
            cbRol.DisplayMember = "descripcion";
            cbRol.ValueMember = "id_estado";
            cbRol.Refresh(); LOAD();
            cbRol.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void cargar_lista()
        {
            LISTLOAD = client_action.listar_clientes();
            DATAGRIDCELL.Refresh();
            LOAD();


        }private void btRefresh_Click(object sender, EventArgs e)
        {
            cargar_lista();
        }
         public void cargar_accion(string p_action)
        {
            switch (p_action)
            {
                case "edit":
                action = "edit";
                LABELPRINCIPAL.Text = "Seleccionar cliente para editar";
                 break;
                case "delete":
                    action = "delete";
                    LABELPRINCIPAL.Text = "Seleccionar cliente para eliminar";
                 break;
                case "restore":
                    action = "restore";
                    LABELPRINCIPAL.Text = "Seleccionar cliente para restaurar";
                    break;
                default:LABELPRINCIPAL.Text = "Listado de clientes";break;
            }

            LOAD();


        } 
        private void LOAD()
        {

            DATAGRIDCELL.Rows.Clear();
            DATAGRIDCELL.Columns.Clear();
            DATAGRIDCELL.Columns.Add("ID", "ID");
            DATAGRIDCELL.Columns.Add("Nombre", "Nombre");
            DATAGRIDCELL.Columns.Add("Apellido", "Apellido");
            DATAGRIDCELL.Columns.Add("Tipo doc.", "Tipo doc.");
            DATAGRIDCELL.Columns.Add("Nro. Documento", "Nro. Documento");
            DATAGRIDCELL.Columns.Add("Teléfono", "Teléfono");
            DATAGRIDCELL.Columns.Add("Email", "Email");
            DATAGRIDCELL.Columns.Add("Estado", "Estado");
            cargar_filas(p_tipo);
                
                
            }
        private void cargar_filas(int p_tipo)
        {
            foreach (var ELEMLIST in LISTLOAD)
            {
                if (p_tipo == 0)
                {
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(DATAGRIDCELL, ELEMLIST.id_cliente, ELEMLIST.nombre, ELEMLIST.apellido,
                        ELEMLIST.tipo_doc, ELEMLIST.numero_documento,
                        ELEMLIST.telefono, ELEMLIST.email, ELEMLIST.estado);
                    // Cambiar el color de fondo si está eliminado

                    if (ELEMLIST.estado == "INACTIVO" || ELEMLIST.estado == "inactivo")
                    {
                        fila.DefaultCellStyle.BackColor = Color.Red;
                        fila.DefaultCellStyle.ForeColor = Color.White; // Puedes ajustar el color del texto según sea necesario
                    }
                    DATAGRIDCELL.Rows.Add(fila);
                }
                if (p_tipo == 1 && ELEMLIST.estado=="ACTIVO")
                {
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(DATAGRIDCELL, ELEMLIST.id_cliente, ELEMLIST.nombre, ELEMLIST.apellido,
                        ELEMLIST.tipo_doc, ELEMLIST.numero_documento,
                        ELEMLIST.telefono, ELEMLIST.email, ELEMLIST.estado);
                    // Cambiar el color de fondo si está eliminado

                 
                    DATAGRIDCELL.Rows.Add(fila);
                }
                if (p_tipo == 2 && ELEMLIST.estado.ToUpper() == "INACTIVO")
                {
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(DATAGRIDCELL, ELEMLIST.id_cliente, ELEMLIST.nombre, ELEMLIST.apellido,
                        ELEMLIST.tipo_doc, ELEMLIST.numero_documento,
                        ELEMLIST.telefono, ELEMLIST.email, ELEMLIST.estado);
                      fila.DefaultCellStyle.BackColor = Color.Red;
                        fila.DefaultCellStyle.ForeColor = Color.White; // Puedes ajustar el color del texto según sea necesario
                   
                    DATAGRIDCELL.Rows.Add(fila);
                }
            }
            DATAGRIDCELL.Refresh();
        }

        private void DATAGRIDCELL_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                switch (action )
                {
                 case  "edit":
                string id = DATAGRIDCELL.CurrentRow.Cells["ID"].Value.ToString();
                    client_action.seleccion_editar(id,_principal); cargar_lista();
                    break;
               case "delete":
                    string id_del = DATAGRIDCELL.CurrentRow.Cells["ID"].Value.ToString();
                    client_action.eliminar_cliente(id_del);
                    cargar_lista();
                    break;
                 case "restore":
                    string id_res = DATAGRIDCELL.CurrentRow.Cells["ID"].Value.ToString();
                    client_action.restaurar_cliente(id_res); cargar_lista();
                    break;

            }
         }

        private void panelUsers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRol.SelectedValue.ToString() == "1")
            {
                p_tipo = 1; LOAD();
            }
            else if (cbRol.SelectedValue.ToString() == "2")
            {
                p_tipo = 2; LOAD();
            }
        }

        private void rbCli_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCli.Checked)
            {
                 p_tipo = 0;LOAD();
            }
           
            
        }

        private void cbRol_Click(object sender, EventArgs e)
        {
            rbCli.Checked = false;
            cbRol.Enabled = true; p_tipo = 1; if (cbRol.SelectedValue.ToString() == "1")
            {
                p_tipo = 1; LOAD();
            }
            else if (cbRol.SelectedValue.ToString() == "2")
            {
                p_tipo = 2; LOAD();
            }

        }
    }
}
