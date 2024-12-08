using e_saving.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace e_saving.Controllers.User;

public class UserController : Controller
{
    private readonly ILogger<UserController> _logger;
    
    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }

     public IActionResult Index()
    {
        return View();
    }
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

}