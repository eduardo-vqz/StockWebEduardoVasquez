using System;
using System.Collections.Generic;
using System.Text;

namespace StockWebEduardoVasquez.Modelo
{
    class Sucursal_electrodomestico
    {
        private int id;
        private Sucursales sucursales;
        private Electrodomesticos electrodomesticos;
        private int cantidad;

        public Sucursal_electrodomestico(int id, Sucursales sucursales, Electrodomesticos electrodomesticos, int cantidad)
        {
            this.id = id;
            this.sucursales = sucursales;
            this.electrodomesticos = electrodomesticos;
            this.cantidad = cantidad;
        }

        public int Id { get => id; set => id = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        internal Sucursales Sucursales { get => sucursales; set => sucursales = value; }
        internal Electrodomesticos Electrodomesticos { get => electrodomesticos; set => electrodomesticos = value; }
    }
}
