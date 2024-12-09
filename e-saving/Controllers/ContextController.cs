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
    
    // [HttpGet]
    // public async Task<IActionResult> ObterInformacoes()
    // {
    //     var clientes = await _contexto.clientes.ToListAsync(); // await retorna uma lista tipada de um objeto da Db
    //     var parceiros = await _contexto.parceiros.ToListAsync();
    //     var compradores = await _contexto.compradores.ToListAsync();

    //     // Criação de um ViewModel para encapsular as informações
    //     var informacoesContainer = new InformacoesContainer
    //     {
    //         Clientes = clientes,
    //         Parceiros = parceiros,
    //         Compradores = compradores
    //     };

    //     return View(informacoesContainer);
    // }
    
    [HttpPost]
    public IActionResult DoLogin(string email, string password)
    {
        object usuario = null; // pode armazenar qualquer tipo de objeto
        
        bool usuarioValido = false;

        if ((usuario = _contexto.clientes.FirstOrDefault(u => u.EmailCliente == email && u.SenhaCliente == password)) != null) {

            RepositorioGlobalVariables.Variables.isCliente = "true";
            RepositorioGlobalVariables.Variables.nome = ((Cliente)usuario).NomeCliente;
            usuarioValido = true;
        } else {
            RepositorioGlobalVariables.Variables.isCliente = "false";
        }
        
        if ((usuario = _contexto.parceiros.FirstOrDefault(u => u.EmailParceiro == email && u.SenhaParceiro == password)) != null) {

            RepositorioGlobalVariables.Variables.isParceiro = "true";
            RepositorioGlobalVariables.Variables.nome = ((Parceiro)usuario).NomeParceiro;
            usuarioValido = true;
        } else {
            RepositorioGlobalVariables.Variables.isParceiro = "false";
        }

        if ((usuario = _contexto.compradores.FirstOrDefault(u => u.EmailComprador == email && u.SenhaComprador == password)) != null) {

            RepositorioGlobalVariables.Variables.isComprador= "true";
            RepositorioGlobalVariables.Variables.nome = ((Comprador)usuario).RazaoSocial;
            usuarioValido = true;
        } else {
            RepositorioGlobalVariables.Variables.isComprador= "false";
        }

        if (!usuarioValido) {
            ViewData["Erro"] = "E-mail ou senha inválidos."; // NÃO FUNCIONA TEXUGO OU NERO ARRUMAR -> Deve aparacer uma mensagem de erro
            return  RedirectToAction("Login", "User");
        }
        
        Console.WriteLine(RepositorioGlobalVariables.Variables.isCliente);
        Console.WriteLine($"Attempting to log in with CPF: {email} and Password: {password}");
        
        return RedirectToAction("UpdateUserLogged", "Home");

    }
    
    [HttpPost]
    public async Task<IActionResult> DoClienteRegister(Cliente cliente, string numeroLogradouro) //inserir
    {      
        // Verifica se já existe um cliente com os mesmos atributos
        var clienteExistente = await _contexto.clientes
            .FirstOrDefaultAsync(c => 
            c.CpfCliente == cliente.CpfCliente || 
            c.EmailCliente == cliente.EmailCliente);

        if (clienteExistente != null)
        {
            // Retorna uma mensagem indicando que o cliente já existe
            ModelState.AddModelError(string.Empty, "Cliente já cadastrado com este CPF ou Email."); // NÃO FUNCIONA TEXUGO OU NERO ARRUMAR -> Deve aparacer uma mensagem de erro
            return RedirectToAction("UserRegister", "User");// Retorna a view com os dados preenchidos
        }

        
        cliente.LogradouroCliente = $"{cliente.LogradouroCliente} {numeroLogradouro}";
        
        await _contexto.clientes.AddAsync(cliente); 
        await _contexto.SaveChangesAsync();

        return RedirectToAction("UpdateUserLogged", "Home");
    }

    [HttpPost]
    public async Task<IActionResult> DoPartnerRegister(Parceiro parceiro, string numeroLogradouro)
    {   
        // Verifica se já existe um Parceiro com os mesmos atributos
        var parceiroExistente = await _contexto.parceiros
            .FirstOrDefaultAsync(c => 
            c.CpfParceiro == parceiro.CpfParceiro || 
            c.EmailParceiro == parceiro.EmailParceiro);

        if (parceiroExistente != null)
        {
            // Retorna uma mensagem indicando que o Parceiro já existe
            ModelState.AddModelError(string.Empty, "Parceiro já cadastrado com este CPF ou Email."); // NÃO FUNCIONA TEXUGO OU NERO ARRUMAR -> Deve aparacer uma mensagem de erro
            return RedirectToAction("PartnerRegister", "User");// Retorna a view com os dados preenchidos
        }
        
        parceiro.LogradouroParceiro = $"{parceiro.LogradouroParceiro} {numeroLogradouro}";

        await _contexto.parceiros.AddAsync(parceiro); 
        await _contexto.SaveChangesAsync();

        return RedirectToAction("UpdateUserLogged", "Home");
    }

    [HttpPost]
    public async Task<IActionResult> DoBuyerRegister(Comprador comprador, string numeroLogradouro)
    {      
        
        // Verifica se já existe um Parceiro com os mesmos atributos
        var compradorExistente = await _contexto.compradores
            .FirstOrDefaultAsync(c => 
            c.CnpjComprador == comprador.CnpjComprador || 
            c.EmailComprador == comprador.EmailComprador);

        if (compradorExistente != null)
        {
            // Retorna uma mensagem indicando que o Parceiro já existe
            ModelState.AddModelError(string.Empty, "Parceiro já cadastrado com este CPF ou Email."); // NÃO FUNCIONA TEXUGO OU NERO ARRUMAR -> Deve aparacer uma mensagem de erro
            return RedirectToAction("BuyerRegister", "User");// Retorna a view com os dados preenchidos
        }

        comprador.LogradouroComprador = $"{comprador.LogradouroComprador} {numeroLogradouro}";

        await _contexto.compradores.AddAsync(comprador); 
        await _contexto.SaveChangesAsync();

        return RedirectToAction("UpdateUserLogged", "Home");
    }

    [HttpPost]
    public async Task<IActionResult> ExcluirCliente(string cpfCliente)
    {      
        Cliente cliente = await _contexto.clientes.FindAsync(cpfCliente);
        _contexto.clientes.Remove(cliente);
        await _contexto.SaveChangesAsync();

        return RedirectToAction("UpdateUserLogged", "Home");
    }

}