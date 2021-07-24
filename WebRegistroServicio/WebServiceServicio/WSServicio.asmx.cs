using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceServicio
{
    /// <summary>
    /// Descripción breve de WSServicio
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WSServicio : System.Web.Services.WebService
    {
        private string intced;

        [WebMethod]
        public int Validar(string ced)
        {


            // 127.0.0.1 es de localhost y el puerto predeterminado para conectar
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=admin;database=servicioinfor;";
            // Prepara la conexión
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            MySqlCommand cmd = databaseConnection.CreateCommand();
            cmd.CommandText = "SELECT IDCliente from cliente WHERE IDCliente = '" + ced + "'";

            try
            {
                databaseConnection.Open();
            }
            catch (Exception erro)
            {
                Console.WriteLine("Error" + erro);
                databaseConnection.Close();
}

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                intced = reader["IDCliente"].ToString();

            }
            if (ced.Equals(intced))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        [WebMethod]
        public int InsertarServicio(string ced, int tipServ, string fecha)
        {


            // 127.0.0.1 es de localhost y el puerto predeterminado para conectar
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=admin;database=servicioinfor;";
            // Prepara la conexión
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            MySqlCommand cmd = databaseConnection.CreateCommand();
            
            try
            {
                databaseConnection.Open();
            }
            catch (Exception erro)
            {
                Console.WriteLine("Error" + erro);
                databaseConnection.Close();
            }

            cmd.CommandText = "insert into servicio(IDCliente, IDTipoServicio, FechaServicio) values(" + ced + "," + tipServ + ",'" + fecha + "');";
            cmd.CommandText = "INSERT INTO servicio(IDCliente, IDTipoServicio, FechaServicio) VALUES(@IDCliente, @IDTipoServicio, @FechaServicio)";
            cmd.Parameters.AddWithValue("@IDCliente", ced);
            cmd.Parameters.AddWithValue("@IDTipoServicio", tipServ);
            cmd.Parameters.AddWithValue("@FechaServicio", fecha);
            cmd.ExecuteNonQuery();
            if (cmd.ExecuteNonQuery() == 1)
            {
                databaseConnection.Close();
                return 1;
            
            }
            else
            {
                databaseConnection.Close();
                return 0;
            }
           
        }

    }
}
