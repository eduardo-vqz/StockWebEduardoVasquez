using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using StockWebEduardoVasquez.Formularios.Categrorias;
using StockWebEduardoVasquez.Formularios.Sucursal;
using StockWebEduardoVasquez.Formularios.Usuario;
using StockWebEduardoVasquez.Formularios.Electrodomesticos;
using StockWebEduardoVasquez.Formularios.SucursalElectrodomestico;

namespace StockWebEduardoVasquez
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmViewCategorias view_categorias = new frmViewCategorias();
            view_categorias.Show();
        }

        private void btnSucursales_Click(object sender, EventArgs e)
        {
            frmViewSucursal frm_ViewSucursal = new frmViewSucursal();
            frm_ViewSucursal.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmViewUsuario frm_ViewUsuario = new frmViewUsuario();
            frm_ViewUsuario.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnElectrodomestico_Click(object sender, EventArgs e)
        {
            frmViewElectrodomestico frm_viewElectrodomestico = new frmViewElectrodomestico();
            frm_viewElectrodomestico.Show();
        }

        private void btnSucursalElectrodomestico_Click(object sender, EventArgs e)
        {
            frmViewSucursalElectrodomestico frm_ViewSucursalElectrodomestico = new frmViewSucursalElectrodomestico();
            frm_ViewSucursalElectrodomestico.Show();
        }
    }
}
