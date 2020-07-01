using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MedicionService
{

    [ServiceContract]
    public interface IMedicionesService
    {
        [OperationContract]
        string AgregaMediciones(Medicion mediciones);

    }

   // [DataContract]
  //  public class Medidor
  //  {
  //      [DataMember]
  //      public string Clave { get; set; }
  //      [DataMember]
  //      public Medicion[] Mediciones { get; set; }


  //  }

    [DataContract]
    public class Medicion
    {
        [DataMember]
        public string Clave
        {
            get;
            set;
        }

        [DataMember]
        public Valor[] Mediciones
        {
            get;
            set;
        }

    }

    [DataContract]
    public class Valor
    {

        [DataMember]
        public DateTimeOffset Fecha
        {
            get;
            set;
        }

        [DataMember]
        public double Valor
        {
            get;
            set;
        }

    }
}