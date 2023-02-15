using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NIGHTWEAR.Models;

namespace NIGHTWEAR.Controllers;

public class HomeController : Controller

{

    private readonly string wwwrootDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
    private readonly ILogger<HomeController> _logger;
  

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        
        return View();
    }

    public IActionResult About()
    {
        return View();
    }
    public IActionResult Wholesalers()
    {
        return View();
    }
    public IActionResult Contact()
    {
        return View();
    }
    public IActionResult Cqueen()
    {
        return View();
    }
    public IActionResult Gharana()
    {
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

