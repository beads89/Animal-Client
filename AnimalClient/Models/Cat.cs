using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AnimalClient.Models
{
    public class Cat
  {
    public int CatId { get; set; }
    public string CatName { get; set; }
    public string CatGender { get; set; }
    public string CatBreed { get; set; }
    public string CatColor { get; set; }
    public static List<Cat> GetCats()
    {
      var apiCallTask = ApiHelperCat.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);

      List<Cat> catList = JsonConvert.DeserializeObject<List<Cat>>(jsonResponse.ToString());

      return catList;
    }
    public static Cat GetDetails(int id)
    {
      var apiCallTask = ApiHelperCat.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Cat cat = JsonConvert.DeserializeObject<Cat>(jsonResponse.ToString());

      return cat;
    }
    public static void Post(Cat cat)
    {
      string jsonCat = JsonConvert.SerializeObject(cat);
      var apiCallTask = ApiHelperCat.Post(jsonCat);
    }

    public static void Put(Cat cat)
    {
      string jsonCat = JsonConvert.SerializeObject(cat);
      var apiCallTask = ApiHelperCat.Put(cat.CatId, jsonCat);
    }

    public static void Delete(int id)
    {
      var apiCallTask = ApiHelperCat.Delete(id);
    }
  }
}