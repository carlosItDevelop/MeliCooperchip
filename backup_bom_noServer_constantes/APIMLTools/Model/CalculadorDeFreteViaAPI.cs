using System.Collections.Generic;

namespace Model.CalculadorDeFreteViaAPI {


    public class City {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class State {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Country {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class ZipCodeType {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class ExtendedAttributes {
        public string address { get; set; }
        public object owner_name { get; set; }
        public ZipCodeType zip_code_type { get; set; }
        public string city_type { get; set; }
        public string city_name { get; set; }
        public string neighborhood { get; set; }
        public string status { get; set; }
    }

    public class Destination {
        public string zip_code { get; set; }
        public City city { get; set; }
        public State state { get; set; }
        public Country country { get; set; }
        public ExtendedAttributes extended_attributes { get; set; }
    }

    public class Speed {
        public int? shipping { get; set; }
        public int? handling { get; set; }
    }

    public class EstimatedDelivery {
        public string date { get; set; }
        public object pay_before { get; set; }
        public object time_from { get; set; }
        public object time_to { get; set; }
    }

    public class Discount {
        public int? rate { get; set; }
    }

    public class Option {
        public int? id { get; set; }
        public string name { get; set; }
        public int? shipping_method_id { get; set; }
        public string currency_id { get; set; }
        public double? list_cost { get; set; }
        public double? cost { get; set; }
        public string tracks_shipments_status { get; set; }
        public string display { get; set; }
        public Speed speed { get; set; }
        public EstimatedDelivery estimated_delivery { get; set; }
        public Discount discount { get; set; }
    }

    public class CalculadorDeFreteViaAPI {
        public Destination destination { get; set; }
        public List<Option> options { get; set; }
    }

}


