using FontAwesome.Sharp;
using jbposs.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace jbposs.Presentacion
{
    public partial class addRol : Form
    {
        private string action = "new";
        private rol sRol;
        private Button actual;
        private jbposEntities context;
        private int idRolSeleccionado;
        public addRol()
        {
            InitializeComponent();
            actual = btNewRol;
        }

        private void addRol_Load(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());
            colorCam(btNewRol);
            loadRol();
            context = new jbposEntities();

            InitializeCheckBoxes();
        }
        private void InitializeCheckBoxes()
        {
            //principal p = new principal();

             
              foreach (ToolStripItem item in  principal.getMainForm().menuStrip2.Items)
              {

                  // Crear un CheckBox para cada pestaña
                  CheckBox checkBox = new CheckBox();
                  checkBox.Name = "cbp_" + item.Name;
                  checkBox.Text = item.Text;
                  checkBox.AutoSize = true;
                  checkBox.Dock = DockStyle.Top;

                  pCBPermisos.Controls.Add(checkBox);
              } 
        }
        private void loadRol()
        {

            using (jbposEntities db = new jbposEntities())
            {
                dataGridRol.Rows.Clear();
                dataGridRol.Columns.Clear();

                dataGridRol.Columns.Add("id_rol", "ID");
                dataGridRol.Columns.Add("Rol", "Rol");
                dataGridRol.Columns.Add("Fecha eliminado", "Fecha eliminado");


                var rolQuery = from u in db.rol
                                select new
                                {
                                    u.id_rol,
                                    u.descripcion,
                                    u.fecha_eliminado
                                };

                try
                {
                    foreach (var rolp in rolQuery)
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(dataGridRol,rolp.id_rol, rolp.descripcion, rolp.fecha_eliminado.ToString());
                        // Cambiar el color de fondo si está eliminado
                        if (rolp.fecha_eliminado != null)
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
            lbAction.Text = "Listado de roles";
            btAddRol.Text = "Agregar";
            tbAddRol.Text = "";
        }

        

        private bool chargeInfoRol()
        {
            bool ok = true;
            using (jbposEntities db = new jbposEntities())
            {

                if (db.rol.Count(us => us.descripcion.ToLower() == tbAddRol.Text.ToLower()) > 0)
                {   
                    ok = false;
                    MessageBox.Show("Ya existe un rol con ese nombre");
                }
                else
                {
                    if (tbAddRol.Text == "")
                    {
                        MessageBox.Show("No se puede guardar vacio");
                        ok = false;
                    }
                    else { 
                    rol nRol = new rol();
                    nRol.descripcion = tbAddRol.Text.Trim();
                    db.rol.Add(nRol);
                    db.SaveChanges();
                }}
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
                        MessageBox.Show("Este rol se ha actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        loadRol();
                    }
                  

                }
              } 
            else if (action == "new")
            {
                DialogResult resp = MessageBox.Show("Se creara un nuevo rol.¿Desea guardar?", "Éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    if (chargeInfoRol())
                    {
                        MessageBox.Show("Este rol se ha guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        loadRol();
                    }
                    
                }
            }
            pCBPermisos.Enabled = false;
            savePermissions();
        }

        private void savePermissions()
        {

            // Obtén los CheckBoxes marcados y sus id_boton
            var checkBoxes = pCBPermisos.Controls.OfType<CheckBox>()
              //  .Where(checkBox => checkBox.Checked)
                .ToList();

            // Crea registros en la tabla Permiso para los CheckBoxes marcados
            foreach (CheckBox checkBox in checkBoxes)
            {
                string idBoton = checkBox.Name.Replace("cbp_", ""); // Obtén el id_boton desde el nombre del CheckBox
                                                                    // Crea un nuevo registro en Permiso
                if (sRol == null) continue;

                permiso permisoMarcado = context.permiso
          .FirstOrDefault(p => p.id_rol == sRol.id_rol && p.nombreMenu == idBoton);


                if (checkBox.Checked)
                {
                    // Si no existe, crea un nuevo registro en Permiso
                    if (permisoMarcado == null)
                    {
                        permisoMarcado = new permiso
                        {
                            id_rol = sRol.id_rol,
                            nombreMenu = idBoton
                        };
                        context.permiso.Add(permisoMarcado);
                    }
                }
                else
                {
                    // Si existe, elimina el registro
                    if (permisoMarcado != null)
                    {
                        context.permiso.Remove(permisoMarcado);
                    }
                }
            }

            // Guarda los cambios en la base de datos
            context.SaveChanges();

            // Muestra un mensaje o realiza acciones adicionales si es necesario
            MessageBox.Show("Permisos guardados con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void edRol_Click(object sender, EventArgs e)
        {
            colorCam(btEdRol);
            tbAddRol.Enabled = false;
            lbAction.Text = "Seleccione un rol para editar";
            action = "edit"; 
            btAddRol.Visible = false;
            tbAddRol.Enabled = false;
            pCBPermisos.Enabled = true;
        }

        private bool saveEdit()
        {
            bool ok = true;

            using (jbposEntities db = new jbposEntities())
            {

              /*  if (db.rol.Count(us => us.descripcion.ToLower() == tbAddRol.Text.ToLower()) > 0)
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
                    else { */
                    rol nRol = new rol();
                    nRol.descripcion = tbAddRol.Text.Trim();
                    nRol.id_rol = sRol.id_rol;
                    nRol.fecha_eliminado = sRol.fecha_eliminado;
                    db.Entry(nRol).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                savePermissions();
               // }}
            }
            pCBPermisos.Enabled = false;
            return ok;

          
        }

        private void delRol_Click(object sender, EventArgs e)
        {
            colorCam(btDelRol);
            action = "delete";
            lbAction.Text = "Seleccione un rol para eliminar";
            btAddRol.Visible = false;
            tbAddRol.Enabled = false;
        }

        private void dataGridRol_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            dataGridRol.CurrentRow.Selected = true;
            if (action == "edit")
            { 
                editRol(dataGridRol.CurrentRow.Cells["Rol"].Value.ToString()); 
            }
            else if (action == "delete")
            { 
                deleteRol(dataGridRol.CurrentRow.Cells["Rol"].Value.ToString());
            }
            else if (action == "restore")
            { 
                restoreRol(dataGridRol.CurrentRow.Cells["Rol"].Value.ToString());
            } 
        }


        private void editRol(string pRol)
        {
            tbAddRol.Text= pRol;
            btAddRol.Text = "Guardar";
            btAddRol.Visible = true;
            tbAddRol.Enabled = true;
            using (jbposEntities db = new jbposEntities())
            {
                sRol = db.rol.First(u => u.descripcion == pRol);
            }
        }
        

        private void deleteRol(string pRol)
        {
            try
            {
                using (jbposEntities db = new jbposEntities())
                {
                    rol rolEliminar = db.rol.First(u => u.descripcion.ToLower() == pRol.ToLower());

                    if (rolEliminar != null)
                    {
                        if (rolEliminar.fecha_eliminado != null)
                        {
                            MessageBox.Show("Este rol ya ha sido eliminado anteriormente.", "Ya eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        else
                        {
                            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este rol?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (resultado == DialogResult.Yes)
                            {
                                // Establecer la fecha de eliminación como la fecha y hora actual
                                rolEliminar.fecha_eliminado = DateTime.Now;
                                // Guardar los cambios en la base de datos
                                db.SaveChanges();
                                MessageBox.Show("Rol eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadRol();
                            }
                        } 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el Rol: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void restoreRol(string pRol)
        {
            try
            {
                using (jbposEntities db = new jbposEntities())
                {
                    rol rolEliminar = db.rol.First(u => u.descripcion.ToLower() == pRol.ToLower());

                    if (rolEliminar != null)
                    {
                        if (rolEliminar.fecha_eliminado == null)
                        {
                            MessageBox.Show("Este rol no ha sido eliminado anteriormente.", "Ya eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea restaurar este rol?", "Confirmar Restauración", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (resultado == DialogResult.Yes)
                            {
                                
                                rolEliminar.fecha_eliminado = null;
                                // Guardar los cambios en la base de datos
                                db.SaveChanges();

                                MessageBox.Show("Rol restaurado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadRol();
                            }  } }}
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al restaurar el rol: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorCam(btRestoreRol);
            lbAction.Text = "Seleccione un rol para restaurar";
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
            pCBPermisos.Enabled = true;
        }

        private void colorCam(Button pB)
        {
            actual.BackColor = System.Drawing.SystemColors.Highlight;
            actual = pB;
            actual.BackColor = System.Drawing.Color.Green;
        }

        private void dataGridRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridRol_SelectionChanged(object sender, EventArgs e)
        {
          
            if (dataGridRol.SelectedRows.Count > 0)
            {

                // Obtiene el valor de id_rol de la fila seleccionada
                idRolSeleccionado = (int)dataGridRol.SelectedRows[0].Cells["id_rol"].Value;

                // Realiza la consulta en la tabla Permiso
                var permisosQuery = from p in context.permiso
                                    where p.id_rol == idRolSeleccionado
                                    select p.nombreMenu;

                //Desmarcar todos los checkboxes
                foreach (CheckBox item in pCBPermisos.Controls.OfType<CheckBox>())
                {
                    item.Checked = false;
                }              //  tbRoleName.Text = dataGridRol.SelectedRows[0].Cells["descripcion"].Value.ToString();
                // Marca los CheckBoxes correspondientes según los resultados de la consulta
                foreach (string idBoton in permisosQuery)
                {
                    string checkBoxName = "cbp_" + idBoton;

                    // Busca el CheckBox por nombre
                    CheckBox checkBox = pCBPermisos.Controls.OfType<CheckBox>().FirstOrDefault(c => c.Name == checkBoxName);

                    if (checkBox != null)
                    {
                        checkBox.Checked = true;
                    }
                }
            }
        }

        private void dataGridRol_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

