using System;
using System.Collections.Generic;
using System.Text;
using StockWebEduardoVasquez.Modelo;

namespace StockWebEduardoVasquez.Dao
{
    interface DaoSucursal_electrodomestico
    {
        void AddSucursal_electrodomestico(Sucursal_electrodomestico sucursal_electrodomestico);
        void UpdateSucursal_electrodomestico(Sucursal_electrodomestico sucursal_electrodomestico);
        void DeleteSucursal_electrodomestico(Sucursal_electrodomestico sucursal_electrodomestico);

        List<Sucursal_electrodomestico> allSucursal_electrodomestico();
    }
}
