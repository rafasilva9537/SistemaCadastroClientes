using Microsoft.AspNetCore.Mvc;
using MvcApp.ViewModels;

namespace MvcApp.Controllers;

public class FornecedoresController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Criar(CriarFornecedorViewModel fornecedor)
    {
        return View(fornecedor);
    }

    public IActionResult Editar(int id)
    {
        return View();
    }

    public IActionResult Deletar(int id)
    {
        return RedirectToAction("Index");
    }

    public IActionResult Detalhes(int id)
    {
        return View();
    }
}
