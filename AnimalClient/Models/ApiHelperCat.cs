using System.Threading.Tasks;
using RestSharp;

namespace AnimalClient.Models
{
  class ApiHelperCat
    {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"cats", Method.GET);
      var response = await client.ExecuteAsync(request);
      return response.Content;
    }

    public static async Task<string> Get(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"cats/{id}", Method.GET);
      var response = await client.ExecuteAsync(request);
      return response.Content;
    }

    public static async Task Post(string newCat)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"cats", Method.POST);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newCat);
      var response = await client.ExecuteAsync(request);
    }

    public static async Task Put(int id, string newCat)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"cats/{id}", Method.PUT);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newCat);
      var response = await client.ExecuteAsync(request);
    }

    public static async Task Delete(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"cats/{id}", Method.DELETE);
      request.AddHeader("Content-Type", "application/json");
      var response = await client.ExecuteAsync(request);
    }
  }
}