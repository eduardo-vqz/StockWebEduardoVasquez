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
    class DaoSucursalesImp : Cnn, DaoSucurles
    {
        SqlConnection Con = null;
        SqlCommand comand = null;
        public void AddSucursal(Sucursales sucursales)
        {
            try
            {
                Con = openDb();
                comand = Con.CreateCommand();
                comand.CommandText = "INSERT INTO sucursales(sucursal, direccion, telefono, habilitar_sucursal)"
                    + "VALUES(@sucursal, @direccion, @telefono, @habilitar_sucursal)";
                comand.Prepare();
                comand.Parameters.AddWithValue("@sucursal", sucursales.Sucursal);
                comand.Parameters.AddWithValue("@direccion", sucursales.Direccion);
                comand.Parameters.AddWithValue("@telefono", sucursales.Telefono);
                comand.Parameters.AddWithValue("@habilitar_sucursal", sucursales.Habilitar_sucursal);
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

        public List<Sucursales> allSucursales()
        {
            List<Sucursales> listSucursales = new List<Sucursales>();
            try
            {
                Con = openDb();
                comand = Con.CreateCommand();
                comand.CommandText = "SELECT * from sucursales";
                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    Sucursales sucursales = new Sucursales();
                    sucursales.Id = reader.GetInt32("id");
                    sucursales.Sucursal = reader.GetString("sucursal");
                    sucursales.Direccion = reader.GetString("direccion");
                    sucursales.Telefono = reader.GetString("telefono");
                    sucursales.Habilitar_sucursal = reader.GetBoolean("habilitar_sucursal");

                    listSucursales.Add(sucursales);
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
            return listSucursales;
        }

        public List<Sucursales> allSucursales(string sucursal)
        {
            throw new NotImplementedException();
        }

        public void DeleteSucursal(Sucursales sucursales)
        {
            try
            {
                Con = openDb();
                comand = Con.CreateCommand();
                comand.CommandText = "DELETE FROM sucursales WHERE id = @id";
                comand.Prepare();
                comand.Parameters.AddWithValue("@id", sucursales.Id);
                comand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede eliminar por: " + ex);
            }
            finally
            {
                CloseBd();
            }
        }

        public void UpdateSucursal(Sucursales sucursales)
        {
            try
            {
                Con = openDb();
                comand = Con.CreateCommand();
                comand.CommandText = "UPDATE sucursales " +
                    "SET sucursal = @sucursal, direccion = @direccion, telefono = @telefono, habilitar_sucursal = @habilitar_sucursal " +
                    "WHERE id = @id";
                comand.Prepare();
                comand.Parameters.AddWithValue("@sucursal", sucursales.Sucursal);
                comand.Parameters.AddWithValue("@direccion", sucursales.Direccion);
                comand.Parameters.AddWithValue("@telefono", sucursales.Telefono);
                comand.Parameters.AddWithValue("@habilitar_sucursal", sucursales.Habilitar_sucursal);
                comand.Parameters.AddWithValue("@id", sucursales.Id);
                comand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede actualizar por: " + ex);
            }
            finally
            {
                CloseBd();
            }
        }
    }
}
