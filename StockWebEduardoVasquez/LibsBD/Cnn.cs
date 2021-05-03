using System.Data.SqlClient;
using System.Windows.Forms;


namespace StockWebEduardoVasquez.LibsBD
{
    class Cnn
    {

        SqlConnection Coneccion = new SqlConnection();
        private string SERVER_NAME       = "DESKTOP-TEDE3GT\\SQLEXPRESS";
        private string DbName            = "inventario";
        private bool   BanderaConnection = false;

        public  SqlConnection openDb()
        {
            
            try
            {

                string cadenaConeccion = "Server=" + SERVER_NAME + ";Database=" + DbName + "; Integrated security = true";
                Coneccion.ConnectionString = cadenaConeccion;
                Coneccion.Open();
                BanderaConnection = true;
                //MessageBox.Show("Conectado");
            }
            catch (SqlException e)
            {
                MessageBox.Show("Error al intenter conectarse a la base de datos" + e);
            }
            return Coneccion;
        }

        public void CloseBd()
        {
            if (BanderaConnection)
            {
                try
                {
                    Coneccion.Close();
                    BanderaConnection = false;
                }
                catch (SqlException e)
                {
                    MessageBox.Show("Error al intenter conectarse a la base de datos" + e);
                }
            }
        }
    }
}
