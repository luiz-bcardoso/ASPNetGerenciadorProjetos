using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPNetGerenciadorProjetos.Models
{
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
        public string Status { get; set; }

        // Foreing Key para o relacionamento com Projeto
        [Required(ErrorMessage = "O projeto associado é obrigatório.")]
        [Display(Name = "Projeto")]
        [ForeignKey("ProjetoId")]
        public int ProjetoId { get; set; }

        // Propriedade de navegação para o relacionamento com Projeto
        public Projeto? Projeto { get; set; }

    }
}