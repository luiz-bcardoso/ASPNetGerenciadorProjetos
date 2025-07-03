using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPNetGerenciadorProjetos.Models
{
    public enum StatusTarefa
    {
        [Display(Name = "Pendente")] // Visualização amigável para o status.
        Pendente, // Valor para ser salvo no banco. 

        [Display(Name = "Em Andamento")]
        EmAndamento,

        [Display(Name = "Concluída")]
        Concluida
    }

    [Table("Tarefas")]
    public class Tarefa
    {
        [Key]
        public int TarefaId { get; set; }

        [Required(ErrorMessage = "O título da tarefa é obrigatório.")]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "O título deve ter entre 5 e 200 caracteres.")]
        [Display(Name = "Título")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O status da tarefa é obrigatório.")]
        [Display(Name = "Status")]
        public StatusTarefa Status { get; set; }

        // Foreing Key para o relacionamento com Projeto
        [Required(ErrorMessage = "O projeto associado é obrigatório.")]
        [Display(Name = "Projeto")]
        public int ProjetoId { get; set; }

        // Propriedade de navegação para o relacionamento com Projeto
        [ForeignKey("ProjetoId")]
        public Projeto? Projeto { get; set; }

    }
}