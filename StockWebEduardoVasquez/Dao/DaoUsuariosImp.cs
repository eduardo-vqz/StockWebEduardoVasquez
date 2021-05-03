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
    class DaoUsuariosImp : Cnn, DaoUsuarios
    {
        SqlConnection Con = null;
        SqlCommand comand = null;
        public void AddUser(Usuarios usuarios)
        {
            try
            {
                Con = openDb();
                comand = Con.CreateCommand();
                comand.CommandText = "INSERT INTO USUARIOS(nombre, apellidos, usuario, pw) "
                    + "VALUES(@nombre, @apellidos, @usuario, @pw)";
                comand.Prepare();
                comand.Parameters.AddWithValue("@nombre", usuarios.Nombre);
                comand.Parameters.AddWithValue("@apellidos", usuarios.Apellidos);
                comand.Parameters.AddWithValue("@usuario", usuarios.Usuario);
                comand.Parameters.AddWithValue("@pw", usuarios.Pw);
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

        public void UpdateUser(Usuarios usuarios)
        {
            try
            {
                Con = openDb();
                comand = Con.CreateCommand();
                comand.CommandText = "UPDATE usuarios " +
                    "SET nombre = @nombre, apellidos = @apellidos, usuario = @usuario, pw = @pw " +
                    "WHERE id = @id";
                comand.Prepare();
                comand.Parameters.AddWithValue("@nombre", usuarios.Nombre);
                comand.Parameters.AddWithValue("@apellidos", usuarios.Apellidos);
                comand.Parameters.AddWithValue("@usuario", usuarios.Usuario);
                comand.Parameters.AddWithValue("@pw", usuarios.Pw);
                comand.Parameters.AddWithValue("@id", usuarios.Id);
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

        public void DeleteUser(Usuarios usuarios)
        {
            try
            {
                Con = openDb();
                comand = Con.CreateCommand();
                comand.CommandText = "DELETE FROM usuarios WHERE id = @id";
                comand.Prepare();
                comand.Parameters.AddWithValue("@id", usuarios.Id);
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

        public List<Usuarios> allUser()
        {
            List<Usuarios> listUsuarios = new List<Usuarios>();
            try
            {
                Con = openDb();
                comand = Con.CreateCommand();
                comand.CommandText = "SELECT * from usuarios";
                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    Usuarios usuarios = new Usuarios();
                    usuarios.Id = reader.GetInt32("id");
                    usuarios.Nombre = reader.GetString("nombre");
                    usuarios.Apellidos = reader.GetString("apellidos");
                    usuarios.Usuario = reader.GetString("usuario");
                    usuarios.Pw = reader.GetString("pw");

                    listUsuarios.Add(usuarios);
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
            return listUsuarios;
        }

        public List<Usuarios> allUser(string user)
        {
            throw new NotImplementedException();
        }

        

    }
}
