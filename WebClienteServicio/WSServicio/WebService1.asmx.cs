
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WSServicio
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
       
        private int intced;

        [WebMethod]
        public string Validar(int ced)
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
                intced = Convert.ToInt32(reader["IDCliente"].ToString());

            }
            if (ced.Equals(intced))
            {
                return "Usario encontrado.";
            }
            else
            {
                return "Error usario inexistente.";
            }
        }
    }
}
