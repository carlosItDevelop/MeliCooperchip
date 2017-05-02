using System.Collections.Generic;

namespace Models.seller
{

    // Esta era a antiga versão para a classe Vendedor a nova está em newVendedor, que ainda não processei no código
    // e está dando erro em frmAnunciosporVendedor.aspx;

    public class SellerReputation
    {
        public object power_seller_status { get; set; }
    }

    public class Seller
    {
        public int id { get; set; }
        public SellerReputation seller_reputation { get; set; }
        public bool real_estate_agency { get; set; }
        public bool car_dealer { get; set; }
    }


    public class Seller2
    {
        public int id { get; set; }
        public object power_seller_status { get; set; }
        public bool car_dealer { get; set; }
        public bool real_estate_agency { get; set; }
    }

    public class Installments
    {
        public int quantity { get; set; }
        public double amount { get; set; }
        public string currency_id { get; set; }
    }

    public class Address
    {
        public string state_id { get; set; }
        public string state_name { get; set; }
        public string city_id { get; set; }
        public string city_name { get; set; }
    }

    public class Shipping
    {
        public bool free_shipping { get; set; }
        public string mode { get; set; }
    }



    public class SellerAddress
    {
        public int id { get; set; }
        public string comment { get; set; }
        public string address_line { get; set; }
        public string zip_code { get; set; }
        public Country country { get; set; }
        public State state { get; set; }
        public City city { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
    }

    public class Result
    {
        public string id { get; set; }
        public string site_id { get; set; }
        public string title { get; set; }
        public string subtitle { get; set; }
        public Seller2 seller { get; set; }
        public double price { get; set; }
        public string currency_id { get; set; }
        public int available_quantity { get; set; }
        public int sold_quantity { get; set; }
        public string buying_mode { get; set; }
        public string listing_type_id { get; set; }
        public string stop_time { get; set; }
        public string condition { get; set; }
        public string permalink { get; set; }
        public string thumbnail { get; set; }
        public bool accepts_mercadopago { get; set; }
        public Installments installments { get; set; }
        public Address address { get; set; }
        public Shipping shipping { get; set; }
        public SellerAddress seller_address { get; set; }
        public List<object> attributes { get; set; }
    }


    public class Value
    {
        public string id { get; set; }
        public string name { get; set; }
        public int results { get; set; }
    }

    public class AvailableFilter
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public List<Value> values { get; set; }
    }

    public class Vendedor
    {
        public string site_id { get; set; }
        public Seller seller { get; set; }
        public Paging paging { get; set; }
        public List<Result> results { get; set; }
        public List<object> secondary_results { get; set; }
        public List<object> related_results { get; set; }
        public Sort sort { get; set; }
        public List<AvailableSort> available_sorts { get; set; }
        public List<object> filters { get; set; }
        public List<AvailableFilter> available_filters { get; set; }
    }

 
}