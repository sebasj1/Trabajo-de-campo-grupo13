using Positive;
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
    public partial class Editar_cliente : Form
    {
        public Editar_cliente()
        {
            InitializeComponent();
        }
        int c_id_cliente;
        int c_id_persona;
        int c_id_contacto;
        private void btAddCust_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Se guardara el cliente", "Éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {Cliente cliente = new Cliente();
            cliente.INSERTCONTROLEDIT(cbStatus.SelectedIndex + 1,
                TBNombre.Text.Trim(), textboxApellido.Text.Trim(), tbDNI.Text.Trim(), cbTDoc.SelectedIndex + 1, tbTel.Text.Trim(),
             tbEmail.Text.Trim(),c_id_cliente,c_id_persona,c_id_contacto,this);
               
               

            }
            
            
        }

        public void exito()
        {
            MessageBox.Show("Se ha guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void fallo()
        {
            MessageBox.Show("No se pudo realizar la actualización.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void dni_no_encontrado()
        {
            MessageBox.Show("No se pudo encontrar el dni.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void cargar_datos(string p_nombre, string apellido, int id_tipo_documento, string numero_documento,
                    string p_telefono, string p_email, int p_id_cliente, int p_estado, int p_id_persona, int p_id_contacto)
        {
            c_id_cliente = p_id_cliente;
            c_id_persona = p_id_persona;
            c_id_contacto = p_id_contacto;
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
            cbStatus.SelectedIndex = p_estado - 1;
                TBNombre.Text = p_nombre;
            textboxApellido.Text = apellido;
            tbDNI.Text = numero_documento;
            cbTDoc.SelectedIndex = id_tipo_documento - 1;
            tbTel.Text = p_telefono;
            tbEmail.Text = p_email;
        } 
        private void Editar_cliente_Load(object sender, EventArgs e)
        {
           

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
