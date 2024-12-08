using e_saving.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace e_saving.Controllers.Context;

public class ContextController : Controller
{
    
    private readonly Contexto _contexto;

    public ContextController (Contexto contexto)
    {
        _contexto = contexto;
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