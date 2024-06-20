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

        Lista_productos lista_prod;
        public Seccion_productos()
        {
            InitializeComponent();
        }
        public IconButton btnActive = null;
        string _connectionString = "Server=mysql-proyectois2.alwaysdata.net;Database=proyectois2_puntoventa;User Id=362639;Password=Pollito1q;";
        string action = "";
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
            lista_prod.cargar_lista("");
            iconSelect((IconButton)sender, lista_prod);
        }
        private void listProd_Click(object sender, EventArgs e)
        {
            lista_prod.cargar_lista("");
            iconSelect((IconButton)sender, lista_prod);
        }

        private void btProdEd_Click(object sender, EventArgs e)
        {

            lista_prod.cargar_lista("edit");
            iconSelect((IconButton)sender, lista_prod);
        }
        private void btDelProd_Click(object sender, EventArgs e)
        {
            lista_prod.cargar_lista("delete");
            iconSelect((IconButton)sender, lista_prod);

        }
        private void btRestP_Click(object sender, EventArgs e)
        {
            lista_prod.cargar_lista("restore");
            iconSelect((IconButton)sender, lista_prod);
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
        public void recargar_lista(string p_ac)
        {
            lista_prod.Refresh();
            lista_prod.cargar_lista(p_ac);
            iconSelect(btProdEd, lista_prod);
        }

        public void seleccion_editar(string p_id)
        {
            int ide = int.Parse(p_id);
            iconSelect(btProdEd, new Editar_producto(ide, this));

        }
        public void seleccion_restaurar(string p_id)
        {
            Eliminar_restaurar controlador = new Eliminar_restaurar();
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea restaurar a este producto?", "Confirmar Restauración", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {

                MessageBox.Show(controlador.restaurar_producto(p_id), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            recargar_lista("restore");
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            lista_prod = new Lista_productos(this);
        }

        private void btEditCat_Click(object sender, EventArgs e)
        {
            Nueva_categoria categoria = new Nueva_categoria();
            categoria.Show();
        }
    }
}
