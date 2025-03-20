using Microsoft.AspNetCore.Mvc;

public class AccountController : Controller
{
    [HttpGet] // Assure que cette route GET existe
    public IActionResult Login()
    {
        return View(); // Retourne la vue Login.cshtml
    }
}
