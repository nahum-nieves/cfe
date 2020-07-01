using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Net;
using Newtonsoft.Json;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.

namespace MedicionService
{

    public class MedicionService : IMedicionesService
    {
        public string InsertaMediciones(Medicion mediciones){
           
            
            var json = JsonConvert.SerializeObject(mediciones);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

           




            HttpWebRequest request = WebRequest.Create("https://arena-dev.nxtlab.mx/api/cfe/mediciones") as HttpWebRequest;
            request.Method = "POST";
            request.ContentType = "application/json; charset=utf-8";
            string respuesta = "Respuesta del WS";
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            return (respuesta);
        }

        public string AgregaMediciones(Medicion mediciones){
            //string resultado = "OK";
            string resultado = InsertaMediciones(mediciones);
            return resultado;

        }
    }   
}
