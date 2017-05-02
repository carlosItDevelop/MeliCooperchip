
namespace Models
{
    public class Pessoa_juridica : Pessoa
    {
        public string cnpj { get; set; }
        public string insc_estadual { get; set; }
        public string insc_municipal { get; set; }

        public Pessoa_juridica() {
            this.cnpj = string.Empty;
            this.insc_estadual = string.Empty;
            this.insc_municipal = string.Empty;
        }



    /* ---------------- */
    } /* Fim da Classe */
} /* Fim do Namespace */
