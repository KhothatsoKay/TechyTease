using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;


namespace Blog.Controllers
{
    public class NewsController : Controller

    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey = "63f0550476b54a4592813df9c6866b91";

        public NewsController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

       
      public async Task<IActionResult> Index()
{
    System.Net.ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
    var apiUrl = $"https://newsapi.org/v2/top-headlines?category=technology&apiKey={_apiKey}";

    var response = await _httpClient.GetAsync(apiUrl);
    if (response.IsSuccessStatusCode)
    {
        var articlesResponse = JsonConvert.DeserializeObject<NewsApiResponse>(await response.Content.ReadAsStringAsync());
        var articles = articlesResponse.Articles;

        return View(articles);
    }

    // Handle the case when the response is not successful
    return View(new List<NewsArticle>()); // or return an error view with an empty model
}

}
}
