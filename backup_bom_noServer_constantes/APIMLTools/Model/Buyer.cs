
namespace Models
{
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
}
