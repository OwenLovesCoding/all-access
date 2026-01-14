using all_access.Models;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace all_access.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Link(IHttpClientFactory _httpClient, IConfiguration configuration)
    {
        private readonly IHttpClientFactory _httpClientFactory = _httpClient;
        private readonly IConfiguration _configuration = configuration;


        private readonly string rebrandlyApiKey = configuration["Rebrandly:ApiKey"]!;
        private readonly string rebrandlyWorkSpaceId = configuration["Rebrandly:WorkSpaceId"]!;

        [HttpPost("send-link")]
        public async Task<string> ShortenLink([FromBody] Create_Link urlStruc)
        {
            try
            {
                var client = _httpClientFactory.CreateClient();

                client.DefaultRequestHeaders.Add("apikey", rebrandlyApiKey);
                client.DefaultRequestHeaders.Add("workspace", rebrandlyWorkSpaceId);

                var linkRequest = new
                {
                    destination = urlStruc.SourceUrl,
                    domain = new { fullName = "rebrand.ly" }
                };

                var urlString = new StringContent(JsonSerializer.Serialize(linkRequest), Encoding.UTF8, Application.Json);

                using var httpResponseMessage = await client.PostAsync("https://api.rebrandly.com/v1/links", urlString);

                httpResponseMessage.EnsureSuccessStatusCode();

                var responseContent = await httpResponseMessage.Content.ReadAsStringAsync();

                var parseRes = JsonDocument.Parse(responseContent);

                string shortUrl = parseRes.RootElement.GetProperty("shortUrl").GetString()!;
                return shortUrl;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw new Exception("Error creating HTTP request", ex);
            }
       }
    }
}
