using System;
using System.Collections.Generic;
using System.Text;
using StockWebEduardoVasquez.Modelo;


namespace StockWebEduardoVasquez.Dao
{
    interface DaoElectrodomesticos
    {
        void AddElectrodomestico(Electrodomestico electrodomestico);
        void UpdateElectrodomestico(Electrodomestico electrodomestico);
        void DeleteElectrodomestico(Electrodomestico electrodomestico);

        List<Electrodomestico> allElectrodomesticos();
        List<Electrodomestico> allElectrodomesticos(string electrodomestico);

    }
}
