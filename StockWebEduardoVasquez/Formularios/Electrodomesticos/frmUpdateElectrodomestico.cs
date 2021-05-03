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
    public partial class frmUpdateElectrodomestico : Form
    {
        public int indice;
        public string electrodomestico_name;
        public string categoria;
        public bool habilitado;

        DaoCategoriasImp daoCategoriasImp = new DaoCategoriasImp();
        DaoElectrodomesticosImp daoElectrodomesticosImp = new DaoElectrodomesticosImp();
        Electrodomestico electrodomestico = new Electrodomestico();
        Validation validation = new Validation();


        public frmUpdateElectrodomestico()
        {
            InitializeComponent();
        }

        private void frmUpdateElectrodomestico_Load(object sender, EventArgs e)
        {
            txtElectrodomestico.Text = electrodomestico_name;
            validation.LlenarComboBox(cbxCategoria, "id", "categoria", daoCategoriasImp.allCategorias());
            if (habilitado)
            {
                cbHabilitar.Checked = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!validaError())
            {
                update();
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

        private void update()
        {
            try
            {
                electrodomestico.Nombre_electrodomestico = txtElectrodomestico.Text.Trim();
                electrodomestico.Categorias.Id = validation.ExtraerIndiceComboBox(cbxCategoria);
                electrodomestico.Habilitar_electrodomestico = validation.CheckHabilitado(cbHabilitar);
                electrodomestico.Id = indice;
                MessageBox.Show(electrodomestico.Nombre_electrodomestico);
                MessageBox.Show(electrodomestico.Categorias.Id.ToString());
                MessageBox.Show(electrodomestico.Habilitar_electrodomestico.ToString());

                daoElectrodomesticosImp.UpdateElectrodomestico(electrodomestico);
                frmViewElectrodomestico frm_ViewElectrodomestico = new frmViewElectrodomestico();
                frm_ViewElectrodomestico.Show();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("El error es " + ex);
            }
            
        }

    }
}
