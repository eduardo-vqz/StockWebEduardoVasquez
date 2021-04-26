using System;
using System.Collections.Generic;
using System.Text;
using StockWebEduardoVasquez.Modelo;

namespace StockWebEduardoVasquez.Dao
{
    interface DaoCategorias
    {
        void AddCategoria(Categrorias caterias);
        void UpdateCategoria(Categrorias caterias);
        void DeleteCategoria(Categrorias caterias);

        List<Categrorias> allCategorias();
    }
}
