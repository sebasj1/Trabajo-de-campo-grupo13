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
    public partial class Seccion_clientes : Form
    {
        Lista_clientes listado;
        public Seccion_clientes()
        {
            InitializeComponent();
            listado = new Lista_clientes(this);
            listado.cargar_lista();
        }

        private void Seccion_clientes_Load(object sender, EventArgs e)
        {
            

            

        }
        public IconButton btnActive = null;
        public void iconSelect(IconButton buttonSelected, Form form)
        {
            if (btnActive != null)
            {
                btnActive.BackColor = System.Drawing.SystemColors.ControlLight;
            }

            buttonSelected.BackColor = System.Drawing.Color.LightGray;
            panelUsers.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelUsers.Controls.Add(form);
            form.Show();
            btnActive = buttonSelected;
        }

        private void btaddCustomer_Click(object sender, EventArgs e)
        {
            iconSelect((IconButton)sender,new Nuevo_cliente());
        }

        private void btlistCustomer_Click(object sender, EventArgs e)
        {
            listado.cargar_lista();
            iconSelect((IconButton)sender,listado);

        }

        private void btEditCustomer_Click(object sender, EventArgs e)
        { listado.cargar_accion("edit");
            iconSelect((IconButton)sender, listado);

        }
        public void mostrar_menu_editar(Editar_cliente ed_cli)
        {
            iconSelect(btEditCustomer, ed_cli);
        }
public void recargar_lista(string p_ac )
        {
            listado.cargar_lista();
            iconSelect(btlistCustomer, listado);
        } 
      
        private void delCustomer_Click(object sender, EventArgs e)
        {
            listado.cargar_accion("delete");
            iconSelect((IconButton)sender, listado);
        }

        private void restCustomer_Click(object sender, EventArgs e)
        {
            listado.cargar_accion("restore");
            iconSelect((IconButton)sender, listado);
        }
    }
}
