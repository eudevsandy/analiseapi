using System.ComponentModel.DataAnnotations.Schema;

namespace APIGestaoEscolar.Model
{
    public class Turma
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }

        public virtual List<Aluno> Aluno { get; set; }

    }

    
}


