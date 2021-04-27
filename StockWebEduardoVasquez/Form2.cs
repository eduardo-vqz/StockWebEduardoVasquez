using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using StockWebEduardoVasquez.Formularios.Categrorias;

namespace StockWebEduardoVasquez
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmViewCategorias view_categorias = new frmViewCategorias();
            view_categorias.Show();
        }
    }
}
