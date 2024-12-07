using Microsoft.AspNetCore.Mvc;


namespace e_saving.Controllers.User;

public class UserController : Controller
{
    private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
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

    [HttpPost]
    public IActionResult DoLogin()
    {
        // aqui vai o codigo pra quando o cara logar

        return RedirectToAction("Index", "Home");
    }
    public IActionResult DoRegister()
    {
         // aqui vai o codigo pra quando o cara se cadastrar

        return RedirectToAction("Index", "Home");
    }
    

}