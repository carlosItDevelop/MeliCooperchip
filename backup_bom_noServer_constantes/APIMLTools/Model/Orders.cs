using System.Collections.Generic;

namespace Models.Orders
{

    
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
        public object extension { get; set; }
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
        public string email { get; set; }
        public Phone phone { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public BillingInfo billing_info { get; set; }
    }

    public class Phone2
    {
        public string area_code { get; set; }
        public string number { get; set; }
        public object extension { get; set; }
    }

    public class Seller
    {
        public int id { get; set; }
        public string nickname { get; set; }
        public string email { get; set; }
        public Phone2 phone { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
    }

    public class Payment
    {
        public int id { get; set; }
        public double transaction_amount { get; set; }
        public string currency_id { get; set; }
        public string status { get; set; }
        public object date_created { get; set; }
        public object date_last_modified { get; set; }
    }

    public class Purchase
    {
        public string date_created { get; set; }
        public bool fulfilled { get; set; }
        public string rating { get; set; }
    }

    public class Sale
    {
        public string date_created { get; set; }
        public bool fulfilled { get; set; }
        public string rating { get; set; }
    }

    public class Feedback
    {
        public Purchase purchase { get; set; }
        public Sale sale { get; set; }
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
        public int id { get; set; }
        public string address_line { get; set; }
        public string zip_code { get; set; }
        public City city { get; set; }
        public State state { get; set; }
        public Country country { get; set; }
        public object latitude { get; set; }
        public object longitude { get; set; }
        public string comment { get; set; }
    }

    public class Shipping
    {
        public long id { get; set; }
        public string shipment_type { get; set; }
        public string status { get; set; }
        public string date_created { get; set; }
        public ReceiverAddress receiver_address { get; set; }
        public string currency_id { get; set; }
        public int cost { get; set; }
    }

    public class Orders
    {
        public int id { get; set; }
        public string status { get; set; }
        public object status_detail { get; set; }
        public string date_created { get; set; }
        public string date_closed { get; set; }
        public List<OrderItem> order_items { get; set; }
        public double total_amount { get; set; }
        public string currency_id { get; set; }
        public Buyer buyer { get; set; }
        public Seller seller { get; set; }
        public List<Payment> payments { get; set; }
        public Feedback feedback { get; set; }
        public Shipping shipping { get; set; }
        public List<string> tags { get; set; }
    }


}