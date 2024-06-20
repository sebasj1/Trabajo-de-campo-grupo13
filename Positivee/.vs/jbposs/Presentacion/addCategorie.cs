using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jbposs.Presentacion
{
    public partial class addCategorie : Form
    {
        public addCategorie()
        {
            InitializeComponent();
            actual = btNewRol;
        }
        
        private string action = "new";
        private categoria sCategorie;
        private Button actual;


        private void addCategorie_Load(object sender, EventArgs e)
        {
            
            colorCam(btNewRol);
            loadCat();
            
        }


        private void colorCam(Button pB)
        {
            actual.BackColor = System.Drawing.SystemColors.Highlight;
            actual = pB;
            actual.BackColor = System.Drawing.Color.Green;
        }

        private void loadCat()
        {

            using (jbposEntities db = new jbposEntities())
            {
                dataGridRol.Rows.Clear();
                dataGridRol.Columns.Clear();
                dataGridRol.Columns.Add("Categoria", "Categoria");
                dataGridRol.Columns.Add("Fecha eliminado", "Fecha eliminado");


                var catQuery = from u in db.categoria
                               select new
                               {
                                   u.nombre,
                                   u.fecha_eliminado
                               };

                try
                {
                    foreach (var catP in catQuery)
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(dataGridRol, catP.nombre, catP.fecha_eliminado.ToString());
                        // Cambiar el color de fondo si está eliminado
                        if (catP.fecha_eliminado != null)
                        {
                            fila.DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                            fila.DefaultCellStyle.ForeColor = System.Drawing.Color.White; // Puedes ajustar el color del texto según sea necesario
                        }
                        dataGridRol.Rows.Add(fila);
                    }
                    dataGridRol.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo cargar datos" + ex);
                }
            }
            lbAction.Text = "Listado de Categorias";
            btAddRol.Text = "Agregar";
            tbAddRol.Text = "";
        }



        private bool chargeInfoCat()
        {
            bool ok = true;
            using (jbposEntities db = new jbposEntities())
            {

                if (db.categoria.Count(us => us.nombre.ToLower() == tbAddRol.Text.ToLower()) > 0)
                {
                    ok = false;
                    MessageBox.Show("Ya existe una categoria con ese nombre");
                }
                else
                {
                    if (tbAddRol.Text == "")
                    {
                        MessageBox.Show("No se puede guardar vacio");
                        ok = false;
                    }
                    else
                    {
                        categoria nCat = new categoria();
                        nCat.nombre = tbAddRol.Text.Trim();
                        db.categoria.Add(nCat);
                        db.SaveChanges();
                    }
                }
            }
            return ok;
        }

        private void btAddRol_Click(object sender, EventArgs e)
        {
            if (action == "edit")
            {
                //usuario user = context.usuario.FirstOrDefault(u => u.dni == tbDNI.Text);
                DialogResult resp = MessageBox.Show("Se actualizaran los datos ingresados.¿Desea actualizarlos?", "Éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resp == DialogResult.Yes)
                {
                    if (saveEdit())
                    {
                        MessageBox.Show("Esta categoria se ha actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        loadCat();
                    }


                }
            }
            else if (action == "new")
            {
                DialogResult resp = MessageBox.Show("Se creara una nueva categoria.¿Desea guardar?", "Éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    if (chargeInfoCat())
                    {
                        MessageBox.Show("Esta categoria se ha guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        loadCat();
                    }

                }
            }

        }
        private void edRol_Click(object sender, EventArgs e)
        {
            colorCam(btEdRol);
            tbAddRol.Enabled = false;
            lbAction.Text = "Seleccione una categoria para editar";
            action = "edit";
            btAddRol.Visible = false;
            tbAddRol.Enabled = false;


        }

        private bool saveEdit()
        {
            bool ok = true;

            using (jbposEntities db = new jbposEntities())
            {

                if (db.categoria.Count(us => us.nombre.ToLower() == tbAddRol.Text.ToLower()) > 0)
                {
                    ok = false;

                    MessageBox.Show("El nombre es el mismo registrado");
                }
                else
                {
                    if (tbAddRol.Text == "")
                    {
                        MessageBox.Show("No se puede guardar vacio");
                    }
                    else
                    {
                        categoria nCat = new categoria();
                        nCat.nombre = tbAddRol.Text.Trim();
                        nCat.id_categoria = sCategorie.id_categoria;
                        nCat.fecha_eliminado = sCategorie.fecha_eliminado;
                        db.Entry(nCat).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                    }
                }
            }
            return ok;


        }
        private void tbAddRol_Validating(object sender, CancelEventArgs e)
        {

        }


        private void tbAddRol_Validated(object sender, EventArgs e)
        {
        }

        private void delRol_Click(object sender, EventArgs e)
        {
            colorCam(btDelRol);
            action = "delete";
            lbAction.Text = "Seleccione una categoria para eliminar";
            btAddRol.Visible = false;
            tbAddRol.Enabled = false;
        }


        private void editRol(string pRol)
        {
            tbAddRol.Text = pRol;
            btAddRol.Text = "Guardar";
            btAddRol.Visible = true;
            tbAddRol.Enabled = true;
            using (jbposEntities db = new jbposEntities())
            {
                sCategorie = db.categoria.First(u => u.nombre == pRol);
            }
        }


        private void deleteRol(string pRol)
        {
            try
            {
                using (jbposEntities db = new jbposEntities())
                {
                    categoria catElim = db.categoria.First(u => u.nombre.ToLower() == pRol.ToLower());

                    if (catElim != null)
                    {
                        if (catElim.fecha_eliminado != null)
                        {
                            MessageBox.Show("Esta categoria ya ha sido eliminado anteriormente.", "Ya eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        else
                        {
                            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar esta categoria?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (resultado == DialogResult.Yes)
                            {
                                // Establecer la fecha de eliminación como la fecha y hora actual
                                catElim.fecha_eliminado = DateTime.Now;
                                // Guardar los cambios en la base de datos
                                db.SaveChanges();
                                MessageBox.Show("Categoria eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadCat();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar categoria: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void restoreRol(string pRol)
        {
            try
            {
                using (jbposEntities db = new jbposEntities())
                {
                    categoria catRes = db.categoria.First(u => u.nombre.ToLower() == pRol.ToLower());

                    if (catRes != null)
                    {
                        if (catRes.fecha_eliminado == null)
                        {
                            MessageBox.Show("Esta categoria no ha sido eliminado anteriormente.", "Ya eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea restaurar esta categoria?", "Confirmar Restauración", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (resultado == DialogResult.Yes)
                            {

                                catRes.fecha_eliminado = null;
                                // Guardar los cambios en la base de datos
                                db.SaveChanges();

                                MessageBox.Show("Categoria restaurado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadCat();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al restaurar la categoria: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            colorCam(btRestoreRol);
            lbAction.Text = "Seleccione una categoria para restaurar";
            action = "restore";
            btAddRol.Visible = false;
            tbAddRol.Enabled = false;

        }

        private void btNewRol_Click(object sender, EventArgs e)
        {
            colorCam(btNewRol); 
            lbAction.Text = "Nuevo Rol";
            action = "new";
            btAddRol.Visible = true;
            tbAddRol.Enabled = true;
        }

       

        private void dataGridRol_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            dataGridRol.CurrentRow.Selected = true;
            if (action == "edit")
            {
                editRol(dataGridRol.CurrentRow.Cells["Categoria"].Value.ToString());
            }
            else if (action == "delete")
            {
                deleteRol(dataGridRol.CurrentRow.Cells["Categoria"].Value.ToString());
            }
            else if (action == "restore")
            {
                restoreRol(dataGridRol.CurrentRow.Cells["Categoria"].Value.ToString());
            }
        }

        private void dataGridRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
