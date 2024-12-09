using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using e_saving.Models;
using variables.Models;

namespace e_saving.Controllers.Home;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var data = RepositorioGlobalVariables.Variables;
        ViewBag.JsonData = System.Text.Json.JsonSerializer.Serialize(data);
        return View();
        //return View(InformacoesContainer.Clientes);
    }
    public IActionResult QuemSomos()
    {
        return View(RepositorioGlobalVariables.Variables);
    }
    public IActionResult PontosColeta()
    {
        return View(RepositorioGlobalVariables.Variables);
    }
    public IActionResult AreaParceiro()
    {
        return View(RepositorioGlobalVariables.Variables);
    }
    public IActionResult SejaParceiro()
    {
        return View(RepositorioGlobalVariables.Variables);
    }

    public IActionResult SejaComprador()
    {
        return View(RepositorioGlobalVariables.Variables);
    }

    public IActionResult AreaUsuario()
    {
        return View(RepositorioGlobalVariables.Variables);
    }

    public IActionResult AreaComprador()
    {
        return View(RepositorioGlobalVariables.Variables);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    // [HttpPost]
    public IActionResult UpdateUserLogged()
    {
        RepositorioGlobalVariables.SwitchUserLogged();
        return RedirectToAction("Index");
    }
}
