using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using FontAwesome.Sharp;

namespace Positive.Presentacion
{
    public partial class Menu_principal : Form
    {
        
       
        
        // private Pantalla_de_venta screen;
        
        // public Login log;
       
        // private Usuario usuarioLogueado;
        
       
        public Menu_principal()
        {
            InitializeComponent();
        }

        public void cargar_datos_usuario(string p_usuarioLogueado){
            labelUsuario.Text = "Usuario: " + p_usuarioLogueado;
        }
            
        /*
        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            iconSelect((IconMenuItem) sender, new frmBackup());
        }

        */
        // public ToolStripItemCollection getMenuItems()
        // {
        //     return menuStrip2.Items;
        // }
        


        private void frmMain_Load(object sender, EventArgs e)
         {
            timer1.Enabled = true;
            Control.cargar_iconos_menu();
        }
        //     timer1.Enabled = true;
        //     iconSelect((IconMenuItem)Usuarios, new Seccion_usuarios());
        //     this.AutoScaleMode = AutoScaleMode.Dpi;
        //     labelUsuario.Text = "Usuario: " + usuarioLogueado.nombre_usuario.ToString();
        //     screen = new Pantalla_de_venta(this, usuarioLogueado);
        //     IEnumerable<string> Permissions;
        //     using (var db = new MySqlConnector.MySqlConnection(_connectionString))
        //     {
        //         string _connectionString = "Server=mysql-proyectois2.alwaysdata.net;Database=proyectois2_puntoventa;User Id=362639;Password=Pollito1q;";

        //         Permissions = db.Query<string>(
        //                   sql: "user_permissions",
        //                   param: new { p_rol = usuarioLogueado.id_rol },
        //                   commandType: CommandType.StoredProcedure);
        //     }
        //     foreach (ToolStripItem item in getMenuItems())
        //     {

        //         item.Enabled = false;
        //         item.Visible = false;
        //         foreach (string permiso in Permissions)
        //         {
        //             if (permiso.ToString() == item.Name)
        //             {
        //                 item.Enabled = true;
        //                 item.Visible = true;
        //             }
        //         }

        //     }

        // }

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
            Control.iconSelect((IconMenuItem)sender, new Seccion_productos());
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
/*

private void labelUsuario_Click(object sender, EventArgs e)
{

}

private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
{

}

private void frmMain_HelpButtonClicked(object sender, CancelEventArgs e)
{

}*/
private void Cuadro_venta_Click(object sender, EventArgs e)
{
    Control.pantalla_venta();
           
   }

 

        private void Usuarios_Click(object sender, EventArgs e)
        {

           Control.iconSelect((IconMenuItem)sender, new Seccion_usuarios());
        }
    }

}
