using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Entidades {
    public class TaskList {

        [Key]
        public int TaskListId { get; set; }

        [Display(Name = "Data da Tarefa")]
        [DataType(DataType.Date)]
        [Required]
        [DisplayFormat(DataFormatString= "{0:dd-MM-yyyy}", ApplyFormatInEditMode= true)]
        public DateTime DataCriacao { get; set; }
        [Required]
        public string Prioridade { get; set; }

        [Display(Name = "Tarefa")]
        public String Descricao { get; set; }
        public bool Concruida { get; set; }

    }
}
