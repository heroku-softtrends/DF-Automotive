using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDFAutomotive
{
    public sealed class ConfigVars
    {
        public string VIN = string.Empty;
        public string IOTToken = string.Empty;
        public string EnpointUrl = string.Empty;
        public string IronMQUrl = string.Empty;
        public string IronMQProjectID = string.Empty;
        public string IronMQToken = string.Empty;
        private ConfigVars()
        {
            VIN = Environment.GetEnvironmentVariable("VIN");
            IOTToken = Environment.GetEnvironmentVariable("iotToken");
            EnpointUrl = Environment.GetEnvironmentVariable("endpointURL");
            IronMQUrl = Environment.GetEnvironmentVariable("queueURL");
            IronMQProjectID = Environment.GetEnvironmentVariable("IRON_MQ_PROJECT_ID");
            IronMQToken = Environment.GetEnvironmentVariable("IRON_MQ_TOKEN");

            //for local testing
            //VIN = "4A3AK34T58E008515";
            //IOTToken = "Bearer 279OC5MYsEqkVwBdWqTMMixlePISTXgfvLUFJJ8luCScsIq8P4svqPfjhEhawnuzAt20KiqvT9ae36XM3YXcFU";
            //EnpointUrl = "https://ingestion-xcdvudaz0dz3.us3.sfdcnow.com/streams/automotive_sales_001/car_events001/event";
            //IronMQUrl = "https://mq-aws-eu-west-1-1.iron.io/3/projects/57e657540e8c650007ec1ef9/queues/automotive_messages";
            //IronMQToken = "On5WZgi25eKM7Pb7yeL7";
        }
        public static ConfigVars Instance { get { return ConfigVarInstance.Instance; } }

        private class ConfigVarInstance
        {
            static ConfigVarInstance()
            {
            }

            internal static readonly ConfigVars Instance = new ConfigVars();
        }
    }
}
