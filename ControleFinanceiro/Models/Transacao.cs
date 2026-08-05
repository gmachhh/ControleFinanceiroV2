using System.ComponentModel.DataAnnotations;

namespace ControleFinanceiro.Models
{
    public class Transacao
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe a descrição.")]
        [StringLength(100)]
        public string Descricao { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o valor.")]
        [Range(0.01, 999999999.99,
            ErrorMessage = "O valor deve ser maior que zero.")]
        [DataType(DataType.Currency)]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Informe a data.")]
        [DataType(DataType.Date)]
        public DateTime Data { get; set; } = DateTime.Today;

        [Required(ErrorMessage = "Selecione o tipo.")]
        public TipoTransacao Tipo { get; set; }

        [Required(ErrorMessage = "Selecione uma categoria.")]
        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }

        public Categoria? Categoria { get; set; }
    }
}