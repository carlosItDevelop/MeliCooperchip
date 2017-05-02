
namespace Models.QualificacaoFeitaERecebida
{

    public class Sale
    {
        public string item_id { get; set; }
        public string rating { get; set; }
        public bool fulfilled { get; set; }
        public object reason { get; set; }
        public string message { get; set; }
        public object reply { get; set; }
        public string date_created { get; set; }
    }

    public class Purchase
    {
        public string item_id { get; set; }
        public string rating { get; set; }
        public bool fulfilled { get; set; }
        public object reason { get; set; }
        public string message { get; set; }
        public object reply { get; set; }
        public string date_created { get; set; }
    }

    public class QualificacaoFeitaERecebida
    {
        public Sale sale { get; set; }
        public Purchase purchase { get; set; }
    }

}
