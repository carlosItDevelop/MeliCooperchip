
namespace Models
{
    public class Notificacao
    {
        public int user_id { get; set; }
        public string resource { get; set; }
        public string topic { get; set; }
        public string received { get; set; }
        public string sent { get; set; }

        public double application_id { get; set; }

        public int attempts { get; set; }


    }
}
