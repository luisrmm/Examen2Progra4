using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistroWeb
{
    public partial class Reporte : System.Web.UI.Page
    {
       
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRegistrar_Click(object sender, EventArgs e)
        {
            string IDServicio = string.Empty;
            string FechaReporte = string.Empty;
            string HoraTrabajo = string.Empty;
            IDServicio = TxtNumServicio.Text;
            FechaReporte = TxtFecha.Text;
            HoraTrabajo = TxtHoraTra.Text;
            ServiceReferenceReporte.ReporteServiceClient c = new ServiceReferenceReporte.ReporteServiceClient();

            int resultRes = c.InsertReporte(Convert.ToInt32(IDServicio), FechaReporte, Convert.ToInt32(HoraTrabajo));
            if (resultRes == 1)
            {
                c.Factura(Convert.ToInt32(IDServicio));
                lblDatos.Text = "Reporte y factura generada con exito";
            }
            else
            {
                lblDatos.Text = "Reporte no puedo ser registrado";
            }

            
        }
    }
}