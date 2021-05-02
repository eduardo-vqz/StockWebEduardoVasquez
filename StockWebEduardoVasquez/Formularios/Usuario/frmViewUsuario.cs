using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using StockWebEduardoVasquez.Dao;
using StockWebEduardoVasquez.LibsBD;
using StockWebEduardoVasquez.Modelo;

namespace StockWebEduardoVasquez.Formularios.Usuario
{
    public partial class frmViewUsuario : Form
    {

        DaoUsuariosImp daoUsuariosImp = new DaoUsuariosImp();
        Usuarios usuarios = new Usuarios();
        Validation validation = new Validation();


        public frmViewUsuario()
        {
            InitializeComponent();
        }

        

        private void frmViewUsuario_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUser frm_addUser = new frmAddUser();
            frm_addUser.Show();
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!validaError())
            {
                sentDataUser();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!validaError())
            {
                eliminarUsuario();
            }
        }


        public void mostrar()
        {
            dgvUsuarios.Columns.Clear();
            dgvUsuarios.DataSource = daoUsuariosImp.allUser();
        }

        private void eliminarUsuario()
        {
            DialogResult result = MessageBox.Show(
                "Desea eliminar la categoria " + validation.ExtraerDataString(dgvUsuarios, 1),
                "Eliminar",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    usuarios.Id = validation.ExtraerDataInt(dgvUsuarios, 0);
                    daoUsuariosImp.DeleteUser(usuarios);
                    mostrar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo eliminar " + ex); ;
                }
            }
        }


        private Boolean validaError()
        {
            bool error = false;
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                error = true;
                MessageBox.Show("No se ha seleccionado ningun item");
            }
            if (validation.ExtraerDataString(dgvUsuarios, 1).Trim().Equals(""))
            {
                error = true;
                MessageBox.Show("No se ha seleccionado ningun item");
            }

            return error;
        }

        private void sentDataUser()
        {
            frmUpdateUser frm_updateUser = new frmUpdateUser();
            frm_updateUser.indice    = validation.ExtraerDataInt(dgvUsuarios, 0);
            frm_updateUser.nombre    = validation.ExtraerDataString(dgvUsuarios, 1);
            frm_updateUser.apellidos = validation.ExtraerDataString(dgvUsuarios, 2);
            frm_updateUser.user      = validation.ExtraerDataString(dgvUsuarios, 3);
            frm_updateUser.pw        = validation.ExtraerDataString(dgvUsuarios, 4);

            frm_updateUser.Show();
            Close();
        }
    }
}
