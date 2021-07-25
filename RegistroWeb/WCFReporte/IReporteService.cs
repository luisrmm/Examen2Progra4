using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFReporte
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IReporteService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IReporteService
    {
        [OperationContract]
        string IDServicio();

        [OperationContract]
        int InsertReporte(int IDServicio, string FechaReporte, int HoraTrabajo);

        [OperationContract]
        int Factura(int IDServicio);

    }
}
