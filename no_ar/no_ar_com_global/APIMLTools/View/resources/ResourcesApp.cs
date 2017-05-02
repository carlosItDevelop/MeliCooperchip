using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Web;

namespace View.resources {
    public class ResourcesApp {
        public static string GetResources(string key)
        {
            var rm = new ResourceManager(typeof(rscConfigApp));
            var valueOfTheKey = rm.GetString(key);
            return valueOfTheKey;            
        }
    }
}