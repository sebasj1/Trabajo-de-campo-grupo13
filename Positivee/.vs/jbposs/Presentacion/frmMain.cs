using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using FontAwesome.Sharp;
using jbposs.Presentacion;
using jbposs.Datos;
using JBPOS.Presentacion;

namespace jbposs.Presentacion
{
    public partial class frmMain : Form
    {
        private static IconMenuItem menuActivo = null;
        private static Form formActivo = null; 
        private usuario usuarioLogueado;
        private screenSale screen;
        public LoginForm log;

        public frmMain(usuario usrLogueado)  
        {
            InitializeComponent();
            usuarioLogueado = usrLogueado;
        }
        public frmMain(usuario usrLogueado,LoginForm pLog)
        {
            InitializeComponent();
            usuarioLogueado = usrLogueado;
            log = pLog;
        }
        private void iconSelect(IconMenuItem menuSelected,Form form)
        {
            
            if (menuActivo != null)
            {
                menuActivo.BackColor = System.Drawing.Color.DeepSkyBlue;
            }
            menuSelected.BackColor= System.Drawing.Color.White;
            menuActivo = menuSelected;
            if(formActivo!=null)
            {
                formActivo.Close();
            }
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.Show();
            formActivo = form;
        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            iconSelect((IconMenuItem) sender, new frmBackup());
        }

        public ToolStripItemCollection getMenuItems()
        {
            return menuStrip2.Items;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            iconSelect((IconMenuItem)iconMenuUsers  , new frmUsers());
            this.AutoScaleMode = AutoScaleMode.Dpi;
            labelUsuario.Text = "Usuario: " + usuarioLogueado.nombre.ToString() + " " + usuarioLogueado.apellido.ToString();
            screen = new screenSale(this, usuarioLogueado);
            foreach ( ToolStripItem item in getMenuItems())
            {
                //TODO hacer mas eficiente
                item.Enabled = false;
                item.Visible = false;
                usuarioLogueado.rol.permiso.ToList().ForEach(permiso =>
                { 
                    if(permiso.nombreMenu==item.Name)
                    {
                        item.Enabled = true;
                        item.Visible = true;
                    }
                });
            
             }
           
            
        }

        private void frmMain_Click(object sender, EventArgs e)
        {
            
        }

        private void iconMenuItem6_Click(object sender, EventArgs e)
        {
            iconSelect((IconMenuItem)sender, new frmUsers());
        }

        private void iconMenuItem5_Click(object sender, EventArgs e)
        {
            iconSelect((IconMenuItem)sender, new frmSales());
        }

        private void iconMenuProducts_Click(object sender, EventArgs e)
        {
           iconSelect((IconMenuItem)sender, new frmProducts());
        }
        private void bBackupFileDialog_Click(object sender, EventArgs e)
        {
           // iconSelect((IconMenuItem)sender, new AddUser());
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss");
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void iconCustomers_Click(object sender, EventArgs e)
        {
             iconSelect((IconMenuItem)sender, new frmCustomers());
        }


        private void iconMenuItem3_Click_1(object sender, EventArgs e)
        {
            iconSelect((IconMenuItem)sender, new reports());
        }

        private void iconMenuItem7_Click(object sender, EventArgs e)
        {
           DialogResult resul= MessageBox.Show("¿Está seguro de cerrar sesión?", "Cerrar sesión", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resul == DialogResult.OK)
            {
               principal.closeSession(this);
            }
        }
        private void iconSelect2(IconMenuItem menuSelected, Form form)
        {

        }

        private void iconVenta_Click(object sender, EventArgs e)
        {
            screen.refreshDB();
            this.Hide();
            screen.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resul = MessageBox.Show("¿Desea cerrar la aplicación?", "Cerrar ventana", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resul == DialogResult.Yes)
            {
                screen.Dispose();
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void labelUsuario_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void frmMain_HelpButtonClicked(object sender, CancelEventArgs e)
        {

        }
    }

}
