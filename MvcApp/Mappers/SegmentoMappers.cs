using MvcApp.Models;
using MvcApp.ViewModels.Segmentos;
using System.Linq.Expressions;

namespace MvcApp.Mappers;

public static class SegmentoMappers
{
    // Model para ViewModel
    public static SegmentoViewModel ToSegmentoViewModel(this Segmento segmento)
    {
        return new SegmentoViewModel()
        {
            Id = segmento.Id,
            Nome = segmento.Nome
        };
    }

    public static Expression<Func<Segmento, SegmentoViewModel>> ProjectToSegmentoViewModel = 
        (segmento) => new SegmentoViewModel()
        {
            Id = segmento.Id,
            Nome = segmento.Nome
        };
}