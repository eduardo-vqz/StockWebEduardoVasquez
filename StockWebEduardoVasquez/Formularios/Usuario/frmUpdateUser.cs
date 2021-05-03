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
    public partial class frmUpdateUser : Form
    {
        public int indice;
        public string nombre;
        public string apellidos;
        public string user;
        public string pw;

        DaoUsuariosImp daoUsiariosImp = new DaoUsuariosImp();
        Validation validation = new Validation();
        Usuarios usuarios = new Usuarios();

        public frmUpdateUser()
        {
            InitializeComponent();
        }

        private void frmUpdateUser_Load(object sender, EventArgs e)
        {
            txtNombre.Text = nombre;
            txtApellidos.Text = apellidos;
            txtUsuario.Text = user;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidaError())
            {
                frmViewUsuario frm_ViewUsuario = new frmViewUsuario();

                usuarios.Nombre = txtNombre.Text;
                usuarios.Apellidos = txtApellidos.Text;
                usuarios.Usuario = txtUsuario.Text;
                if (!txtContraseña.Text.Trim().Equals(""))
                {
                    usuarios.Pw = txtContraseña.Text;
                }
                else
                {
                    usuarios.Pw = pw;
                }
                usuarios.Id = indice;
                daoUsiariosImp.UpdateUser(usuarios);
                MessageBox.Show("se realizaron los cambios con exito");

                frm_ViewUsuario.Show();
                Close();
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

            return error;
        }
    }
}
