namespace ProjetoMVC_EF_1paraN.Models
{
    public class Turma
    {   
        public int TurmaId { get; set; }
        public string Nome { get; set; }

        public int ProfessorId { get; set; }

        public Professor? Professor { get; set; }
       
    }
}
