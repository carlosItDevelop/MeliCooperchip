using System;
using System.ComponentModel.DataAnnotations;

namespace Repositorio.Entidades
{
    public class Agenda
    {
        public int AgendaID { get; set; }
        public string Evento { get; set; }
        public string Agente { get; set; }
        public string Descricao { get; set; }
        [Display(Name = "Data do Evento")]
        [DataType(DataType.Date)]
        [Required]
        [DisplayFormat(DataFormatString= "{0:dd-MM-yyyy}", ApplyFormatInEditMode= true)]
        
        public DateTime Data { get; set; }
        public string Prioridade { get; set; }
        public string Status { get; set; }
    }
}