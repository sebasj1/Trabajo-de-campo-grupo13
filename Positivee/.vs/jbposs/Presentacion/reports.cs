using FontAwesome.Sharp;
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
    public partial class reports : Form
    {
        public IconButton btnActive = null;
        public reports()
        {
            InitializeComponent();
        }
        public void iconSelect(IconButton buttonSelected, Form form)
        {
            if (btnActive != null)
            {
                btnActive.BackColor = System.Drawing.SystemColors.ControlLight;
            }

            buttonSelected.BackColor = System.Drawing.Color.LightGray;
            panelReports.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelReports.Controls.Add(form);
            form.Show();
            btnActive = buttonSelected;
        }
        private void btRS_Click(object sender, EventArgs e)
        {
            iconSelect((IconButton)sender, new chartSales());
        }

        private void btRU_Click(object sender, EventArgs e)
        {
            iconSelect((IconButton)sender, new chartRevenue());
        }

        private void panelReports_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btRP_Click(object sender, EventArgs e)
        {

            iconSelect((IconButton)sender, new chartProducts());
        }

        private void btRC_Click(object sender, EventArgs e)
        {
            iconSelect((IconButton)sender, new chartSalesByClient());
        }
    }
}
