using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MedicionesService {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMedicionesService" in both code and config file together.
    [ServiceContract]
    public interface IMedicionesService {
        [OperationContract]
        string agregaMediciones(Medidor[] medidores);

    }

    [DataContract]
    public class Medidor {
        private string ClaveField;
        private Medicion[] MedicionesField;



        [DataMember]
        public string Clave {
            get { return ClaveField; }
            set { ClaveField = value; }
        }

        [DataMember]
        public Medicion[] Mediciones {
            get { return MedicionesField; }
            set { MedicionesField = value; }
        }


    }

    [DataContract]
    public class Medicion {
        private string ClaveField;
        Valor[] ValoresField;

        [DataMember]
        public string Clave {
            get { return ClaveField; }
            set { ClaveField = value; }
        }

        [DataMember]
        internal Valor[] Valores {
            get { return ValoresField; }
            set { ValoresField = value; }
        }

    }

    [DataContract]
    public class Valor {
        private DateTimeOffset FechaOffsetField;
        private decimal ValField;

        [DataMember]
        public DateTimeOffset FechaOffset {
            get { return FechaOffsetField; }
            set { FechaOffsetField = value; }
        }

        [DataMember]
        public decimal Val {
            get { return ValField; }
            set { ValField = value; }
        }

    }
}
