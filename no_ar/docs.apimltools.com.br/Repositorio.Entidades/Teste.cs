using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Entidades {
    public class Teste {
        [Key]
        public int TesteId { get; set; }
        [Required]
        public string Descricao { get; set; }

        public string Status { get; set; }
    }
}
