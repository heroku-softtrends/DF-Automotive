using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDFAutomotive.Models
{
    public class AutomotiveEventRequest
    {
        public string VIN { get; set; }
        public int mileage { get; set; }
        public string error_code { get; set; }
        public int mpg { get; set; }
        public int drivingTime { get; set; }
        public int ecoTime { get; set; }
    }
}
