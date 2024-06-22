﻿using Dapper;
using FontAwesome.Sharp;
using Google.Protobuf.Reflection;
using Positive.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace Positive.Presentacion
{
    public partial class Seccion_usuarios : Form
    {
            
        Lista_usuarios lista = null;
        public Seccion_usuarios()
        {
            InitializeComponent();
            lista = new Lista_usuarios(this);
        }

        
        private void frmUser_Load(object sender, EventArgs e)
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

        //Nuevo usuario
        private void addUser_Click(object sender, EventArgs e)
        {
            // Usuario nuevo_usuario=new Usuario();
           iconSelect((IconButton)sender,new Nuevo_usuario());
        }

        //Muestra lista
        private void iconButton1_Click(object sender, EventArgs e)
        {
            lista.cargar_lista();
            lista.cargar_accion("");
            iconSelect((IconButton)sender, lista);
           
        }

      


        private void btEditUser_Click(object sender, EventArgs e)
        {
            lista.cargar_accion("edit");
            iconSelect((IconButton)sender,lista);
           
        }

        public void recargar_lista(string p_ac )
        {
            lista.Refresh();
            lista.cargar_accion(p_ac);
            iconSelect(btEditUser, lista);
        }
        public void seleccion_editar(Usuario p_usuario_editar,Contacto p_contacto_editar)
        {
            Editar_usuario editar_usuario = new Editar_usuario();
            iconSelect(btEditUser, editar_usuario);
            editar_usuario.cargar_datos(p_usuario_editar, p_contacto_editar);


        }
        //Eliminar usuario
        private void delUser_Click_1(object sender, EventArgs e)
        {
           
            lista.cargar_accion("delete");
            iconSelect((IconButton)sender, lista);

        }
        
        private void restUser_Click(object sender, EventArgs e)
        {
          
            lista.cargar_accion("restore");
            iconSelect((IconButton)sender, lista);
        }

        private void rolesEd_Click(object sender, EventArgs e)
        {/*
            iconSelect((IconButton)sender, new editRol());
            addRol ar = new ro();
            ar.ShowDialog();*/
        }

        /*je
public void userEdit_Click(object sender, EventArgs e)
{


}

//muestra lista desde useredit
public void refreshList(IconButton pBtn)
{

usList.loadUsers();
iconSelect(pBtn, usList);
}


//recibe el dni del usuario seleccionado y carga los campos en el formulario de editar
public void userEd(string pDni)
{
userEdit.loadUser(pDni);
iconSelect(btEditUser, userEdit);
}


private void iconButton2_Click(object sender, EventArgs e)
{
//iconSelect((IconButton)sender, rolEd);
//RolesForm rolesEdit = new RolesForm(this);
//        rolesEdit.ShowDialog(this);

}

//muestra la lista de usuarios
private void frmUsers_Load(object sender, EventArgs e)
{
iconSelect(listUser, usList);
}

//Eliminar usuario
private void delUser_Click(object sender, EventArgs e)
{
usList.loadUsers();
usList.lblUsList.Text = "Seleccionar usuario para eliminar";
usList.action = "delete";
iconSelect((IconButton)sender, usList);
//iconSelect((IconButton)sender, delUs);

}
public void deleteUser(string pDni)
{
try
{
// Obtener el DNI del usuario seleccionado
// string dniBuscar = dataGridUserList.SelectedRows[0].Cells["DNI"].Value.ToString();

// Buscar el usuario por DNI
using (jbposEntities db = new jbposEntities())
{
  usuario usuarioEliminar = db.usuario.First(u => u.dni == pDni);

  if (usuarioEliminar != null)
  {
      if (usuarioEliminar.fecha_eliminado != null)
      {
          MessageBox.Show("Este usuario ya ha sido eliminado anteriormente.", "Ya eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }

      else
      {
          DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este usuario?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

          if (resultado == DialogResult.Yes)
          {
              // Establecer la fecha de eliminación como la fecha y hora actual
              usuarioEliminar.fecha_eliminado = DateTime.Now;


              // Guardar los cambios en la base de datos
              db.SaveChanges();

              MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
              refreshList(btnUserDelete);
          }
      }

  }


}


}
catch (Exception ex)
{
MessageBox.Show($"Error al eliminar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
}
}

private void panelUsers2_Paint(object sender, PaintEventArgs e)
{

}

private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
{

}

private void restUser_Click(object sender, EventArgs e)
{
usList.loadUsers();
usList.lblUsList.Text = "Seleccionar usuario para restaurar";
usList.action = "restore";
iconSelect((IconButton)sender, usList);
}

public void restoreUser(string pDni)
{
try
{
// Obtener el DNI del usuario seleccionado
//string dniBuscar = dataGridUserList.SelectedRows[0].Cells["DNI"].Value.ToString();
using (jbposEntities db = new jbposEntities())
{

  // Buscar el usuario por DNI
  usuario usuarioRestaurar = db.usuario.First(u => u.dni == pDni);

  if (usuarioRestaurar != null)
  {
      if (usuarioRestaurar.fecha_eliminado == null)
      {
          MessageBox.Show("Este usuario no ha sido eliminado.", "No eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else { 
      DialogResult resultado = MessageBox.Show("¿Está seguro de que desea restaurar este usuario?", "Confirmar Restauración", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

           if (resultado == DialogResult.Yes)
          {
              // Elimina la fecha de eliminación 
              usuarioRestaurar.fecha_eliminado = null;

              // Guardar los cambios en la base de datos
              db.SaveChanges();
              MessageBox.Show("Usuario restaurado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
              panelUsers.Refresh();
          }
  }}
}
refreshList(restUser);
}

catch (Exception ex)
{
MessageBox.Show($"Error al restaurar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
}
}

private void btnListUsers_Click(object sender, EventArgs e)
{
usList.action = "";
refreshList(btnListUsers);
usList.lblUsList.Text = "Lista de Usuarios";
}

private void panelUsers_Click(object sender, EventArgs e)
{

}

private void rolesEd_Click(object sender, EventArgs e)
{
ss
}*/
    }
}