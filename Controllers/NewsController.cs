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
        private readonly string _apiKey = "317c324993b59179ea11ef42dfd5dd0e";

        public NewsController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IActionResult> Index()
        {
            System.Net.ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            var apiUrl = $"https://gnews.io/api/v4/search?q=technology&token={_apiKey}";

            var response = await _httpClient.GetAsync(apiUrl);
            if (response.IsSuccessStatusCode)
            {
                var articlesResponse = JsonConvert.DeserializeObject<NewsApiResponse>(await response.Content.ReadAsStringAsync());
                var articles = articlesResponse.Articles;

                // Filter articles that have content and image
                var articlesWithContentAndImage = new List<NewsArticle>();
                foreach (var article in articles)
                {
                    if (!string.IsNullOrWhiteSpace(article.Content) && !string.IsNullOrWhiteSpace(article.Image))
                    {
                        articlesWithContentAndImage.Add(article);
                    }
                }

                return View(articlesWithContentAndImage);
            }

            // Handle the case when the response is not successful
            return View(new List<NewsArticle>()); // or return an error view with an empty model
        }
    }
}
