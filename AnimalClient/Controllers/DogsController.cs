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
    
    public class DogsController : Controller
    {
      public IActionResult Index()
      {
        var allDogs = Dog.GetDogs();
        return View(allDogs);
      }

      [HttpPost]
      public IActionResult Index(Dog dog)
      {
        Dog.Post(dog);
        return RedirectToAction("Index");
      }

      public IActionResult Details(int id)
      {
        var dog = Dog.GetDetails(id);
        return View(dog);
      }

      [HttpPost]
      public IActionResult Details(int id, Dog dog)
      {
        dog.DogId = id;
        Dog.Put(dog);
        return RedirectToAction("Details", id);
      }

      public IActionResult Edit(int id)
      {
        var dog = Dog.GetDetails(id);
        return View(dog);
      }

      public IActionResult Delete(int id)
      {
        Dog.Delete(id);
        return RedirectToAction("Index");
      }
    }
}