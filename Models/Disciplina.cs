using System.ComponentModel.DataAnnotations;

namespace DisciplinasApi.Models
{
    public class Disciplina
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome da disciplina é obrigatório")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 100 caracteres")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "A carga horária é obrigatória")]
        [Range(20, 200, ErrorMessage = "A carga horária deve estar entre 20 e 200 horas")]
        public int CargaHoraria { get; set; }

        [StringLength(100, ErrorMessage = "O nome do professor não pode exceder 100 caracteres")]
        public string? Professor { get; set; }
    }
}