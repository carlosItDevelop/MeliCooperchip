using System.Collections.Generic;

namespace Models.PedidosPendentes
{


    // https://api.mercadolibre.com/orders/search/pending?seller=59181149&access_token=APP_USR-6092-033018-f3afd7500381ec8cf658e92acce7edf4__E_L__-59181149

    public class Paging
    {
        public int total { get; set; }
        public int offset { get; set; }
        public int limit { get; set; }
    }

    public class StatusDetail
    {
        public string description { get; set; }
        public string code { get; set; }
    }

    public class Item
    {
        public string id { get; set; }
        public string title { get; set; }
        public List<object> variation_attributes { get; set; }
        public string category_id { get; set; }
        public object variation_id { get; set; }
    }

    public class OrderItem
    {
        public string currency_id { get; set; }
        public Item item { get; set; }
        public int quantity { get; set; }
        public double unit_price { get; set; }
    }

    public class Collector
    {
        public int id { get; set; }
    }

    public class AtmTransferReference
    {
        public object company_id { get; set; }
        public object transaction_id { get; set; }
    }

    public class Payment
    {
        public int id { get; set; }
        public int order_id { get; set; }
        public int payer_id { get; set; }
        public Collector collector { get; set; }
        public string currency_id { get; set; }
        public string status { get; set; }
        public string status_code { get; set; }
        public string status_detail { get; set; }
        public double transaction_amount { get; set; }
        public double shipping_cost { get; set; }
        public int overpaid_amount { get; set; }
        public double total_paid_amount { get; set; }
        public object marketplace_fee { get; set; }
        public int coupon_amount { get; set; }
        public string date_created { get; set; }
        public string date_last_modified { get; set; }
        public object card_id { get; set; }
        public string reason { get; set; }
        public string activation_uri { get; set; }
        public string payment_method_id { get; set; }
        public int installments { get; set; }
        public string issuer_id { get; set; }
        public AtmTransferReference atm_transfer_reference { get; set; }
        public object coupon_id { get; set; }
        public string operation_type { get; set; }
        public string payment_type { get; set; }
        public List<object> available_actions { get; set; }
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

    public class City
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class ReceiverAddress
    {
        public int id { get; set; }
        public string zip_code { get; set; }
        public double? latitude { get; set; }
        public double? longitude { get; set; }
        public string street_number { get; set; }
        public string street_name { get; set; }
        public State state { get; set; }
        public string comment { get; set; }
        public string address_line { get; set; }
        public Country country { get; set; }
        public City city { get; set; }
    }

    public class Speed
    {
        public int shipping { get; set; }
        public int handling { get; set; }
    }

    public class EstimatedDelivery
    {
        public object date { get; set; }
        public object time_from { get; set; }
        public object time_to { get; set; }
    }

    public class ShippingOption
    {
        public int id { get; set; }
        public int shipping_method_id { get; set; }
        public string name { get; set; }
        public string currency_id { get; set; }
        public double cost { get; set; }
        public Speed speed { get; set; }
        public EstimatedDelivery estimated_delivery { get; set; }
    }

    public class ShippingItem
    {
        public string id { get; set; }
        public string description { get; set; }
        public int quantity { get; set; }
        public string dimensions { get; set; }
    }

    public class Shipping
    {
        public object substatus { get; set; }
        public string status { get; set; }
        public object id { get; set; }
        public object service_id { get; set; }
        public string currency_id { get; set; }
        public string shipping_mode { get; set; }
        public string shipment_type { get; set; }
        public int? sender_id { get; set; }
        public object picking_type { get; set; }
        public ReceiverAddress receiver_address { get; set; }
        public string date_created { get; set; }
        public double? cost { get; set; }
        public object date_first_printed { get; set; }
        public ShippingOption shipping_option { get; set; }
        public List<ShippingItem> shipping_items { get; set; }
    }

    public class Phone
    {
        public string area_code { get; set; }
        public string number { get; set; }
        public string extension { get; set; }
    }

    public class AlternativePhone
    {
        public object area_code { get; set; }
        public string number { get; set; }
        public object extension { get; set; }
    }

    public class Buyer
    {
        public int id { get; set; }
        public string nickname { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public Phone phone { get; set; }
        public AlternativePhone alternative_phone { get; set; }
        public object billing_info { get; set; }
    }

    public class Phone2
    {
        public string area_code { get; set; }
        public string number { get; set; }
        public object extension { get; set; }
    }

    public class AlternativePhone2
    {
        public string area_code { get; set; }
        public string number { get; set; }
        public object extension { get; set; }
    }

    public class Seller
    {
        public int id { get; set; }
        public string nickname { get; set; }
        public object email { get; set; }
        public Phone2 phone { get; set; }
        public AlternativePhone2 alternative_phone { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
    }

    public class Feedback
    {
        public object sale { get; set; }
        public object purchase { get; set; }
    }

    public class Result
    {
        public int id { get; set; }
        public string comments { get; set; }
        public string status { get; set; }
        public StatusDetail status_detail { get; set; }
        public string date_created { get; set; }
        public string date_closed { get; set; }
        public string date_last_updated { get; set; }
        public bool hidden_for_seller { get; set; }
        public string currency_id { get; set; }
        public List<OrderItem> order_items { get; set; }
        public double total_amount { get; set; }
        public List<object> mediations { get; set; }
        public List<Payment> payments { get; set; }
        public Shipping shipping { get; set; }
        public Buyer buyer { get; set; }
        public Seller seller { get; set; }
        public Feedback feedback { get; set; }
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
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Filter
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public List<Value> values { get; set; }
    }

    public class Value2
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
        public List<Value2> values { get; set; }
    }

    public class PedidosPendentes
    {
        public string query { get; set; }
        public string display { get; set; }
        public Paging paging { get; set; }
        public List<Result> results { get; set; }
        public Sort sort { get; set; }
        public List<AvailableSort> available_sorts { get; set; }
        public List<Filter> filters { get; set; }
        public List<AvailableFilter> available_filters { get; set; }
    }


}
