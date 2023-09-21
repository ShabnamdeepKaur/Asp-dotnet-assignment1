using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HomeHelpHub.Models;

namespace HomeHelpHub.Controllers;

public class HomeController : Controller
{
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

    public IActionResult Brief()
    {
        List<Dictionary<string, object>> info =new(){
                new() { {"Company", "HomeHelpHub.com"}, 
                {"Company-Description", "Worker-Needy connection Hub"}, 
                {"Group-Members-And-Roles", "Shabnamdeep Kaur- the wholesole developer of this website."}  
                },
            };

            return View(info);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
