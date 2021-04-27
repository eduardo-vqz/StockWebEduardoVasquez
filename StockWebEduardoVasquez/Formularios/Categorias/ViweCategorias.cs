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
    public partial class frmViewCategorias : Form
    {
        //inicializamos 
        DaoCategoriasImp daoCategoriasImp = new DaoCategoriasImp();
        Categorias categorias = new Categorias();

        string fila = null;
        public frmViewCategorias()
        {
            InitializeComponent();
        }

        private void btnAddCategoria_Click(object sender, EventArgs e)
        {
            AddCategoria addCategoria = new AddCategoria();
            addCategoria.Show();
            Close();
        }

        private void viewCategorias_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        //Funcion para mostrar los registros en el datagrid
        public void mostrar()
        {
            dgvCategorias.Columns.Clear();
            dgvCategorias.DataSource = daoCategoriasImp.allCategorias();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            fila = dgvCategorias[0, dgvCategorias.CurrentRow.Index].Value.ToString();
            if (!validaError())
            {
                eliminarCategoria();
            }
        }

        //Funcion para eliminar un registro
        private void eliminarCategoria()
        {
            string value = dgvCategorias[1, dgvCategorias.CurrentRow.Index].Value.ToString();
            DialogResult result = MessageBox.Show("Desea eliminar la categoria " + value, "Eliminar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    categorias.Id = Convert.ToInt16(fila);
                    daoCategoriasImp.DeleteCategoria(categorias);
                    mostrar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo eliminar " + ex); ;
                }
            }
        }
        //Funcion para validar que se haga seleccionado una fila para 
        //actualizar o eliminar
        private Boolean validaError()
        {
            bool error = false;
            if (dgvCategorias.SelectedRows.Count == 0)
            {
                error = true;
                MessageBox.Show("No se ha seleccionado ningun item");
            }
            if (fila.Trim().Equals(""))
            {
                error = true;
                MessageBox.Show("No se ha seleccionado ningun item");
            }

            return error;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            fila = dgvCategorias[0, dgvCategorias.CurrentRow.Index].Value.ToString();
            if (!validaError())
            {
                envioDatosUpdate();
            }
        }

        private void envioDatosUpdate()
        {
            frmCategoriaUpdate categoriaUpdate = new frmCategoriaUpdate();
            categoriaUpdate.indice = Convert.ToInt16(fila);
            categoriaUpdate.categoria = dgvCategorias[1, dgvCategorias.CurrentRow.Index].Value.ToString();
            categoriaUpdate.habilitado = Convert.ToBoolean(dgvCategorias[2, dgvCategorias.CurrentRow.Index].Value.ToString());

            categoriaUpdate.Show();
        }
    }

    
}
