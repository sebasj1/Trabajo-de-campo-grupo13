using Positive.Presentacion;
using Positive;
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
using Dapper;

namespace Positive.Presentacion
{
    public partial class Login : Form
    {
      
        public Login()
        {

            InitializeComponent();
           
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
            //al menu principal
            Usuario usuario = new Usuario();
            usuario.validar_usuario(tbUsername.Text,tbPassword.Text,this);
            
            // Obtén los valores ingresados por el usuario
            
        }
        

        private void LoginForm_Load(object sender, EventArgs e)
        {
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

