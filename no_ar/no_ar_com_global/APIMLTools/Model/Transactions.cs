
namespace Models
{
    public class Transactions
    {
        public string period { get; set; }
        public int total { get; set; }
        public int completed { get; set; }
        public int canceled { get; set; }
        public Ratings ratings { get; set; }
    }

}
