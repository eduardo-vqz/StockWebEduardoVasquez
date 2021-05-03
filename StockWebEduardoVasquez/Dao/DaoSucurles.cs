using System;
using System.Collections.Generic;
using System.Text;
using StockWebEduardoVasquez.Modelo;

namespace StockWebEduardoVasquez.Dao
{
    interface DaoSucurles
    {

        void AddSucursal(Sucursales sucursales);
        void UpdateSucursal(Sucursales sucursales);
        void DeleteSucursal(Sucursales sucursales);

        List<Sucursales> allSucursales();
        List<Sucursales> allSucursales(string sucursal);

    }
}
