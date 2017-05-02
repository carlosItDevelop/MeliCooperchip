
namespace Models
{
    public class Pessoa
    {
        public int id_pessoa { get; set; }
        public string UserName { get; set; }
        public string nome_razao { get; set; }
        public string email { get; set; }
        public string tipo_pessoa { get; set; }
        public string ddd { get; set; }
        public string telefone { get; set; }
        public string status { get; set; }
        public string obs { get; set; }

        public Pessoa()
        { 
            this.id_pessoa = int.MinValue;
            this.UserName = string.Empty;
            this.nome_razao = string.Empty;
            this.email = string.Empty;
            this.tipo_pessoa = string.Empty;
            this.ddd = string.Empty;
            this.telefone = string.Empty;
            this.status = string.Empty;
            this.obs = string.Empty;
        }
    }// fim da Classe;
}// Fim do Namespace;
