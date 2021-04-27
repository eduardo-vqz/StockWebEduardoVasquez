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
    public partial class frmCategoriaUpdate : Form
    {
        DaoCategoriasImp categoriasImp = new DaoCategoriasImp();
        Categorias categorias = new Categorias();


        public string categoria;
        public int indice;
        public bool habilitado;

        public frmCategoriaUpdate()
        {
            InitializeComponent();
        }

        private void frmCategoriaUpdate_Load(object sender, EventArgs e)
        {
            MessageBox.Show(habilitado.ToString());
            txtCategoria.Text = categoria;
            if (habilitado)
            {
                cbxHabilitar.Checked = true;
            }
        }

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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!validaError())
            {
                update();
                frmViewCategorias view_categorias = new frmViewCategorias();
                view_categorias.Show();
            }
        }
        private void update()
        {
            
            if (cbxHabilitar.Checked)
            {
                habilitado = true;

            }
            else
            {
                habilitado = false;
            }

            try
            {
                categorias.Categoria = txtCategoria.Text.Trim();
                categorias.Habilitar_categoria = habilitado;
                categorias.Id = indice;
                categoriasImp.UpdateCategoria(categorias);
                MessageBox.Show("se realizaron los cambios con exito");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("El error es " + ex);
            }
        }
    }
}
