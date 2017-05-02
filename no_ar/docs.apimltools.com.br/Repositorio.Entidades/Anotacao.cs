using System;

namespace Repositorio.Entidades
{
    public class Anotacao
    {
        public int AnotacaoID { get; set; }
        public string Tags { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataAnotacao { get; set; }
        public string Status { get; set; }
    }
}