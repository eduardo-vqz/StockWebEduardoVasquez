using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using StockWebEduardoVasquez.Dao;
using StockWebEduardoVasquez.Modelo;

namespace StockWebEduardoVasquez.Formularios.Categrorias
{
    public partial class AddCategoria : Form
    {
        // Inicializamos las clases
        DaoCategoriasImp daoCategoria = new DaoCategoriasImp();
        Categorias categorias = new Categorias();
        public AddCategoria()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Agregamos el registro
            if (!validaError())
            {
                agregarCategoria();
                frmViewCategorias view_categorias = new frmViewCategorias();
                view_categorias.Show();

            }
        }

        //Funciones de validacion
        private Boolean validaError()
        {
            bool error = false;
            if (txtCategoria.Text.Trim().Equals(""))
            {
                error = true;
                MessageBox.Show("El campo categoria es requerido");
                txtCategoria.Clear();
                txtCategoria.Focus();
            }

            return error;
        }

        //Función para agregar registro de categorias
        private void agregarCategoria()
        {
            bool habilitado;
            if (cbxHabilitar.Checked)
            {
                habilitado = true;

            }
            else
            {
                habilitado = false;
            }
            MessageBox.Show(habilitado.ToString());
            try
            {
                categorias.Categoria = txtCategoria.Text.Trim();

                categorias.Habilitar_categoria = habilitado;
                daoCategoria.AddCategoria(categorias);
                MessageBox.Show("El registro se a ingresado corectamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("El error es " + ex);
            }
        }
    }   

}
