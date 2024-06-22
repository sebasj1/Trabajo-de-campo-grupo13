using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Positive.Presentacion
{
    public partial class Nuevo_cliente : Form
    {
        public Nuevo_cliente()
        {
            InitializeComponent();
        }

       Cliente cliente = new Cliente();

        private void Nuevo_cliente_Load(object sender, EventArgs e)
        {
            cbTDoc.Items.Clear();
            Tipo_documento tipo_doc = new Tipo_documento();
            cbTDoc.DataSource = tipo_doc.lista_tipo_doc();
            cbTDoc.DisplayMember = "descripcion";
            cbTDoc.ValueMember = "id_tipo_documento";
            cbTDoc.Refresh();

            cbStatus.Items.Clear();
            Estado tipo_estado = new Estado();
            cbStatus.DataSource = tipo_estado.lista_estados();
            cbStatus.DisplayMember = "descripcion";
            cbStatus.ValueMember = "id_estado";
            cbStatus.Refresh();
        }

        private void btAddUser_Click(object sender, EventArgs e)
        {
            
            cliente.INSERTCONTROL(cbStatus.SelectedIndex + 1,
                TBNombre.Text.Trim(), textboxApellido.Text.Trim(), tbDNI.Text.Trim(), cbTDoc.SelectedIndex + 1, tbTel.Text.Trim(),
             tbEmail.Text.Trim(), this);
        }

        public void confirmacion()
        {
           
            clean();
        }
        public void negacion()
        {
            MessageBox.Show("Este cliente ya se ha registrado anteriormente.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        








        private void btAdd_MouseMove(object sender, MouseEventArgs e)
        {
            btAddCust.BackColor = System.Drawing.Color.FromArgb(37, 88, 175);
        }

        private void btAdd_MouseLeave(object sender, EventArgs e)
        {
            btAddCust.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void btClean_MouseMove(object sender, MouseEventArgs e)
        {
            btClean.BackColor = System.Drawing.Color.FromArgb(215, 115, 38);
        }

        private void btClean_MouseLeave(object sender, EventArgs e)
        {
            btClean.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
        }
        private void TBNombre_Validating(object sender, CancelEventArgs e)
        {
            if (TBNombre.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(TBNombre, "Ingresar Nombre");
            }
        }

        private void TBNombre_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(TBNombre, "");
        }

        private void textboxApellido_Validating(object sender, CancelEventArgs e)
        {
            if (textboxApellido.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(textboxApellido, "Ingresar Apellido");
            }
        }

        private void textboxApellido_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textboxApellido, "");
        }

        private void tbDNI_Validating(object sender, CancelEventArgs e)
        {

            if (tbDNI.Text == "" || !int.TryParse(tbDNI.Text.Trim(), out _) || !(tbDNI.Text.Trim().Length > 5 && tbDNI.Text.Trim().Length < 10))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbDNI, "Ingresar DNI(Solo números)");

            }

        }
        private void tbDNI_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbDNI, "");
        }
        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (tbEmail.Text != "")
            {
                if ((!(tbEmail.Text.Contains("@") && tbEmail.Text.Contains("."))))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbEmail, "Ingresar Email");
                }
            }
        }

        private void tbEmail_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbEmail, "");
        }


        private void tbTel_Validating(object sender, CancelEventArgs e)
        {
            if (tbTel.Text != "" && !float.TryParse(tbTel.Text, out _))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbTel, "Ingresar Telefono(Solo números)");
            }
        }

        private void tbTel_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbTel, "");
        }

        private void btClean_Click(object sender, EventArgs e)
        {

            clean();
        }
        private void clean()
        {
            TBNombre.Clear();
            textboxApellido.Clear();
            tbDNI.Clear();
            tbEmail.Clear();
            tbTel.Clear();
          
        }

    }
}
