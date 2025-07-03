using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPNetGerenciadorProjetos.Models
{
    [Table("Projetos")]
    public class Projeto
    {
        [Key]
        public int ProjetoID { get; set; }

        [Required(ErrorMessage = "O nome do projeto é obrigatório.")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "O nome do projeto deve ter entre 3 e 150 caracteres.")]
        [Display(Name = "Nome do Projeto")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O nome do cliente é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome do cliente deve ter no máximo 100 caracteres.")]
        [Display(Name = "Cliente")]
        public string Cliente { get; set; }

        [Required(ErrorMessage = "A data de início é obrigatória.")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Início")]
        public DateTime DataInicio { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data de Término")]
        public DateTime? DataTermino { get; set; } // O '?' indica que a data é opcional (pode ser nula)

        // Propriedade de navegação para o relacionamento 1:N
        // Um projeto pode ter várias tarefas.
        public ICollection<Tarefa>? Tarefas { get; set; }
    }
}