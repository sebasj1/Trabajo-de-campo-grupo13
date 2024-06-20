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
     private static Form formActivo = null;
     private static IconMenuItem menuActivo = null;
     private static Menu_principal _principal;
     private static Pantalla_de_venta screen;
    private static string _connectionString = Conexion.get_string(); 

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

    public static void iconSelect(IconMenuItem menuSelected, Form form)
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
            _principal.panel1.Controls.Add(form);
            form.Show();
            formActivo = form;
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
            
            iconSelect((IconMenuItem)_principal.Usuarios, new Seccion_usuarios());
            _principal.AutoScaleMode = AutoScaleMode.Dpi;
            _principal.cargar_datos_usuario(usuarioLogueado.nombre_usuario.ToString());
           IEnumerable<string> Permissions;
            using (var db = new MySqlConnector.MySqlConnection(_connectionString))
            {
                
                Permissions = db.Query<string>(
                          sql: "user_permissions",
                          param: new { p_rol = usuarioLogueado.id_rol },
                          commandType: CommandType.StoredProcedure);
            }
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

     public static void cerrar_todo(FormClosingEventArgs e){
            DialogResult resul = MessageBox.Show("¿Desea cerrar la aplicación?", "Cerrar ventana", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
   if (resul == DialogResult.Yes)
   {
       screen.Dispose();
       _principal.Dispose();
   }
   else

   {
       e.Cancel = true;
   }
        }

} 