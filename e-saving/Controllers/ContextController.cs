using e_saving.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using variables.Models;

namespace e_saving.Controllers.Context;

public class ContextController : Controller
{
    
    private readonly Contexto _contexto;

    public ContextController (Contexto contexto)
    {
        _contexto = contexto;
    }
    
    [HttpPost]
    public IActionResult DoLogin(string email, string password)
    {
        object usuario = null; // pode armazenar qualquer tipo de objeto

        if ((usuario = _contexto.clientes.FirstOrDefault(u => u.EmailCliente == email && u.SenhaCliente == password)) != null) 
        {
            RepositorioGlobalVariables.Variables.isCliente = "true";
        }

        Console.WriteLine(RepositorioGlobalVariables.Variables.isCliente);

        Console.WriteLine($"Attempting to log in with CPF: {email} and Password: {password}");

        //usuario = _contexto.parceiros.FirstOrDefault(u => u.EmailParceiro == email && u.SenhaParceiro == senha);

        //usuario = _contexto.compradores.FirstOrDefault(u => u.EmailComprador == email && u.SenhaComprador == senha);


        //if (usuario != null)
        //{
        // Usuário autenticado com sucesso
        // Adicione informações na sessão
        //HttpContext.Session.SetString("UsuarioLogado", email);
        //HttpContext.Session.SetString("TipoUsuarioLogado", tipoUsuario);

        // Redireciona para a página inicial
        //return RedirectToAction("Index", "Home");
        //}

    // Caso a autenticação falhe
       // ViewData["Erro"] = "E-mail ou senha inválidos."; // testar funcionalidade
        //return View("Login");
        return RedirectToAction("UpdateUserLogged", "Home");
    }
    
    [HttpPost]
    public async Task<IActionResult> DoClienteRegister(Cliente cliente) //inserir
    {      
        await _contexto.clientes.AddAsync(cliente); 
        await _contexto.SaveChangesAsync();

        return RedirectToAction("UpdateUserLogged", "Home");
    }

    [HttpPost]
    public async Task<IActionResult> DoPartnerRegister(Parceiro parceiro)
    {      
        await _contexto.parceiros.AddAsync(parceiro); 
        await _contexto.SaveChangesAsync();

        return RedirectToAction("UpdateUserLogged", "Home");
    }

    [HttpPost]
    public async Task<IActionResult> DoBuyerRegister(Comprador comprador)
    {      
        await _contexto.compradores.AddAsync(comprador); 
        await _contexto.SaveChangesAsync();

        return RedirectToAction("UpdateUserLogged", "Home");
    }
}