using FontAwesome.Sharp;
using Positive.Presentacion;
using Positive;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Positivee.Presentacion
{
    public partial class Seccion_ventas : Form
    {
        Lista_ventas listado;
        public Seccion_ventas()
        {
            InitializeComponent();
            listado = new Lista_ventas(this);
            listado.cargar_lista();
        }

        private void Seccion_clientes_Load(object sender, EventArgs e)
        {




        }
        private void btlistCustomer_Click(object sender, EventArgs e)
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

        private void Seccion_ventas_Load(object sender, EventArgs e)
        {

        }

        private void btList_Click(object sender, EventArgs e)
        {
            listado.cargar_lista();
            iconSelect((IconButton)sender, listado);
        }

        private void delCustomer_Click(object sender, EventArgs e)
        {

            listado.cargar_accion("delete");
            iconSelect((IconButton)sender, listado);
        }
    }
}
