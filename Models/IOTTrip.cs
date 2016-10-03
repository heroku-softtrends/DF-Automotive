using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDFAutomotive.Models
{
    public class IOTTrip
    {
        public int id { get; set; }
        public int suspensionWeight { get; set; }
        public int brakeEvents { get; set; }
        public int avgSpeed { get; set; }
        public int length { get; set; }
        public int duration { get; set; }
        public int mpg { get; set; }
        public int ecoTime { get; set; }
        public int passengerCount { get; set; }
        public int currentRange { get; set; }
        public int childLock { get; set; }
        public bool gpsActive { get; set; }
        public int climateControlTarget { get; set; }
        public int climateControlEnergyUse { get; set; }
        public int internalTemp { get; set; }
        public int externalTemp { get; set; }
        public int oilLife { get; set; }
        public string driverAlert { get; set; }
        public string serviceNeeded { get; set; }
        public int latitude { get; set; }
        public int longitude { get; set; }
    }
}
