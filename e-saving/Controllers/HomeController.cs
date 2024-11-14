using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using e_saving.Models;

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
        return View();
    }
    public IActionResult QuemSomos()
    {
        return View();
    }
    public IActionResult PontosColeta()
    {
        return View();
    }
    public IActionResult AreaParceiro()
    {
        return View();
    }
    public IActionResult SejaParceiro()
    {
        return View();
    }

    public IActionResult SejaComprador()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
