using System.ComponentModel.DataAnnotations.Schema;
namespace APIGestaoEscolar.Model
{
    public class Aluno
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Sexo { get; set; }

        public int TotalFaltas { get; set; }

        [Column("Turma_id")]
        public int Turma_id { get; set; }

        public virtual Turma Turma { get; set; } // Informa que Turma_id é FK

     }
}
