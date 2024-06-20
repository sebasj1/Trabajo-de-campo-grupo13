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
    public partial class editRol : Form
    {
        public editRol()
        {
            InitializeComponent();
        }

        private void editRol_Load(object sender, EventArgs e)
        {

        }

        private void addRol_Click(object sender, EventArgs e)
        {
            addRol ar = new addRol();
            ar.ShowDialog();
        }
    }
}
