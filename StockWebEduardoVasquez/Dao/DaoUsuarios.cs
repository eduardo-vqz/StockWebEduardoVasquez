using System;
using System.Collections.Generic;
using System.Text;
using StockWebEduardoVasquez.Modelo;

namespace StockWebEduardoVasquez.Dao
{
    interface DaoUsuarios
    {
        void AddUser(Usuarios usuarios);

        void UpdateUser(Usuarios usuarios);

        void DeleteUser(Usuarios usuarios);

        List<Usuarios> allUser();

    }
}
