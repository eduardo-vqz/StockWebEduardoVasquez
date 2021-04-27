using System;
using System.Collections.Generic;
using System.Text;

namespace StockWebEduardoVasquez.Modelo
{
    class Electrodomesticos
    {
        private int id;
        private string nombre_electrodomestico;
        private Categorias categorias;
        private bool habilitar_electrodomestico;

        public Electrodomesticos(int id, string nombre_electrodomestico, Categorias categorias, bool habilitar_electrodomestico)
        {
            this.id = id;
            this.nombre_electrodomestico = nombre_electrodomestico;
            this.categorias = categorias;
            this.habilitar_electrodomestico = habilitar_electrodomestico;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre_electrodomestico { get => nombre_electrodomestico; set => nombre_electrodomestico = value; }
        public bool Habilitar_electrodomestico { get => habilitar_electrodomestico; set => habilitar_electrodomestico = value; }
        internal Categorias Categorias { get => categorias; set => categorias = value; }
    }
}
