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

namespace StockWebEduardoVasquez.Formularios.Electrodomesticos
{
    public partial class frmAddElectrodomestico : Form
    {

        DaoCategoriasImp daoCategorias = new DaoCategoriasImp();
        DaoElectrodomesticosImp daoElectrodomesticosImp = new DaoElectrodomesticosImp();
        Validation validation = new Validation();
        Electrodomestico electrodomestico = new Electrodomestico();

        public frmAddElectrodomestico()
        {
            InitializeComponent();
        }

        private void frmAddElectrodomestico_Load(object sender, EventArgs e)
        {
            validation.LlenarComboBox(cbxCategoria, "id", "categoria", daoCategorias.allCategorias());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!validaError())
            {
                Agregar();
            }
        }

        private bool validaError()
        {
            bool bandera = false;
            if (validation.ValidaTextBox(txtElectrodomestico, " electrodomestico "))
            {
                bandera = true;
            }
            return bandera;
        }

        private void Agregar()
        {
            electrodomestico.Nombre_electrodomestico = txtElectrodomestico.Text.Trim();
            electrodomestico.Categorias.Id = validation.ExtraerIndiceComboBox(cbxCategoria);
            electrodomestico.Habilitar_electrodomestico = validation.CheckHabilitado(cbHabilitar);

            daoElectrodomesticosImp.AddElectrodomestico(electrodomestico);
            frmViewElectrodomestico frm_ViewElectrodomestico = new frmViewElectrodomestico();
            frm_ViewElectrodomestico.Show();
            Close();
        }
    }
}
