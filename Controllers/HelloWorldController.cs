using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Livraria.Controllers;

public class HelloWorldController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Welcome(string name, int numTimes = 1)
    {   
        ViewData["Message"] = "Oi " + name + "!";
        ViewData["NumTimes"] = numTimes;
        return View();
    }

}