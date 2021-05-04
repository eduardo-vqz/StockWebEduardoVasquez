using System;
using System.Collections.Generic;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using StockWebEduardoVasquez.LibsBD;
using StockWebEduardoVasquez.Modelo;

namespace StockWebEduardoVasquez.Dao
{
    class DaoElectrodomesticosImp : Cnn, DaoElectrodomesticos
    {
        SqlConnection Con  = null;
        SqlCommand comand = null;
        public void AddElectrodomestico(Electrodomestico electrodomestico)
        {
            try
            {
                Con = openDb();
                comand = Con.CreateCommand();
                comand.CommandText = "INSERT INTO electrodomesticos(nombre_electrodomestico, categoria_id, habilitar_electrodomestico) "
                    + "VALUES(@nombre_electrodomestico, @categoria_id, @habilitar_electrodomestico)";
                comand.Prepare();
                comand.Parameters.AddWithValue("@nombre_electrodomestico", electrodomestico.Nombre_electrodomestico);
                comand.Parameters.AddWithValue("@categoria_id", electrodomestico.Categorias.Id);
                comand.Parameters.AddWithValue("@habilitar_electrodomestico", electrodomestico.Habilitar_electrodomestico);
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
        public List<Electrodomestico> allElectrodomesticos()
        {
            List<Electrodomestico> listElectrodomestico = new List<Electrodomestico>();
            try
            {
                Con = openDb();
                comand = Con.CreateCommand();
                comand.CommandText = "SELECT electrodomesticos.id, electrodomesticos.nombre_electrodomestico, categorias.categoria, electrodomesticos.habilitar_electrodomestico "+
                                    "FROM electrodomesticos "+
                                    "INNER JOIN categorias ON(electrodomesticos.categoria_id = categorias.id)";
                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    Categorias categorias = new Categorias();
                    Electrodomestico electrodomestico = new Electrodomestico();
                    electrodomestico.Id                         = reader.GetInt32("id");
                    electrodomestico.Nombre_electrodomestico    = reader.GetString("nombre_electrodomestico");
                    electrodomestico.Categorias.Categoria       = reader.GetString("categoria");
                    electrodomestico.Habilitar_electrodomestico = reader.GetBoolean("habilitar_electrodomestico");
                    listElectrodomestico.Add(electrodomestico);
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

            return listElectrodomestico;
        }

        public List<Electrodomestico> allElectrodomesticos(string electrodomestico)
        {
            throw new NotImplementedException();
        }

        public void DeleteElectrodomestico(Electrodomestico electrodomesticos)
        {
            try
            {
                Con = openDb();
                comand = Con.CreateCommand();
                comand.CommandText = "DELETE FROM electrodomesticos WHERE id = @id";
                comand.Prepare();
                comand.Parameters.AddWithValue("@id", electrodomesticos.Id);
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

        public void UpdateElectrodomestico(Electrodomestico electrodomesticos)
        {
             try
            {
                Con = openDb();
                comand = Con.CreateCommand();
                comand.CommandText = "UPDATE electrodomesticos " +
                    "SET nombre_electrodomestico = @nombre_electrodomestico, categoria_id = @categoria_id, habilitar_electrodomestico = @habilitar_electrodomestico " +
                    "WHERE id = @id";
                comand.Prepare();
                comand.Parameters.AddWithValue("@nombre_electrodomestico", electrodomesticos.Nombre_electrodomestico);
                comand.Parameters.AddWithValue("@categoria_id", electrodomesticos.Categorias.Id);
                comand.Parameters.AddWithValue("@habilitar_electrodomestico", electrodomesticos.Habilitar_electrodomestico);
                comand.Parameters.AddWithValue("@id", electrodomesticos.Id);
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
