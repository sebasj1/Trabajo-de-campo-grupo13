using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using FontAwesome.Sharp;

namespace Positive.Presentacion
{
    public partial class Menu_principal : Form
    {
        private static Form formActivo = null;
        private static IconMenuItem menuActivo = null;
        public Menu_principal()
        {
            InitializeComponent();
            Control.cargar_menu_principal(this);
        }
        public  void iconSelect(IconMenuItem menuSelected, Form form)
        {
            if (menuActivo != null)
            {
                menuActivo.BackColor = System.Drawing.Color.DeepSkyBlue;
            }
            menuSelected.BackColor = System.Drawing.Color.White;
            menuActivo = menuSelected;
            if (formActivo != null)
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

        public void cargar_datos_usuario(string p_usuarioLogueado){
            labelUsuario.Text = "Usuario: " + p_usuarioLogueado;
        }

         private void Usuarios_Click(object sender, EventArgs e)
        {
           iconSelect((IconMenuItem)sender, new Seccion_usuarios());
        }    
    
        private void frmMain_Load(object sender, EventArgs e)
         {
            timer1.Enabled = true;
           //cargar_iconos_menu();
        }
      
     

        private void frmMain_Click(object sender, EventArgs e)
        {
            
        }
        
        private void iconMenuItem6_Click(object sender, EventArgs e)
        {
        }
        /*
        private void iconMenuItem5_Click(object sender, EventArgs e)
        {
            iconSelect((IconMenuItem)sender, new frmSales());
        }

       
        private void bBackupFileDialog_Click(object sender, EventArgs e)
        {
           // iconSelect((IconMenuItem)sender, new AddUser());
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }*/

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss");
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void iconMenuProducts_Click_1(object sender, EventArgs e)
        {
            iconSelect((IconMenuItem)sender, new Seccion_productos());
        }
        /*
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
*/

private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
{
   Control.cerrar_todo(e);
}

private void Cuadro_venta_Click(object sender, EventArgs e)
{
    Control.pantalla_venta();
           
   }

        private void Clientes_Click(object sender, EventArgs e)
        {
            iconSelect((IconMenuItem)sender, new Seccion_clientes());
        }
    }

}
