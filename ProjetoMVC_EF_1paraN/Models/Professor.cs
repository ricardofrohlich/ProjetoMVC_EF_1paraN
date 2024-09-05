namespace ProjetoMVC_EF_1paraN.Models
{
    public class Professor
    {
        public int ProfessorID { get; set; }
        public string Nome { get; set; }

        //Agora, vai ser diferente. Precisamos de uma lista
        public ICollection<Turma>? Turmas { get; set; }
    }
}
