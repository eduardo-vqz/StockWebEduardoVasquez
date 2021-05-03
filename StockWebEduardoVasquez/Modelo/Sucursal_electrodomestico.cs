using System;
using System.Collections.Generic;
using System.Text;

namespace StockWebEduardoVasquez.Modelo
{
    class Sucursal_electrodomestico
    {
        private int id;
        private Sucursales sucursales;
        private Electrodomestico electrodomesticos;
        private int cantidad;

        public Sucursal_electrodomestico()
        {
            sucursales = new Sucursales();
            electrodomesticos = new Electrodomestico();
        }

        public Sucursal_electrodomestico(int id, Sucursales sucursales, Electrodomestico electrodomesticos, int cantidad)
        {
            this.id = id;
            this.sucursales = sucursales;
            this.electrodomesticos = electrodomesticos;
            this.cantidad = cantidad;
        }

        public int Id { get => id; set => id = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        internal Sucursales Sucursales { get => sucursales; set => sucursales = value; }
        internal Electrodomestico Electrodomesticos { get => electrodomesticos; set => electrodomesticos = value; }
    }
}
