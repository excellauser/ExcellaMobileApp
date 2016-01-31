using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ExcellaMobileApp.Models
{

    public class Entrance
    {

        [DataMember]
        public string ID { get; set; }

        [DataMember]
        public string Name { get; set; }

            [DataMember]
       public string StationCode1 { get; set; }

        [DataMember]
        public string StationCode2 { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public double Lat { get; set; }

        [DataMember(Name = "StationLongitude")]
        public double Lon { get; set; }
    }

   
    public class RootObject
    {
        public List<Entrance> Entrances { get; set; }
    }
}