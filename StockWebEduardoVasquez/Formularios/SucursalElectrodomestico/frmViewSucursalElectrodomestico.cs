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
namespace StockWebEduardoVasquez.Formularios.SucursalElectrodomestico
{
    public partial class frmViewSucursalElectrodomestico : Form
    {
        DaoSucursal_electrodomesticoImp daoSucursal_ElectrodomesticoImp = new DaoSucursal_electrodomesticoImp();
        Validation validation = new Validation();
        Sucursal_electrodomestico sucursal_Electrodomestico = new Sucursal_electrodomestico();

        public frmViewSucursalElectrodomestico()
        {
            InitializeComponent();
        }

        private void frmViewSucursalElectrodomestico_Load(object sender, EventArgs e)
        {
            dgvSucursalElectrodomestico.DataSource = daoSucursal_ElectrodomesticoImp.allSucursal_electrodomestico();
        }
    }
}
