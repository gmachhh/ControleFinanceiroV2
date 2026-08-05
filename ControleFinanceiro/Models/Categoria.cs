using System.ComponentModel.DataAnnotations;

namespace ControleFinanceiro.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome da categoria.")]
        [StringLength(50)]
        [Display(Name = "Nome")]
        public string Nome { get; set; } = string.Empty;

        public ICollection<Transacao> Transacoes { get; set; }
            = new List<Transacao>();
    }
}