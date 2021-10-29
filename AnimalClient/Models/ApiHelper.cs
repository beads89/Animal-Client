// using System.Threading.Tasks;
// using RestSharp;

// namespace AnimalClient.Models
// {
//   class ApiHelper
//     {
//     public static async Task<string> GetAll()
//     {
//       RestClient client = new RestClient("http://localhost:5000/");
//       RestRequest requestCat = new RestRequest($"cats", Method.GET);
//       RestRequest requestDog = new RestRequest($"dogs", Method.GET);
//       var response = await client.ExecuteAsync(requestCat, requestDog);
//       return response.Content;
//     }

//     public static async Task<string> Get(int id)
//     {
//       RestClient client = new RestClient("http://localhost:5000/");
//       RestRequest requestCat = new RestRequest($"cats/{id}", Method.GET);
//       RestRequest requestDog = new RestRequest($"dogs/{id}", Method.GET);
//       var response = await client.ExecuteAsync(requestCat, requestDog);
//       return response.Content;
//     }
//   }
// }