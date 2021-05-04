using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

using StockWebEduardoVasquez.LibsBD;
using StockWebEduardoVasquez.Modelo;


namespace StockWebEduardoVasquez.Dao
{
    class DaoSucursal_electrodomesticoImp : Cnn, DaoSucursal_electrodomestico
    {

        SqlConnection Con = null;
        SqlCommand comand = null;
        public void AddSucursal_electrodomestico(Sucursal_electrodomestico sucursal_electrodomestico)
        {
            try
            {
                Con = openDb();
                comand = Con.CreateCommand();
                comand.CommandText = "INSERT INTO sucursal_electrodomestico(sucursal_id, electrodomestico_id, cantidad)"
                    + "VALUES(@sucursal_id, @electrodomestico_id, @cantidad)";
                comand.Prepare();
                comand.Parameters.AddWithValue("@sucursal_id", sucursal_electrodomestico.Sucursales.Id);
                comand.Parameters.AddWithValue("@electrodomestico_id", sucursal_electrodomestico.Electrodomesticos.Id);
                comand.Parameters.AddWithValue("@cantidad", sucursal_electrodomestico.Cantidad);
                comand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                MessageBox.Show("El error es " + ex);
            }
            finally
            {
                CloseBd();
            }
        }

        public List<Sucursal_electrodomestico> allSucursal_electrodomestico()
        {
            List<Sucursal_electrodomestico> listSucursal_electrodomestico = new List<Sucursal_electrodomestico>();
            try
            {
                Con = openDb();
                comand = Con.CreateCommand();
                comand.CommandText = "SELECT sucursal_electrodomestico.id, electrodomesticos.nombre_electrodomestico, sucursales.sucursal, sucursal_electrodomestico.cantidad " +
                                    "FROM sucursales " +
                                    "INNER JOIN sucursal_electrodomestico ON (sucursal_electrodomestico.sucursal_id = sucursales.id) " +
                                    "INNER JOIN electrodomesticos ON (sucursal_electrodomestico.electrodomestico_id = electrodomesticos.id)";
                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    Sucursal_electrodomestico sucursal_electrodomestico = new Sucursal_electrodomestico();
                    sucursal_electrodomestico.Id = reader.GetInt32("id");
                    sucursal_electrodomestico.Electrodomesticos.Nombre_electrodomestico = reader.GetString("nombre_electrodomestico");
                    sucursal_electrodomestico.Sucursales.Sucursal = reader.GetString("sucursal");
                    sucursal_electrodomestico.Cantidad = reader.GetInt32("cantidad");
                    listSucursal_electrodomestico.Add(sucursal_electrodomestico);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostar los registros " + ex); ;
            }
            finally
            {
                CloseBd();
            }

            return listSucursal_electrodomestico;
        }

        public void DeleteSucursal_electrodomestico(Sucursal_electrodomestico sucursal_electrodomestico)
        {
            throw new NotImplementedException();
        }

        public void UpdateSucursal_electrodomestico(Sucursal_electrodomestico sucursal_electrodomestico)
        {
            throw new NotImplementedException();
        }
    }
}
