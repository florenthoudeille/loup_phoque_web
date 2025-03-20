using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Loup_Phoque_web.Models;
using System.Collections.Generic;
using System.Linq;


namespace Loup_Phoque_web.Controllers;

public class HomeController : Controller
{

      // Simule une base de données de services
    private static List<string> Services = new List<string>
    {
        "SEO",
        "Marketing Digital",
        "Publicité en ligne",
        "Branding",
        "Gestion des réseaux sociaux",
        "Email Marketing"
    };

    public IActionResult Search(string query)
    {
        if (string.IsNullOrEmpty(query))
        {
            return View(new List<string>()); // Si rien n'est recherché, renvoie une liste vide
        }

        var results = Services
            .Where(s => s.ToLower().Contains(query.ToLower()))
            .ToList();

        return View(results);
    }
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Panier()
    {
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
