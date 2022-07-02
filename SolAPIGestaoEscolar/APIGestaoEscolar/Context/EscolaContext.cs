using APIGestaoEscolar.Model;
using Microsoft.EntityFrameworkCore;

namespace APIGestaoEscolar.Context
{
    public class EscolaContext : DbContext
    {
        public EscolaContext(DbContextOptions<EscolaContext> options) : base(options)
        {
        }

        //  CONECTANDO NOSSAS CLASSES AS TABELAS DO BANCO DE DADOS
        public DbSet<Turma> Turma { get; set; }
        public DbSet<Aluno> Aluno { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   // Referenciar tabelas que tem FK
            modelBuilder.Entity<Aluno>().ToTable("Aluno"); 

            modelBuilder.Entity<Aluno>()
                .HasOne(e => e.Turma) // Um aluno está vinculado em uma turma
                .WithMany(e => e.Aluno)  // Uma turma pode ter vários alunos
                .HasForeignKey(e => e.Turma_id);

        }
    }

}