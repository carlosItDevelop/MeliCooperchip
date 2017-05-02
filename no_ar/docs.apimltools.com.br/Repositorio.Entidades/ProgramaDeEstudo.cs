namespace Repositorio.Entidades
{
    public class ProgramaDeEstudo
    {
        public int ProgramaDeEstudoID { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public bool Iniciado { get; set; }
        public bool Entendido { get; set; }
        public bool Praticado { get; set; }
    }
}