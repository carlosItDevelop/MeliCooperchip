using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.OrderDetail {

    public class Speed {
        public int? shipping { get; set; }
        public object handling { get; set; }
    }

    public class EstimatedDelivery {
        public string date { get; set; }
        public object time_from { get; set; }
        public object time_to { get; set; }
    }

    public class ShippingOption {
        public int? id { get; set; }
        public int? shipping_method_id { get; set; }
        public string name { get; set; }
        public string currency_id { get; set; }
        public double? list_cost { get; set; }
        public double? cost { get; set; }
        public Speed speed { get; set; }
        public EstimatedDelivery estimated_delivery { get; set; }
    }

    public class ShippingItem {
        public string id { get; set; }
        public string description { get; set; }
        public int? quantity { get; set; }
        public string dimensions { get; set; }
    }

    public class State {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class City {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Country {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class ReceiverAddress {
        public State state { get; set; }
        public string street_name { get; set; }
        public City city { get; set; }
        public Country country { get; set; }
        public string address_line { get; set; }
        public int? id { get; set; }
        public string zip_code { get; set; }
        public object longitude { get; set; }
        public string street_number { get; set; }
        public object latitude { get; set; }
        public string comment { get; set; }
    }

    public class Shipping {
        public ShippingOption shipping_option { get; set; }
        public string shipping_mode { get; set; }
        public string shipment_type { get; set; }
        public List<ShippingItem> shipping_items { get; set; }
        public string status { get; set; }
        public string currency_id { get; set; }
        public int? sender_id { get; set; }
        public ReceiverAddress receiver_address { get; set; }
        public object picking_type { get; set; }
        public double cost { get; set; }
        public object substatus { get; set; }
        public long? id { get; set; }
        public string date_first_printed { get; set; }
        public int? service_id { get; set; }
        public int? receiver_id { get; set; }
        public string date_created { get; set; }
    }

    public class Purchase {
        public long id { get; set; }
        public object date_created { get; set; }
        public object fulfilled { get; set; }
        public string rating { get; set; }
        public string status { get; set; }
    }

    public class Sale {
        public long id { get; set; }
        public string date_created { get; set; }
        public object fulfilled { get; set; }
        public string rating { get; set; }
        public string status { get; set; }
    }

    public class Feedback {
        public Purchase purchase { get; set; }
        public Sale sale { get; set; }
    }

    public class Item {
        public string id { get; set; }
        public string title { get; set; }
        public string category_id { get; set; }
        public object variation_id { get; set; }
        public List<object> variation_attributes { get; set; }
    }

    public class OrderItem {
        public Item item { get; set; }
        public int quantity { get; set; }
        public double unit_price { get; set; }
        public string currency_id { get; set; }
    }

    public class Phone {
        public string area_code { get; set; }
        public string number { get; set; }
        public object extension { get; set; }
    }

    public class AlternativePhone {
        public object area_code { get; set; }
        public string number { get; set; }
        public object extension { get; set; }
    }

    public class BillingInfo {
        public string doc_type { get; set; }
        public string doc_number { get; set; }
    }

    public class Buyer {
        public int id { get; set; }
        public string nickname { get; set; }
        public string email { get; set; }
        public Phone phone { get; set; }
        public AlternativePhone alternative_phone { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public BillingInfo billing_info { get; set; }
    }

    public class Phone2 {
        public string area_code { get; set; }
        public string number { get; set; }
        public object extension { get; set; }
    }

    public class AlternativePhone2 {
        public string area_code { get; set; }
        public string number { get; set; }
        public object extension { get; set; }
    }

    public class Seller {
        public int id { get; set; }
        public string nickname { get; set; }
        public string email { get; set; }
        public Phone2 phone { get; set; }
        public AlternativePhone2 alternative_phone { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
    }

    public class Collector {
        public int id { get; set; }
    }

    public class AtmTransferReference {
        public object company_id { get; set; }
        public object transaction_id { get; set; }
    }

    public class Payment {
        public int id { get; set; }
        public int order_id { get; set; }
        public int payer_id { get; set; }
        public Collector collector { get; set; }
        public object card_id { get; set; }
        public string site_id { get; set; }
        public string reason { get; set; }
        public string payment_method_id { get; set; }
        public string currency_id { get; set; }
        public int installments { get; set; }
        public string issuer_id { get; set; }
        public AtmTransferReference atm_transfer_reference { get; set; }
        public object coupon_id { get; set; }
        public object activation_uri { get; set; }
        public string operation_type { get; set; }
        public string payment_type { get; set; }
        public List<object> available_actions { get; set; }
        public string status { get; set; }
        public string status_code { get; set; }
        public string status_detail { get; set; }
        public double? transaction_amount { get; set; }
        public double? shipping_cost { get; set; }
        public int? coupon_amount { get; set; }
        public int? overpaid_amount { get; set; }
        public double? total_paid_amount { get; set; }
        public string date_created { get; set; }
        public string date_last_modified { get; set; }
    }

    public class Coupon {
        public object id { get; set; }
        public int amount { get; set; }
    }

    public class OrderDetail {
        public int id { get; set; }
        public string date_created { get; set; }
        public string date_closed { get; set; }
        public string last_updated { get; set; }
        public Shipping shipping { get; set; }
        public Feedback feedback { get; set; }
        public List<object> mediations { get; set; }
        public object comments { get; set; }
        public string expiration_date { get; set; }
        public string status { get; set; }
        public object status_detail { get; set; }
        public List<OrderItem> order_items { get; set; }
        public string currency_id { get; set; }
        public Buyer buyer { get; set; }
        public Seller seller { get; set; }
        public List<Payment> payments { get; set; }
        public Coupon coupon { get; set; }
        public List<string> tags { get; set; }
        public double? total_amount { get; set; }
        public double? total_amount_with_shipping { get; set; }
        public double? paid_amount { get; set; }
    }



}
