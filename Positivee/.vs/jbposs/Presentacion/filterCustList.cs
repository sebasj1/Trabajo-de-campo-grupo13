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
    public partial class filterCustList : Form
    {
        customersList userList1;
        public filterCustList(customersList pForm)
        {
            InitializeComponent();
            userList1 = pForm;
        }

        private void filterCustList_Load(object sender, EventArgs e)
        {

        }
        private void btBrowser_Click(object sender, EventArgs e)
        {
            userList1.filter(RBselection(), tbBrowser.Text);
            this.Visible = false;

        }

        private string RBselection()
        {
            string el = "DNI";
            if (rbDni.Checked)
            {
                el = "DNI";
            }
           
            else if (rbSurname.Checked)
            {
                el = "Apellido";
            }
            else if (rbName.Checked)
            {
                el = "Nombre";
            }
            return el;
        }
        private void filterUserList_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }

        private void tbBrowser_TextChanged(object sender, EventArgs e)
        {
            userList1.filter(RBselection(), tbBrowser.Text);
            this.Visible = true;
        }

        private void filterUserList_Load(object sender, EventArgs e)
        {

        }
    }
}

