using ASPNetGerenciadorProjetos.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNetGerenciadorProjetos.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }
    }
}
