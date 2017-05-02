using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Entidades {
    public class Expert {

        [Key]
        public int ExpertId { get; set; }
        [Required]
        public string Nome { get; set; }

        public DateTime Datacadastro { get; set; }
        public string Certificacao { get; set; }
        public decimal HoraConsultoria { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string Linkedin { get; set; }

    }
}
