using jbposs.Presentacion;
using jbposs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using jbposs.Datos;

namespace jbposs.Presentacion
{
    public partial class LoginForm : Form
    {
        private static frmMain _principal;

        public LoginForm()
        {
            InitializeComponent();
            //Precargar la conexion a la BD para que el formulario responda rapido
           
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // Obtén los valores ingresados por el usuario
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            try
            {
                using(jbposEntities dbContext = new jbposEntities())
                {
                    var usuarioAutenticado = dbContext.usuario.FirstOrDefault(u => u.nombre_usuario == username && u.pass == password);

                    if (usuarioAutenticado != null)
                    {
                        if (usuarioAutenticado.fecha_eliminado != null)
                        {
                            MessageBox.Show($"Hola {usuarioAutenticado.nombre} {usuarioAutenticado.apellido}, su usuario se encuentra deshabilitado", "Usuario deshabilitado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }


                        this.Hide();


                        // Muestra el formulario principal
                        _principal = new frmMain(usuarioAutenticado, this);

                        _principal.FormClosed += (s, args) => this.Close(); // Cierra la aplicación cuando se cierre MainForm
                        _principal.AutoScaleMode = AutoScaleMode.Dpi;
                        principal.setMainForm(_principal);
                        _principal.Show();
                    }
                    else
                    {
                        MessageBox.Show("Nombre de usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo reallizar la busqueda del usuario "+ e);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            /*frmMain mainForm = new frmMain(usuarioAutenticado);
            mainForm.FormClosed += (s, args) => this.Close(); // Cierra la aplicación cuando se cierre MainForm
            mainForm.Show();*/
        }

        private void buttonExit_MouseMove(object sender, MouseEventArgs e)
        {
            buttonExit.BackColor = System.Drawing.Color.DarkRed;
        }

        private void buttonExit_MouseLeave(object sender, EventArgs e)
        {
            buttonExit.BackColor = System.Drawing.Color.Red;
        }

        private void buttonLogin_MouseMove(object sender, MouseEventArgs e)
        {
            buttonLogin.BackColor = System.Drawing.Color.Blue;
        }

        private void buttonLogin_MouseLeave(object sender, EventArgs e)
        {
            buttonLogin.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

          //  tbUsername.Text = "Juan";
          //  tbPassword.Text = "12345";
        }

        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
          
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
        }

       
        }
    }

