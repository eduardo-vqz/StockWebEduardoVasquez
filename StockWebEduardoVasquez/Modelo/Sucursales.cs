using System;
using System.Collections.Generic;
using System.Text;

namespace StockWebEduardoVasquez.Modelo
{
    class Sucursales
    {
        private int id;
        private string sucursal;
        private string direccion;
        private string telefono;
        private bool habilitar_sucursal;

        public Sucursales()
        {
        }

        public Sucursales(int id, string sucursal, string direccion, string telefono, bool habilitar_sucursal)
        {
            this.id = id;
            this.sucursal = sucursal;
            this.direccion = direccion;
            this.telefono = telefono;
            this.habilitar_sucursal = habilitar_sucursal;
        }

        public int Id { get => id; set => id = value; }
        public string Sucursal { get => sucursal; set => sucursal = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public bool Habilitar_sucursal { get => habilitar_sucursal; set => habilitar_sucursal = value; }
    }
}
