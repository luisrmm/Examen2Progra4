using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;

namespace WCFReporte
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ReporteService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ReporteService.svc o ReporteService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ReporteService : IReporteService
    {

        ArrayList servicio = new ArrayList();
        string ruta = @"C:\Users\luisr\Documents\Examen2Progra4\FacturaJson\JsonFactura.Json";
        public string IDServicio()
        {
            // 127.0.0.1 es de localhost y el puerto predeterminado para conectar
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=admin;database=servicioinfor;";
            // Prepara la conexión
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            MySqlCommand cmd = databaseConnection.CreateCommand();
            cmd.CommandText = "SELECT * FROM servicio";

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
            Console.WriteLine(reader);
            while (reader.Read())
            {
                
                string servicioID = (reader["IDServicio"].ToString());
                IDServicio c = new IDServicio(servicioID);
                servicio.Add(c);
               

            }
            return "";
        }

        [Obsolete]
        public int Factura(int IDServicio)
        {
            // 127.0.0.1 es de localhost y el puerto predeterminado para conectar
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=admin;database=servicioinfor;";
            // Prepara la conexión
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            MySqlCommand cmd = databaseConnection.CreateCommand();
            cmd.CommandText = "SELECT  reporte.Reporte, trabajador.IDTrabajador,trabajador.NombreTrabajador, tiposervicio.IDTipoServicio, tiposervicio.NombreTipoServicio, cliente.IDCliente, cliente.NombreCliente,cliente.Correo, tiposervicio.Precio\n"
                                + "FROM reporte\n"
                                + "INNER JOIN servicio ON servicio.IDServicio = reporte.IDServicio\n"
                                + "INNER JOIN cliente ON cliente.IDCliente = servicio.IDCliente\n"
                                + "INNER JOIN tiposervicio ON tiposervicio.IDTipoServicio = servicio.IDTipoServicio\n"
                                + "INNER JOIN trabajador ON trabajador.IDTrabajador = tiposervicio.IDTrabajador\n"
                                + "WHERE servicio.IDServicio= " + IDServicio + ";";
  


            try
            {
                databaseConnection.Open();
            }
            catch (Exception erro)
            {
                Console.WriteLine("Error" + erro);
                databaseConnection.Close();
            }

            MySqlDataReader rdr = cmd.ExecuteReader();
            Console.WriteLine(rdr);
            while (rdr.Read())
            {
                string Reporte =(rdr["Reporte"].ToString());
                string IDTrabajador = (rdr["IDTrabajador"].ToString());
                string NombreTrabajador = (rdr["NombreTrabajador"].ToString());
                string IDTipoServicio = (rdr["IDTipoServicio"].ToString());
                string NombreTipoServicio = (rdr["NombreTipoServicio"].ToString());
                string IDCliente = (rdr["IDCliente"].ToString());
                string NombreCliente = (rdr["NombreCliente"].ToString());
                string Correo = (rdr["Correo"].ToString());
                string Precio = (rdr["Precio"].ToString());
                Factura c = new Factura(int.Parse(Reporte), int.Parse(IDTrabajador), NombreTrabajador, int.Parse(IDTipoServicio), NombreTipoServicio, int.Parse(IDCliente), NombreCliente, Correo, int.Parse(Precio));
                string json = JsonConvert.SerializeObject(c);
                string rutaCompleta = ruta;
                string texto = json;
                using (StreamWriter mylogs = File.AppendText(rutaCompleta))
                {
                    mylogs.WriteLine(texto); //se agrega información al documento

                    mylogs.Close();
                }
                try
                {
                    string filename = ruta;
                    Attachment data = new Attachment(filename, MediaTypeNames.Application.Octet);

                    SmtpClient client = new SmtpClient();
                    client.Port = 587;
                    // utilizamos el servidor SMTP de gmail
                    client.Host = "smtp.gmail.com";
                    client.EnableSsl = true;
                    client.Timeout = 10000;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    // nos autenticamos con nuestra cuenta de gmail
                    client.Credentials = new NetworkCredential("o.cempresa12@gmail.com", "empresa123");

                    MailMessage mail = new MailMessage("o.cempresa12@gmail.com", Correo, "Factura", "Buenas, le adjunto la factura del servicio contratado");
                    mail.BodyEncoding = UTF8Encoding.UTF8;
                    mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                    mail.Attachments.Add(data);
                    client.Send(mail);
                }
                catch (Exception ep)
                {
                    Console.WriteLine("failed to send email with the following error:");
                    Console.WriteLine(ep.Message);
                }
            }

            return 1;
        }
       

        public int InsertReporte(int IDServicio, string FechaReporte, int HoraTrabajo)
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

            cmd.CommandText = "INSERT INTO reporte(IDServicio, FechaReporte, HoraTrabajo) VALUES(@IDServicio, @FechaReporte, @HoraTrabajo)";
            cmd.Parameters.AddWithValue("@IDServicio", IDServicio);
            cmd.Parameters.AddWithValue("@FechaReporte", FechaReporte);
            cmd.Parameters.AddWithValue("@HoraTrabajo", HoraTrabajo);
            if (cmd.ExecuteNonQuery() == 1) //Aqui se hace 2 veces el inseert
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
