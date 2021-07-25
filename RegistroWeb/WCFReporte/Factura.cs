using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFReporte
{
    public class Factura
    {
        public Factura(int reporte, int iDTrabajador, string nombreTrabajador, int iDTipoServicio, string nombreTipoServicio, int iDCliente, string nombreCliente, string correo, int precio)
        {
            Reporte = reporte;
            IDTrabajador = iDTrabajador;
            NombreTrabajador = nombreTrabajador;
            IDTipoServicio = iDTipoServicio;
            NombreTipoServicio = nombreTipoServicio;
            IDCliente = iDCliente;
            NombreCliente = nombreCliente;
            Correo = correo;
            Precio = precio;
        }

        public int Reporte { get; set; }
        public int IDTrabajador { get; set; }
        public string NombreTrabajador { get; set; }
        public int IDTipoServicio { get; set; }
        public string NombreTipoServicio { get; set; }
        public int IDCliente { get; set; }
        public string NombreCliente { get; set; }
        public string Correo { get; set; }
        public int Precio { get; set; }
       

    }
}