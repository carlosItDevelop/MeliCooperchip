using System.Collections.Generic;

namespace Model.BuscaIDPorNickName {

    public class SellerReputation {
        public object power_seller_status { get; set; }
    }

    public class Seller {
        public int id { get; set; }
        public SellerReputation seller_reputation { get; set; }
        public bool real_estate_agency { get; set; }
        public bool car_dealer { get; set; }
    }

    public class Paging {
        public int total { get; set; }
        public int offset { get; set; }
        public int limit { get; set; }
    }

    public class Sort {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class AvailableSort {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class BuscaIDPorNickName {
        public string site_id { get; set; }
        public Seller seller { get; set; }
        public Paging paging { get; set; }
        public List<object> results { get; set; }
        public List<object> secondary_results { get; set; }
        public List<object> related_results { get; set; }
        public Sort sort { get; set; }
        public List<AvailableSort> available_sorts { get; set; }
        public List<object> filters { get; set; }
        public List<object> available_filters { get; set; }
    }

}
