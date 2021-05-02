using System;
using System.Collections.Generic;
using System.Text;
using StockWebEduardoVasquez.Modelo;


namespace StockWebEduardoVasquez.Dao
{
    interface DaoElectrodomesticos
    {
        void AddCategoria(Electrodomesticos electrodomesticos);
        void UpdateCategoria(Electrodomesticos electrodomesticos);
        void DeleteCategoria(Electrodomesticos electrodomesticos);

        List<Electrodomesticos> allElectrodomesticos();
        List<Electrodomesticos> allElectrodomesticos(string electrodomestico);

    }
}
