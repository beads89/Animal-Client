using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AnimalClient.Models;

namespace AnimalClient.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
      _logger = logger;
    }
    // WIP WIP WIP
    // [HttpGet("/")]
    public IActionResult Index()
    {
      dynamic model = new ExpandoObject();
      model.Cats = Cat.GetCats();
      model.Dogs = Dog.GetDogs();

      return View(model);
    }
    // public IActionResult Index()
    // {

    //   return RedirectToAction("Index", "cats");
    // }

    public IActionResult Privacy()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
