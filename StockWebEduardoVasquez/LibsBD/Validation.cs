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

        

        /*
        FUNCIONES PARA EXTRAER LOS DATOS DEL DATA GRID VIEW SEGÚN SU TIPO DE DATO
        STRING, INT, BOOL
        */
        public bool ExtraerDataBool(DataGridView dataGridView, int indice)
        {
            bool dato = Convert.ToBoolean(dataGridView[indice, dataGridView.CurrentRow.Index].Value.ToString());
            return dato;
        }

        public int ExtraerDataInt(DataGridView dataGridView, int indice)
        {
            int dato = Convert.ToInt32(dataGridView[indice, dataGridView.CurrentRow.Index].Value.ToString());
            return dato;
        }

        public string ExtraerDataString(DataGridView dataGridView, int indice)
        {
            
            string dato = dataGridView[indice, dataGridView.CurrentRow.Index].Value.ToString();
            return dato;
        }
    }
}
