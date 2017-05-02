using System.Collections.Generic;

namespace Models.Pagamentos
{

    public class Paging
    {
        public int total { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
    }

    public class Phone
    {
        public string area_code { get; set; }
        public string number { get; set; }
        public object extension { get; set; }
    }

    public class Identification
    {
        public object type { get; set; }
        public object number { get; set; }
    }

    public class Payer
    {
        public string nickname { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public Phone phone { get; set; }
        public string email { get; set; }
        public int id { get; set; }
        public Identification identification { get; set; }
    }

    public class Identification2
    {
        public string type { get; set; }
        public string number { get; set; }
    }

    public class Cardholder
    {
        public string name { get; set; }
        public Identification2 identification { get; set; }
    }

    public class Collection
    {
        public int id { get; set; }
        public string site_id { get; set; }
        public string date_created { get; set; }
        public string date_approved { get; set; }
        public string last_modified { get; set; }
        public string money_release_date { get; set; }
        public string operation_type { get; set; }
        public int collector_id { get; set; }
        public int? sponsor_id { get; set; }
        public Payer payer { get; set; }
        public string external_reference { get; set; }
        public int? merchant_order_id { get; set; }
        public string reason { get; set; }
        public string currency_id { get; set; }
        public double transaction_amount { get; set; }
        public double total_paid_amount { get; set; }
        public double shipping_cost { get; set; }
        public int? account_money_amount { get; set; }
        public double? mercadopago_fee { get; set; }
        public double? net_received_amount { get; set; }
        public double? marketplace_fee { get; set; }
        public object coupon_id { get; set; }
        public int? coupon_amount { get; set; }
        public int? coupon_fee { get; set; }
        public int finance_fee { get; set; }
        public string status { get; set; }
        public string status_detail { get; set; }
        public string status_code { get; set; }
        public string released { get; set; }
        public string payment_type { get; set; }
        public int? installments { get; set; }
        public object installment_amount { get; set; }
        public object deferred_period { get; set; }
        public Cardholder cardholder { get; set; }
        public string statement_descriptor { get; set; }
        public object transaction_order_id { get; set; }
        public string last_four_digits { get; set; }
        public string payment_method_id { get; set; }
        public string marketplace { get; set; }
        public List<object> tags { get; set; }
        public List<object> refunds { get; set; }
        public double amount_refunded { get; set; }
        public object notification_url { get; set; }
    }

    public class Result
    {
        public Collection collection { get; set; }
    }

    public class Pagamentos
    {
        public Paging paging { get; set; }
        public List<Result> results { get; set; }
    }
}