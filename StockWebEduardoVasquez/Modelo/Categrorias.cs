using System;
using System.Collections.Generic;
using System.Text;

namespace StockWebEduardoVasquez.Modelo
{
    class Categrorias
    {
        private int id;
        private string categoria;
        private bool habilitar_categoria;

        public Categrorias(int id, string categoria, bool habilitar_categoria)
        {
            this.id = id;
            this.categoria = categoria;
            this.habilitar_categoria = habilitar_categoria;
        }

        public int Id { get => id; set => id = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public bool Habilitar_categoria { get => habilitar_categoria; set => habilitar_categoria = value; }

    }
}
