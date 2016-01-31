using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExcellaMobileApp.Models
{

    public class Entrance
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string StationCode1 { get; set; }
        public string StationCode2 { get; set; }
        public string Description { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
    }

    public class RootObject
    {
        public List<Entrance> Entrances { get; set; }
    }
}