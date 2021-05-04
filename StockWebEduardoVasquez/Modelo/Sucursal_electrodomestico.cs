using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace StockWebEduardoVasquez.Modelo
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class Sucursal_electrodomestico
    {
        private int id;
        private Sucursales sucursales;
        private int cantidad;
        private Electrodomestico electrodomesticos;
        public Sucursal_electrodomestico()
        {
            sucursales = new Sucursales();
            electrodomesticos = new Electrodomestico();
        }

        public Sucursal_electrodomestico(int id, Sucursales sucursales, Electrodomestico electrodomesticos, int cantidad)
        {
            this.id = id;
            this.sucursales = sucursales;
            this.Electrodomesticos = electrodomesticos;
            this.cantidad = cantidad;
        }

        public int Id { get => id; set => id = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public Sucursales Sucursales 
        { 
            get => sucursales;
            set => sucursales = value; 
        }
        public Electrodomestico Electrodomesticos { get => electrodomesticos; set => electrodomesticos = value; }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
