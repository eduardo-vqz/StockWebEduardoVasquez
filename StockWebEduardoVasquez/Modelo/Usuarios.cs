using System;
using System.Collections.Generic;
using System.Text;

namespace StockWebEduardoVasquez.Modelo
{
    class Usuarios
    {
        private int id;
        private string nombre;
        private string apellidos;
        private string usuario;
        private string pw;

        public Usuarios()
        {
        }

        public Usuarios(int id, string nombre, string apellidos, string usuario, string pw)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.usuario = usuario;
            this.pw = pw;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Pw { get => pw; set => pw = value; }
    }
}
