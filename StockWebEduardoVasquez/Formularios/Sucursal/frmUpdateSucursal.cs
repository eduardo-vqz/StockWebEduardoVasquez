using System;
using System.Windows.Forms;

using StockWebEduardoVasquez.Dao;
using StockWebEduardoVasquez.Modelo;
using StockWebEduardoVasquez.LibsBD;

namespace StockWebEduardoVasquez.Formularios.Sucursal
{
    public partial class frmUpdateSucursal : Form
    {
        DaoSucursalesImp daoSucursalesImp = new DaoSucursalesImp();
        Sucursales sucursal = new Sucursales();
        Validation validation = new Validation();

        public int indice;
        public string sucursal_n;
        public string direccion;
        public string telefono;
        public bool habilitado;

        public frmUpdateSucursal()
        {
            InitializeComponent();
        }

        private void frmUpdateSucursal_Load(object sender, EventArgs e)
        {
            txtSucursal.Text = sucursal_n;
            txtDireccion.Text = direccion;
            txtTelefono.Text = telefono;

            if (habilitado)
            {
                cbxHabilitar.Checked = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidaError())
            {
                try
                {
                    sucursal.Sucursal           = txtSucursal.Text.Trim();
                    sucursal.Direccion          = txtDireccion.Text.Trim();
                    sucursal.Telefono           = txtTelefono.Text.Trim();
                    sucursal.Habilitar_sucursal = validation.CheckHabilitado(cbxHabilitar);
                    sucursal.Id                 = indice;
                    daoSucursalesImp.UpdateSucursal(sucursal);
                    MessageBox.Show("El registro se a ingresado corectamente");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El error es " + ex);
                }
                frmViewSucursal frm_viewSucursal = new frmViewSucursal();
                frm_viewSucursal.Show();

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
