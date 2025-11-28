using Microsoft.AspNetCore.Mvc.ModelBinding;
using MvcApp.ViewModels.Segmentos;

namespace MvcApp.ViewModels.Fornecedor;

public class CriarFornecedorFormViewModel
{
    public CriarFornecedorViewModel Fornecedor { get; set; } = null!;
 
    [BindNever]
    public List<SegmentoViewModel>? Segmentos { get; set; }
}
