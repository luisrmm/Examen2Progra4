using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceServicio
{
    public class Servicio
    {
        private string Nombre;
        private int Precio;
        private string Fecha;
        
        public Servicio(string nombre, int precio, string fecha)
        {
            Nombre = nombre;
            Precio = precio;
            Fecha = fecha;
        }
    }
}