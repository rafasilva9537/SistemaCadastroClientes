using MvcApp.ViewModels.Segmentos;

namespace MvcApp.ViewModels.Fornecedor;

public class CriarFornecedorFormViewModel
{
    public CriarFornecedorViewModel Fornecedor { get; set; } = null!;
    public List<SegmentoViewModel> Segmentos { get; set; } = null!;
}
