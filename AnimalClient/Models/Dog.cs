using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AnimalClient.Models
{
  public class Dog
  {
    public int DogId { get; set; }
    public string DogName { get; set; }
    public string DogGender { get; set; }
    public string DogBreed { get; set; }
    public string DogColor { get; set; }
    public static List<Dog> GetDogs()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);

      List<Dog> dogList = JsonConvert.DeserializeObject<List<Dog>>(jsonResponse.ToString());

      return dogList;
    }
    public static Dog GetDetails(int id)
    {
      var apiCallTask = ApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Dog dog = JsonConvert.DeserializeObject<Dog>(jsonResponse.ToString());

      return dog;
    }
    public static void Post(Dog dog)
    {
      string jsonDog = JsonConvert.SerializeObject(dog);
      var apiCallTask = ApiHelper.Post(jsonDog);
    }

    public static void Put(Dog dog)
    {
      string jsonDog = JsonConvert.SerializeObject(dog);
      var apiCallTask = ApiHelper.Put(dog.DogId, jsonDog);
    }

    public static void Delete(int id)
    {
      var apiCallTask = ApiHelper.Delete(id);
    }
  }
}