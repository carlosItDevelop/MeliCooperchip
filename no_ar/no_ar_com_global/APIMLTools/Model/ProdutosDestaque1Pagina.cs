
namespace Models.ProdutosDestaque1Pagina
{

    public class Picture
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class ProdutosDestaque1Pagina
    {
        public string item_id { get; set; }
        public string title { get; set; }
        public double price { get; set; }
        public string currency_id { get; set; }
        public string permalink { get; set; }
        public Picture picture { get; set; }
        public bool accepts_mercado_pago { get; set; }
        public string category_id { get; set; }
        public string pool_id { get; set; }
    }
}
