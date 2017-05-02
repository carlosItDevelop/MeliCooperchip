using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Entidades {
    public class Cliente {
        public int ClienteID { get; set; }
        public char Tipo { get; set; }
        public string Nome { get; set; }
        public string CpfCnpj { get; set; }
        public string Endereco { get; set; }
        public string Telefones { get; set; }
        public string email { get; set; }
        public string DDD { get; set; }
        public string Estado { get; set; }
        public string Bairro { get; set; }
        public string Descricao { get; set; }
        public string TecnologiaRequerida { get; set; }
        public bool Ativo { get; set; }

    }
}
