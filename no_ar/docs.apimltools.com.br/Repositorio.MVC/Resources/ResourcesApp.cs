using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Web;
using Microsoft.Ajax.Utilities;

namespace Repositorio.MVC.Resources {
    public class ResourcesApp {

        public static string GetResources(string key)
        {
            var rm = new ResourceManager(typeof(rscConstantes));
            var valueOfTheKey = rm.GetString(key);
            return valueOfTheKey;
        }
        
    }
}