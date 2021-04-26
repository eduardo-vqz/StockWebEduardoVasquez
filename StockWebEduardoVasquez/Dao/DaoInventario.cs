using System;
using System.Collections.Generic;
using System.Text;
using StockWebEduardoVasquez.Modelo;

namespace StockWebEduardoVasquez.Dao
{
    interface DaoInventario
    {
        void AddCategoria(Inventario inventario);
        void UpdateCategoria(Inventario inventario);
        void DeleteCategoria(Inventario inventario);

        List<Inventario> allInventario();
    }
}
