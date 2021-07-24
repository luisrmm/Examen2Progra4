using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebRegistroServicio.ServicioWS;


namespace WebRegistroServicio
{
   
    public partial class RegistroServicio : System.Web.UI.Page
    {
        private Random gen = new Random();
        DateTime RandomDay()
        {
            DateTime start = new DateTime(2021, 9, 28);
            int range = (start - DateTime.Today).Days;
            return start.AddDays(gen.Next(range));
        }


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRegistrar_Click(object sender, EventArgs e)
        {
            ArrayList dataservicio = new ArrayList();
            string cedula = "";
          
            int tipServicio = 0;
            DateTime f = RandomDay();
            string fecha = f.ToString();
            fecha = fecha.Remove(fecha.Length - 9);
            cedula = TxtCedula.Text;
            tipServicio = int.Parse(DDLTipServicio.SelectedItem.Value);
            WebServiceServicioSoapClient c = new WebServiceServicioSoapClient();
            int result = c.Validar(cedula);
            if (result == 1)
            {

                int resultRes = c.InsertarServicio(int.Parse(cedula), tipServicio, fecha);
                if (resultRes == 1)
                {
                   //dataservicio = c.MostrarServicio(cedula);
                   
                }
                else
                {
                    LblMensaje.Text = "\nNo se pudo registrar el servicio";
                }
            }
            else
            {
                LblMensaje.Text = "\nError usuario no esta registrado";
            }




        }
    }
}