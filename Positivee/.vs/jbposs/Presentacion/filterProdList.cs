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
    public partial class filterProdList : Form
    {
        productList proList;
        public filterProdList(productList pList)
        {
            InitializeComponent();
            proList = pList;
        }

        private void filterProdList_Load(object sender, EventArgs e)
        {

        }

        private void btBrowser_Click(object sender, EventArgs e)
        {
            

        }

        private string RBselection()
        {
            if (rbCode.Checked)
            {
                return "Codigo";
            }
            else if (rbTitle.Checked)
            {
                return "Titulo";
            }
            if (rbDescripcion.Checked)
            {
                return "Descripcion";
            }
            
            return "";
        }
        private void filterUserList_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }

        private void tbBrowser_TextChanged(object sender, EventArgs e)
        {
            proList.filter(RBselection(), tbBrowser.Text);
            this.Visible = true;
        }

        private void filterUserList_Load(object sender, EventArgs e)
        {

        }

        private void btBrowser_Click_1(object sender, EventArgs e)
        {
            proList.filter(RBselection(), tbBrowser.Text);
            this.Visible = false;
        }
    }
}
