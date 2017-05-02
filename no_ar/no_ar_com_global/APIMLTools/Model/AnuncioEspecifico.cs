using System.Collections.Generic;

namespace Models.AnuncioEspecifico
{


    public class Picture {
        public string id { get; set; }
        public string url { get; set; }
        public string secure_url { get; set; }
        public string size { get; set; }
        public string max_size { get; set; }
        public string quality { get; set; }
    }

    public class Description {
        public string id { get; set; }
    }

    public class Rule {
        public string free_mode { get; set; }
        public List<string> value { get; set; }
    }

    public class FreeMethod {
        public int id { get; set; }
        public Rule rule { get; set; }
    }

    public class Shipping {
        public string mode { get; set; }
        public bool local_pick_up { get; set; }
        public bool free_shipping { get; set; }
        public List<FreeMethod> free_methods { get; set; }
        public object dimensions { get; set; }
        public List<object> tags { get; set; }
    }

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

    public class Neighborhood {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class City2 {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class State2 {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class SearchLocation {
        public Neighborhood neighborhood { get; set; }
        public City2 city { get; set; }
        public State2 state { get; set; }
    }

    public class SellerAddress {
        public int id { get; set; }
        public string comment { get; set; }
        public string address_line { get; set; }
        public string zip_code { get; set; }
        public City city { get; set; }
        public State state { get; set; }
        public Country country { get; set; }
        public double? latitude { get; set; }
        public double? longitude { get; set; }
        public SearchLocation search_location { get; set; }
    }

    public class Location {
    }

    public class Geolocation {
        public double? latitude { get; set; }
        public double? longitude { get; set; }
    }

    public class DifferentialPricing {
        public int id { get; set; }
        public List<int> installments { get; set; }
        public List<string> payment_methods { get; set; }
    }

        public class AnuncioEspecifico
        {
            public string id { get; set; }
            public string site_id { get; set; }
            public string title { get; set; }
            public object subtitle { get; set; }
            public int seller_id { get; set; }
            public string category_id { get; set; }
            public int? official_store_id { get; set; }
            public double price { get; set; }
            public double base_price { get; set; }
            public double? original_price { get; set; }
            public string currency_id { get; set; }
            public int initial_quantity { get; set; }
            public int available_quantity { get; set; }
            public int sold_quantity { get; set; }
            public string buying_mode { get; set; }
            public string listing_type_id { get; set; }
            public string start_time { get; set; }
            public string stop_time { get; set; }
            public string condition { get; set; }
            public string permalink { get; set; }
            public string thumbnail { get; set; }
            public string secure_thumbnail { get; set; }
            public List<Picture> pictures { get; set; }
            public object video_id { get; set; }
            public List<Description> descriptions { get; set; }
            public bool accepts_mercadopago { get; set; }
            public List<object> non_mercado_pago_payment_methods { get; set; }
            public Shipping shipping { get; set; }
            public SellerAddress seller_address { get; set; }
            public object seller_contact { get; set; }
            public Location location { get; set; }
            public Geolocation geolocation { get; set; }
            public List<object> coverage_areas { get; set; }
            public List<object> attributes { get; set; }
            public string listing_source { get; set; }
            public List<object> variations { get; set; }
            public string status { get; set; }
            public List<object> sub_status { get; set; }
            public List<string> tags { get; set; }
            public string warranty { get; set; }
            public object catalog_product_id { get; set; }
            public string parent_item_id { get; set; }
            public DifferentialPricing differential_pricing { get; set; }
            public List<string> deal_ids { get; set; }
            public bool automatic_relist { get; set; }
            public string date_created { get; set; }
            public string last_updated { get; set; }
        }

}


