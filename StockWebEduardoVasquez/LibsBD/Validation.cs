using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace StockWebEduardoVasquez.LibsBD
{
    class Validation
    {

        private bool bandera;

        public bool Bandera { get => bandera; set => bandera = value; }

        public bool ValidaTextBox(TextBox textBox, string mensaje)
        {
            if (textBox.Text.Trim().Equals(""))
            {
                MessageBox.Show("El campo " +mensaje + " no puede estar vacio.");
                textBox.Clear();
                textBox.Focus();
                Bandera = true;

            }
            return Bandera;
        }

        public bool CheckHabilitado(CheckBox checkBox)
        {
            if (checkBox.Checked)
            {
                Bandera = true;

            }
            else
            {
                Bandera = false;
            }
            return Bandera;
        }

        public string ExtraerNameFila(DataGridView dataGridView)
        {
            string fila = dataGridView[1, dataGridView.CurrentRow.Index].Value.ToString();
            return fila;
        }

        public int ExtraerIndexFila(DataGridView dataGridView)
        {
            int indice = Convert.ToInt32(dataGridView[0, dataGridView.CurrentRow.Index].Value.ToString());
            return indice;
        }

    }
}
