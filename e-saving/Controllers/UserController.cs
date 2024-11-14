using Microsoft.AspNetCore.Mvc;


namespace e_saving.Controllers.User;

public class UserController : Controller
{
    private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }

    public IActionResult Register()
    {
        return View();
    }
    public IActionResult Login()
    {
        return View();
    }

}