using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using StockWebEduardoVasquez.Dao;
using StockWebEduardoVasquez.Modelo;
using StockWebEduardoVasquez.LibsBD;

namespace StockWebEduardoVasquez.Formularios.Sucursal
{
    public partial class frmViewSucursal : Form
    {
        DaoSucursalesImp daoSucursalesImp = new DaoSucursalesImp();
        Sucursales sucursales = new Sucursales();
        Validation validation = new Validation();

        public frmViewSucursal()
        {
            InitializeComponent();
        }

        private void frmViewSucursal_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        private void btnAddSucursal_Click(object sender, EventArgs e)
        {
            frmAddSucursal frmAdd = new frmAddSucursal();
            frmAdd.Show();
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!validaError())
            {
                
                sendDataUpdate();
                Close();
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!validaError())
            {
                eliminarSucursal();
            }
        }

        public void mostrar()
        {
            dgvSucursales.Columns.Clear();
            dgvSucursales.DataSource = daoSucursalesImp.allSucursales();
        }

        private void eliminarSucursal()
        {
            DialogResult result = MessageBox.Show(
                "Desea eliminar la categoria " + validation.ExtraerDataString(dgvSucursales, 1),
                "Eliminar",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    sucursales.Id = validation.ExtraerDataInt(dgvSucursales, 0);
                    daoSucursalesImp.DeleteSucursal(sucursales);
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
            if (dgvSucursales.SelectedRows.Count == 0)
            {
                error = true;
                MessageBox.Show("No se ha seleccionado ningun item");
            }
            if (validation.ExtraerDataString(dgvSucursales,1).Trim().Equals(""))
            {
                error = true;
                MessageBox.Show("No se ha seleccionado ningun item");
            }

            return error;
        }

        private void sendDataUpdate()
        {
            frmUpdateSucursal frm_updateSucursal = new frmUpdateSucursal();
            frm_updateSucursal.indice     = validation.ExtraerDataInt(dgvSucursales, 0);
            frm_updateSucursal.sucursal_n = validation.ExtraerDataString(dgvSucursales, 1);
            frm_updateSucursal.direccion  = validation.ExtraerDataString(dgvSucursales, 2);
            frm_updateSucursal.telefono   = validation.ExtraerDataString(dgvSucursales, 3);
            frm_updateSucursal.habilitado = validation.ExtraerDataBool(dgvSucursales, 4);

            frm_updateSucursal.Show();
        }

    }
}
