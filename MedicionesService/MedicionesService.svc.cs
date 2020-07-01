using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.IO;
using System.ServiceModel.Channels;

namespace MedicionesService {

    public class MedicionesService : IMedicionesService {

        /* 
         * insertar las mediciones recibidas por el metodo getMediciones
         */

        public string insertaMediciones(Medidor[] medidores) {

            string respuesta = "Respuesta del WS";
            
            return (respuesta);
        }


    


        public string agregaMediciones(Medidor[] medidores) {
            //string resultado = "OK";
            string resultado = insertaMediciones(medidores);
            return resultado;

        }

       


    }   // IMedicionesService


}   //MedicionesService
