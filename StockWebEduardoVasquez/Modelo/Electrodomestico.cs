using System;
using System.Collections.Generic;
using System.Text;

namespace StockWebEduardoVasquez.Modelo
{
    public class Electrodomestico
    {
        private int id;
        private string nombre_electrodomestico;
        private Categorias categorias;
        private bool habilitar_electrodomestico;

       

        public int Id { get => id; set => id = value; }
        public string Nombre_electrodomestico { get => nombre_electrodomestico; set => nombre_electrodomestico = value; }
        public bool Habilitar_electrodomestico { get => habilitar_electrodomestico; set => habilitar_electrodomestico = value; }
        public Categorias Categorias { get => categorias; set => categorias = value; }

        public Electrodomestico()
        {
            Categorias = new Categorias();
        }

        public Electrodomestico(int id, string nombre_electrodomestico, Categorias categorias, bool habilitar_electrodomestico)
        {
            this.Id = id;
            this.Nombre_electrodomestico = nombre_electrodomestico;
            this.Categorias = categorias;
            this.Habilitar_electrodomestico = habilitar_electrodomestico;
        }
    }
}
