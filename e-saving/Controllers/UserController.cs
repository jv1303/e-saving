using e_saving.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace e_saving.Controllers.User;

public class UserController : Controller
{
    //private readonly ILogger<UserController> _logger;
    
    private readonly Contexto _contexto;

    public UserController (Contexto contexto)
    {
        _contexto = contexto;
    }
    
    /*
    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }
    */

    public IActionResult UserRegister()
    {
        return View();
    }
    public IActionResult PartnerRegister()
    {
        return View();
    }
    public IActionResult BuyerRegister()
    {
        return View();
    }
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult DoLogin()
    {
        // aqui vai o codigo pra quando o cara logar

        return RedirectToAction("UpdateUserLogged", "Home");
    }
    
    [HttpPost]
    public async Task<IActionResult> DoClienteRegister(Cliente cliente) //inserir
    {      
        await _contexto.clientes.AddAsync(cliente); 
        await _contexto.SaveChangesAsync();

        return RedirectToAction("UpdateUserLogged", "Home");
    }
}