using ASPNetGerenciadorProjetos.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNetGerenciadorProjetos.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Usando Fluent API para configurar o relacionamento entre Projeto e Tarefa
            modelBuilder.Entity<Tarefa>()
                .HasOne(t => t.Projeto) // Cada tarefa tem um projeto
                .WithMany(p => p.Tarefas) // Um projeto pode ter várias tarefas
                .HasForeignKey(t => t.ProjetoId) // Chave estrangeira na tabela Tarefas
                .OnDelete(DeleteBehavior.Cascade); // Se um projeto for excluído, suas tarefas também serão excluídas
            base.OnModelCreating(modelBuilder);

        }
    }
}
