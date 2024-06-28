using Dapper;
using Positive;
using Positive.Presentacion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

//Parte del login

public static class Control{
     public static Login login;
     private static Usuario usuarioLogueado;
     
     private static Menu_principal _principal;
     private static Pantalla_de_venta screen;
    

//selecicionaa el icono
 
 public static void crear_menu_principal(){
         _principal = new Menu_principal();
        _principal.FormClosed += (s, args) => login.Close(); // Cierra la aplicación cuando se cierre MainForm
        _principal.AutoScaleMode = AutoScaleMode.Dpi;
             //principal.setMainForm(_principal);
         _principal.Show();
         crear_pantalla_venta();
 }
    
    
    
    public static void cargar_usuario(Usuario p_usuarioAutenticado ){
        usuarioLogueado = p_usuarioAutenticado;
 }
    public static void cargar_login(Login p_login ){
        login=p_login;
 }

    public static void cargar_menu_principal(Menu_principal p_login)
    {
        _principal = p_login;
    }


    private static void crear_pantalla_venta()
        { screen = new Pantalla_de_venta(_principal, usuarioLogueado);
                        
        }
    public static ToolStripItemCollection getMenuItems()
         {
             return _principal.menuStrip2.Items;
         }
     public static void cargar_iconos_menu()
        {
        Permiso permisos = new Permiso();
        IEnumerable<string> Permissions = permisos.obtener_permisos(usuarioLogueado);
            //iconSelect((IconMenuItem)_principal.Usuarios, new Seccion_usuarios());
            _principal.AutoScaleMode = AutoScaleMode.Dpi;
            _principal.cargar_datos_usuario(usuarioLogueado.nombre_usuario.ToString());
          
            foreach (ToolStripItem item in getMenuItems())
            {

                item.Enabled = false;
                item.Visible = false;
                foreach (string permiso in Permissions)
                {
                    if (permiso.ToString() == item.Name)
                    {
                        item.Enabled = true;
                        item.Visible = true;
                    }
                }

            }

        }

   


public static void pantalla_venta(){
    _principal.Hide();
     screen.Show();
}
    public static void pantalla_principal()
{
            _principal.Show();
            screen.Hide();
}

     public static void cerrar_todo(){
            DialogResult resul = MessageBox.Show("¿Desea cerrar la aplicación?", "Cerrar ventana", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
   if (resul == DialogResult.Yes)
   {
       screen.Dispose();
       _principal.Dispose();
   }
        }


    

} 