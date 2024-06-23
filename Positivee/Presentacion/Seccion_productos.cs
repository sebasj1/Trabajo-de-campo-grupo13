using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Positive.Presentacion;
using Positivee.Presentacion;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Positive.Presentacion
{
    public partial class Seccion_productos : Form
    {

        Lista_productos lista = null;
        public Seccion_productos()
        {
            InitializeComponent();
            lista = new Lista_productos(this);
        }
         
         private void frmProducts_Load(object sender, EventArgs e)
        {
            lista.cargar_lista();
        }
         public IconButton btnActive = null;
        public void iconSelect(IconButton buttonSelected, Form form)
        {
            if (btnActive != null)
            {
                btnActive.BackColor = System.Drawing.SystemColors.ControlLight;
            }

            buttonSelected.BackColor = System.Drawing.Color.LightGray;
            panelUsers.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelUsers.Controls.Add(form);
            form.Show();
            btnActive = buttonSelected;
        }
        public void mostrar_menu_editar(Editar_producto ed_pro)
        {
            iconSelect(btProdEd, ed_pro);
        }
        /// <summary>
        /// //////
        /// </summary>
        /// 
        private void bNewProd_Click(object sender, EventArgs e)
        {
            iconSelect((IconButton)sender, new Nuevo_producto());
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            lista.cargar_lista();
            lista.cargar_accion("");
            iconSelect((IconButton)sender, lista);
        }
        private void listProd_Click(object sender, EventArgs e)
        {
            lista.cargar_accion("");
            iconSelect((IconButton)sender, lista);
        }
          public void recargar_lista(string p_ac)
        {
            lista.Refresh();
            lista.cargar_lista();
            iconSelect(btProdEd, lista);
        }
        private void btProdEd_Click(object sender, EventArgs e)
        {
            lista.cargar_lista();
            lista.cargar_accion("edit");
            iconSelect((IconButton)sender, lista);
        }
        private void btDelProd_Click(object sender, EventArgs e)
        {
            lista.cargar_lista();
            lista.cargar_accion("delete");
           
            iconSelect((IconButton)sender, lista);

        }
        private void btRestP_Click(object sender, EventArgs e)
        {
            lista.cargar_lista();
            lista.cargar_accion("restore");
            iconSelect((IconButton)sender, lista);
        }

        public void seleccion_eliminar(string p_id)
        {
            Eliminar_restaurar controlador = new Eliminar_restaurar();
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este producto?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {

                MessageBox.Show(controlador.eliminar_producto(p_id), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            recargar_lista("delete");
        }
      

        
       

      

        private void btEditCat_Click(object sender, EventArgs e)
        {
            Nueva_categoria categoria = new Nueva_categoria();
            categoria.Show();
        }
    }
}
