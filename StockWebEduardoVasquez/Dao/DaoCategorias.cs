using System;
using System.Collections.Generic;
using System.Text;
using StockWebEduardoVasquez.Modelo;

namespace StockWebEduardoVasquez.Dao
{
    interface DaoCategorias
    {
        void AddCategoria(Categorias catergoria);
        void UpdateCategoria(Categorias catergoria);
        void DeleteCategoria(Categorias catergoria);

        List<Categorias> allCategorias();
    }
}
