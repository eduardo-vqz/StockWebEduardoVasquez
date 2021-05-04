using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using StockWebEduardoVasquez.Dao;
using StockWebEduardoVasquez.LibsBD;
using StockWebEduardoVasquez.Modelo;

namespace StockWebEduardoVasquez.Formularios.Electrodomesticos
{
    public partial class frmViewElectrodomestico : Form
    {
        DaoElectrodomesticosImp daoElectrodomesticosImp = new DaoElectrodomesticosImp();
        Validation validation = new Validation();
        Electrodomestico electrodomestico = new Electrodomestico();
        
        public frmViewElectrodomestico()
        {
            InitializeComponent();
        }

        

        private void frmViewElectrodomestico_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            frmAddElectrodomestico frmAdd = new frmAddElectrodomestico();
            frmAdd.Show();
            Close();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (!validaError())
            {
                sendDataElectrodomestico();
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (!validaError())
            {
                eliminarelectrodomestico();
            }
        }

        private void mostrar()
        {
            dgvElectrodomesticos.Columns.Clear();
            dgvElectrodomesticos.DataSource = daoElectrodomesticosImp.allElectrodomesticos();
            /*var lol = new List<Electrodomestico>();
            
            lol = daoElectrodomesticosImp.allElectrodomesticos();
            int n = lol.Count;
            for (int i = 0; i < n - 1; i++)
            {
                object[] lista = { lol[i].Id.ToString(), lol[i].Nombre_electrodomestico.ToString(), lol[i].Categorias.Categoria.ToString(), lol[i].Habilitar_electrodomestico.ToString() };
                dgvElectrodomesticos.Rows.Insert((int)lista[0]);
                //MessageBox.Show(lol[i].Categorias.Categoria);
            }*/
                 


        }

        private bool validaError(){
            bool error = false;
            if (dgvElectrodomesticos.SelectedRows.Count == 0)
            {
                error = true;
                MessageBox.Show("No se ha seleccionado ningun item");
            }
            if (validation.ExtraerDataString(dgvElectrodomesticos,1).Trim().Equals(""))
            {
                error = true;
                MessageBox.Show("No se ha seleccionado ningun item");
            }

            return error;
        }

         private void eliminarelectrodomestico()
        {
            DialogResult result = MessageBox.Show(
                "Desea eliminar la categoria " + validation.ExtraerDataString(dgvElectrodomesticos, 1),
                "Eliminar",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    electrodomestico.Id = validation.ExtraerDataInt(dgvElectrodomesticos, 0);
                    daoElectrodomesticosImp.DeleteElectrodomestico(electrodomestico);
                    mostrar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo eliminar " + ex); ;
                }
            }
        }

        private void sendDataElectrodomestico()
        {
            frmUpdateElectrodomestico frm_updateElectrodomestico = new frmUpdateElectrodomestico();
            frm_updateElectrodomestico.indice = validation.ExtraerDataInt(dgvElectrodomesticos, 0);
            frm_updateElectrodomestico.electrodomestico_name = validation.ExtraerDataString(dgvElectrodomesticos, 1);
            frm_updateElectrodomestico.categoria = validation.ExtraerDataString(dgvElectrodomesticos, 2);
            frm_updateElectrodomestico.habilitado = validation.ExtraerDataBool(dgvElectrodomesticos, 3);

            frm_updateElectrodomestico.Show();
            Close();

        }

        private void dgvElectrodomesticos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
