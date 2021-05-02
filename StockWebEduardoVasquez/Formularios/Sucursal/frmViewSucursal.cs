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
                "Desea eliminar la categoria " + validation.ExtraerNameFila(dgvSucursales),
                "Eliminar",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    sucursales.Id = validation.ExtraerIndexFila(dgvSucursales);
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
            if (validation.ExtraerNameFila(dgvSucursales).Trim().Equals(""))
            {
                error = true;
                MessageBox.Show("No se ha seleccionado ningun item");
            }

            return error;
        }

        private void sendDataUpdate()
        {
            MessageBox.Show(validation.ExtraerIndexFila(dgvSucursales).ToString());
            MessageBox.Show(validation.ExtraerNameFila(dgvSucursales));
            MessageBox.Show(dgvSucursales[2, dgvSucursales.CurrentRow.Index].Value.ToString());
            MessageBox.Show(dgvSucursales[3, dgvSucursales.CurrentRow.Index].Value.ToString());
            MessageBox.Show(dgvSucursales[4, dgvSucursales.CurrentRow.Index].Value.ToString());

            frmUpdateSucursal frm_updateSucursal = new frmUpdateSucursal();
            frm_updateSucursal.indice     = validation.ExtraerIndexFila(dgvSucursales);
            frm_updateSucursal.sucursal_n = validation.ExtraerNameFila(dgvSucursales);
            frm_updateSucursal.direccion  = dgvSucursales[2, dgvSucursales.CurrentRow.Index].Value.ToString();
            frm_updateSucursal.telefono   = dgvSucursales[3, dgvSucursales.CurrentRow.Index].Value.ToString();
            frm_updateSucursal.habilitado = Convert.ToBoolean(dgvSucursales[4, dgvSucursales.CurrentRow.Index].Value.ToString());

            frm_updateSucursal.Show();
        }

    }
}
