using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using StockWebEduardoVasquez.LibsBD;
using StockWebEduardoVasquez.Modelo;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StockWebEduardoVasquez.Dao
{
    class DaoCategoriasImp : Cnn, DaoCategorias
    {
        SqlConnection Con = null;
        SqlCommand comand = null;
        public void AddCategoria(Categorias catergoria)
        {

            try
            {
                Con = openDb();
                comand = Con.CreateCommand();
                comand.CommandText = "INSERT INTO Categorias(categoria, habilitar_categoria)"
                    + "VALUES(@categoria, @habilitar_categoria)";
                comand.Prepare();
                comand.Parameters.AddWithValue("@categoria", catergoria.Categoria);
                comand.Parameters.AddWithValue("@habilitar_categoria", catergoria.Habilitar_categoria);
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

        public List<Categorias> allCategorias()
        {
            List<Categorias> listCategorias = new List<Categorias>();
            try
            {
                Con = openDb();
                comand = Con.CreateCommand();
                comand.CommandText = "SELECT * from categorias";
                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    Categorias categorias = new Categorias();
                    categorias.Id = reader.GetInt32("id");
                    categorias.Categoria = reader.GetString("categoria");
                    categorias.Habilitar_categoria = reader.GetBoolean("habilitar_categoria");

                    listCategorias.Add(categorias);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede agregar por " + ex); ;
            }
            finally
            {
                CloseBd();
            }
            return listCategorias;
        }

        public void DeleteCategoria(Categorias catergoria)
        {
            try
            {
                Con = openDb();
                comand = Con.CreateCommand();
                comand.CommandText = "DELETE FROM categorias WHERE id = @id";
                comand.Prepare();
                comand.Parameters.AddWithValue("@id", catergoria.Id);
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

        public void UpdateCategoria(Categorias catergoria)
        {
            try
            {
                Con = openDb();
                comand = Con.CreateCommand();
                comand.CommandText = "UPDATE categorias SET categoria = @categoria, habilitar_categoria = @habilitar_categoria " +
                                     "WHERE id = @id";
                comand.Prepare();
                comand.Parameters.AddWithValue("@categoria", catergoria.Categoria);
                comand.Parameters.AddWithValue("@habilitar_categoria", catergoria.Habilitar_categoria);
                comand.Parameters.AddWithValue("@id", catergoria.Id);
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
