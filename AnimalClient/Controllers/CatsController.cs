using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AnimalClient.Models;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace AnimalClient.Controllers
{
    
    public class CatsController : Controller
    {
      public IActionResult Index()
      {
        var allCats = Cat.GetCats();
        return View(allCats);
      }

      [HttpPost]
      public IActionResult Index(Cat cat)
      {
        Cat.Post(cat);
        return RedirectToAction("Index");
      }

      public IActionResult Details(int id)
      {
        var cat = Cat.GetDetails(id);
        return View(cat);
      }

      [HttpPost]
      public IActionResult Details(int id, Cat cat)
      {
        cat.CatId = id;
        Cat.Put(cat);
        return RedirectToAction("Details", id);
      }

      public IActionResult Edit(int id)
      {
        var cat = Cat.GetDetails(id);
        return View(cat);
      }

      public IActionResult Delete(int id)
      {
        Cat.Delete(id);
        return RedirectToAction("Index");
      }
    }
}