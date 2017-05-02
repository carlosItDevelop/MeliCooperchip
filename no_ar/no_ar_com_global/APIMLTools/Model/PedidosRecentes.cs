using System.Collections.Generic;

namespace Models.PedidosRecentes
{


    public class Paging
    {
        public int total { get; set; }
        public int offset { get; set; }
        public int limit { get; set; }
    }

    public class StatusDetail
    {
        public string code { get; set; }
        public object description { get; set; }
    }

    public class Item
    {
        public string id { get; set; }
        public string title { get; set; }
        public object variation_id { get; set; }
        public List<object> variation_attributes { get; set; }
    }

    public class OrderItem
    {
        public Item item { get; set; }
        public int quantity { get; set; }
        public double unit_price { get; set; }
        public string currency_id { get; set; }
    }

    public class Phone
    {
        public string area_code { get; set; }
        public string number { get; set; }
        public string extension { get; set; }
    }

    public class BillingInfo
    {
        public string doc_type { get; set; }
        public string doc_number { get; set; }
    }

    public class Buyer
    {
        public int id { get; set; }
        public string nickname { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public Phone phone { get; set; }
        public BillingInfo billing_info { get; set; }
    }

    public class Phone2
    {
        public string area_code { get; set; }
        public string number { get; set; }
        public string extension { get; set; }
    }

    public class Seller
    {
        public int id { get; set; }
        public string nickname { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public Phone2 phone { get; set; }
    }

    public class Sale
    {
        public string date_created { get; set; }
        public bool fulfilled { get; set; }
        public string rating { get; set; }
    }

    public class Purchase
    {
        public string date_created { get; set; }
        public bool fulfilled { get; set; }
        public string rating { get; set; }
    }

    public class Feedback
    {
        public Sale sale { get; set; }
        public Purchase purchase { get; set; }
    }

    public class City
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class State
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Country
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class ReceiverAddress
    {
        public int? id { get; set; }
        public string address_line { get; set; }
        public string zip_code { get; set; }
        public string comment { get; set; }
        public City city { get; set; }
        public State state { get; set; }
        public Country country { get; set; }
        public object latitude { get; set; }
        public object longitude { get; set; }
    }

    public class Shipping
    {
        public string status { get; set; }
        public long? id { get; set; }
        public string shipment_type { get; set; }
        public string shipping_mode { get; set; }
        public string date_created { get; set; }
        public string currency_id { get; set; }
        public double? cost { get; set; }
        public string date_first_printed { get; set; }
        public int? service_id { get; set; }
        public ReceiverAddress receiver_address { get; set; }
    }

    public class Result
    {
        public int id { get; set; }
        public string status { get; set; }
        public StatusDetail status_detail { get; set; }
        public string date_created { get; set; }
        public string date_closed { get; set; }
        public List<OrderItem> order_items { get; set; }
        public double total_amount { get; set; }
        public string currency_id { get; set; }
        public Buyer buyer { get; set; }
        public Seller seller { get; set; }
        public List<object> payments { get; set; }
        public Feedback feedback { get; set; }
        public Shipping shipping { get; set; }
        public List<string> tags { get; set; }
    }

    public class Sort
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class AvailableSort
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Value
    {
        public object id { get; set; }
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

    public class PedidosRecentes
    {
        public string query { get; set; }
        public string display { get; set; }
        public Paging paging { get; set; }
        public List<Result> results { get; set; }
        public Sort sort { get; set; }
        public List<AvailableSort> available_sorts { get; set; }
        public List<object> filters { get; set; }
        public List<AvailableFilter> available_filters { get; set; }
        public string complete { get; set; }
    }

}
