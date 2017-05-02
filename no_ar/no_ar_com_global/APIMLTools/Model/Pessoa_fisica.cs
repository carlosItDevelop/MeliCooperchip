using System;

namespace Models
{
    public class Pessoa_fisica : Pessoa
    {

        public string cpf { get; set; }
        public string rg { get; set; }
        public DateTime data_nascimento { get; set; }
        public string sexo { get; set; }
        
        public Pessoa_fisica() {
            this.cpf = string.Empty;
            this.rg = string.Empty;
            this.data_nascimento = DateTime.MinValue;
            this.sexo = string.Empty;
        } // Fim do Construtor

        


    /* ---------------- */
    } /* Fim da Classe */
} /* Fim do Namespace */
