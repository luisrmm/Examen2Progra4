using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistroWeb
{
    public class IDServicio
    {
            private string servicioID; // field

            public IDServicio(string servicioID)
            {
                ServicioID = servicioID;
            }

            public string ServicioID   // property
            {
                get { return servicioID; }   // get method
                set { servicioID = value; }  // set method
            }
        }
}