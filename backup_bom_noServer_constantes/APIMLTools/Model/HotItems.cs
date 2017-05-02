using System.Collections.Generic;

namespace Models.HotItems
{


    public class Result
    {
        public string id { get; set; }
        public string site_id { get; set; }
        public string title { get; set; }
        public string subtitle { get; set; }
        public double price { get; set; }
        public string currency_id { get; set; }
        public bool accepts_mercado_pago { get; set; }
        public string permalink { get; set; }
        public string thumbnail { get; set; }
        public string listing_mode { get; set; }
        public string currency_symbol { get; set; }
    }


    public class HotItems
    {
        public int limit { get; set; }
        public object category { get; set; }
        public List<Result> results { get; set; }
    }
}
