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
    public partial class frmAddUser : Form
    {

        DaoUsuariosImp daoUsuariosImp = new DaoUsuariosImp();
        Validation validation = new Validation();
        Usuarios usuarios = new Usuarios();

        public frmAddUser()
        {
            InitializeComponent();
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidaError())
            {
                addUsuario();
            }
        }

        private Boolean ValidaError()
        {
            bool error = false;

            if (validation.ValidaTextBox(txtNombre, " nombre "))
            {
                error = true;
            }
            if (validation.ValidaTextBox(txtApellidos, " apellidos "))
            {
                error = true;
            }
            if (validation.ValidaTextBox(txtUsuario, " usuario "))
            {
                error = true;
            }
            if (validation.ValidaTextBox(txtContraseña, " Contraseña "))
            {
                error = true;
            }

            return error;
        }

        public void addUsuario()
        {
            try
            {
                usuarios.Nombre = txtNombre.Text.Trim();
                usuarios.Apellidos = txtApellidos.Text.Trim();
                usuarios.Usuario = txtUsuario.Text.Trim();
                usuarios.Pw = txtContraseña.Text.Trim();
                daoUsuariosImp.AddUser(usuarios);
                MessageBox.Show("El registro se a ingresado corectamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("El error es " + ex);
            }
            frmViewUsuario frm_viewUsuario = new frmViewUsuario();
            frm_viewUsuario.Show();

        }

        
    }
}
