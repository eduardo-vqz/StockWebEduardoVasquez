using System;
using System.Collections.Generic;
using System.Text;
using StockWebEduardoVasquez.Modelo;

namespace StockWebEduardoVasquez.Dao
{
    interface DaoSucursal_electrodomestico
    {
        void AddCategoria(Sucursal_electrodomestico sucursal_electrodomestico);
        void UpdateCategoria(Sucursal_electrodomestico sucursal_electrodomestico);
        void DeleteCategoria(Sucursal_electrodomestico sucursal_electrodomestico);

        List<Sucursal_electrodomestico> allSucursal_electrodomestico();
    }
}
