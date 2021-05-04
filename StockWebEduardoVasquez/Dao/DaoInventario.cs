using System;
using System.Collections.Generic;
using System.Text;
using StockWebEduardoVasquez.Modelo;

namespace StockWebEduardoVasquez.Dao
{
    interface DaoInventario
    {
        void AddInventario(Inventario inventario);
        void UpdateInventario(Inventario inventario);
        void DeleteInventario(Inventario inventario);

        List<Inventario> allInventario();
        List<Inventario> allInventario(string Inventario);
        
    }
}
