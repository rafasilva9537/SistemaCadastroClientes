using System.ComponentModel.DataAnnotations;

namespace MvcApp.ViewModels.Segmentos;

public class SegmentoViewModel
{
    [Required(ErrorMessage = "Segmento é obrigatório.")]
    [Range(1, int.MaxValue, ErrorMessage = "Segmento inválido.")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Segmento é obrigatório.")]
    [MaxLength(100, ErrorMessage = "Segmento inválido, acima de 100 characteres.")]
    public string Nome { get; set; } = string.Empty;
}
