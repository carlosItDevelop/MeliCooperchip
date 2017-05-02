using System.Collections.Generic;

namespace Model.SobreAnunciosAlheios {


    public class Paging {
        public int total { get; set; }
        public int offset { get; set; }
        public int limit { get; set; }
    }

    public class Order {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class AvailableOrder {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Value {
        public string id { get; set; }
        public string name { get; set; }
        public int results { get; set; }
    }

    public class AvailableFilter {
        public string id { get; set; }
        public string name { get; set; }
        public List<Value> values { get; set; }
    }


    public class SobreAnunciosAlheios {
        public string seller_id { get; set; }
        public object query { get; set; }
        public Paging paging { get; set; }
        public List<string> results { get; set; }
        public List<Order> orders { get; set; }
        public List<object> filters { get; set; }
        public List<AvailableOrder> available_orders { get; set; }
        public List<AvailableFilter> available_filters { get; set; }
    }

}




