using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using StockWebEduardoVasquez.Modelo;
using StockWebEduardoVasquez.Dao;
using StockWebEduardoVasquez.LibsBD;

namespace StockWebEduardoVasquez.Formularios.Sucursal
{
    public partial class frmAddSucursal : Form
    {
        DaoSucursalesImp daoSucursalesImp = new DaoSucursalesImp();
        Sucursales sucursal = new Sucursales();
        Validation validation = new Validation();

        public frmAddSucursal()
        {
            InitializeComponent();
        }

        private void frmAddSucursal_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidaError())
            {
                try
                {
                    sucursal.Sucursal = txtSucursal.Text.Trim();
                    sucursal.Direccion = txtTelefono.Text.Trim();
                    sucursal.Telefono = txtTelefono.Text.Trim();
                    sucursal.Habilitar_sucursal = validation.CheckHabilitado(cbxHabilitar);
                    daoSucursalesImp.AddSucursal(sucursal);
                    MessageBox.Show("El registro se a ingresado corectamente");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El error es " + ex);
                }
                frmAddSucursal frm_AddSucursal = new frmAddSucursal();
                frm_AddSucursal.Show();

            }
        }

        private Boolean ValidaError()
        {
            bool error = false;

            if (validation.ValidaTextBox(txtSucursal, " sucursal "))
            {
                error = true;
            }
            if (validation.ValidaTextBox(txtDireccion, " dirección "))
            {
                error = true;
            }
            if (validation.ValidaTextBox(txtTelefono, " telefono "))
            {
                error = true;
            }

            return error;
        }

    }
}
