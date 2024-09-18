using System.ComponentModel.DataAnnotations;

namespace ComexAPI.Data.DTOs;

public class CreateProdutoDTO
{
    [Required(ErrorMessage = "O nome do produto é obrigatório")]
    [StringLength(100)]
    public string Nome { get; set; }
    [StringLength(500)]
    public string Descricao { get; set; }
    [Required(ErrorMessage = "O valor do produto é obrigatório")]
    [Range(0.01, double.MaxValue)]
    public double PrecoUnitario { get; set; }
    [Required(ErrorMessage = "A quantidade do produto é obrigatória")]
    [Range(0, int.MaxValue)]
    public int Quantidade { get; set; }
}
