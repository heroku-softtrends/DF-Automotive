using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDFAutomotive.Models
{
    public class IOTEventRequest
    {
        public string VIN { get; set; }
        public int mileage { get; set; }
        public string errorCode { get; set; }
        public int lifetimeMpg { get; set; }
        public int lifetimeDrivingTime { get; set; }
        public int lifetimeEcoTime { get; set; }
        public IOTTrip trip { get; set; }
    }
}
