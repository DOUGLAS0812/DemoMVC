using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }
       
        [Required(ErrorMessage ="O campo {0} é obrigatorio")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        [DataType(DataType.DateTime, ErrorMessage = "O campo {0} esta em formato incorreto")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNacimento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        [StringLength(60, ErrorMessage = "O campo {0} precisa ter no máximo {1} caracteres ")]
        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "O campo {}0 esta em formato invalido.")]
       // [EmailAddress(ErrorMessage = "O campo {0} está em formato inválido ")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        [Display(Name = "Confirme o seu e-mail")]
        [Compare("Email", ErrorMessage = "Os e-mails informados não são identicos")]
        [NotMapped]
        public string? EmailConfirmacao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        [Range(1,5, ErrorMessage ="O campo {0} deve estar entre {1} e {2}")]
        public int? Avaliacao { get; set; }

        public bool Atiuvo {  get; set; } 
    }
}
