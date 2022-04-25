using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace WeatherWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IHttpClientFactory _httpClientFactory;

        public IEnumerable<IDictionary<string, string>> Forecasts { get; private set; }

        [BindProperty]
        public string Search { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;

            Search = "";
        }

        private async Task<IActionResult> FetchForecasts()
        {
            var httpClient = _httpClientFactory?.CreateClient("RESTService");
            var response = await httpClient.GetAsync(Search.Any() ? $"/weatherforecast?city={Search.ToLower()}" : "/weatherforecast");

            if (response.IsSuccessStatusCode)
            {
                var contentStream = await response.Content.ReadAsStreamAsync();
                var forecasts = await JsonSerializer.DeserializeAsync<IEnumerable<IDictionary<string, string>>>(contentStream);

                Forecasts = forecasts;

                return Page();
            }

            return RedirectToPage("./Error");
        }

        public async Task<IActionResult> OnGetAsync()
        {
            return await FetchForecasts();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            return await FetchForecasts();
        }
    }
}