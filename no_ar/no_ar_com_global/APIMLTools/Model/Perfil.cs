using System.Collections.Generic;

namespace Models.Perfil
{

    public class Address
    {
        public string state { get; set; }
        public string city { get; set; }
    }

    public class Ratings
    {
        public double positive { get; set; }
        public double negative { get; set; }
        public double neutral { get; set; }
    }

    public class Transactions
    {
        public string period { get; set; }
        public int total { get; set; }
        public int completed { get; set; }
        public int canceled { get; set; }
        public Ratings ratings { get; set; }
    }

    public class SellerReputation
    {
        public string level_id { get; set; }
        public object power_seller_status { get; set; }
        public Transactions transactions { get; set; }
    }

    public class Status
    {
        public string site_status { get; set; }
    }

    public class Perfil
    {
        public int id { get; set; }
        public string nickname { get; set; }
        public string registration_date { get; set; }
        public string country_id { get; set; }
        public Address address { get; set; }
        public string user_type { get; set; }
        public List<string> tags { get; set; }
        public object logo { get; set; }
        public int points { get; set; }
        public string site_id { get; set; }
        public string permalink { get; set; }
        public SellerReputation seller_reputation { get; set; }
        public Status status { get; set; }
    }

}