using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.IO;
using Newtonsoft.Json;

namespace TopSpotsAPI.Models
{
    public class TopSpot
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double[] Location { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0} \nDescription: {1} \nLocation: {2}", Name,Description,Location);
        }
    }

    
    
}