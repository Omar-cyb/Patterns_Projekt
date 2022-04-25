using Microsoft.AspNetCore.Http.Json;
using Microsoft.Extensions.Options;
using Microsoft.Net.Http.Headers;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<JsonOptions>(config =>
{
    config.SerializerOptions.AddWheatherModelsConverters();
});

// Add http client (to connect to a repository)
builder.Services.AddHttpClient("Repository", httpClient =>
{
    httpClient.BaseAddress = new Uri("http://localhost:7051");

    httpClient.DefaultRequestHeaders.Add(
        HeaderNames.Accept, "application/json");
    httpClient.DefaultRequestHeaders.Add(
        HeaderNames.UserAgent, "WeatherThreeTier");
});

// Use CORS for connections
builder.Services.AddCors(cors =>
{
    cors.AddPolicy("RESTServiceCorsPolicy", options => options.WithOrigins("http://localhost:3001"));
});

var app = builder.Build();

app.UseCors(options => options.WithOrigins("http://localhost:3001"));


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.MapGet("/weatherforecast", async (IHttpClientFactory clientFactory, IOptions<JsonOptions> options, string? city) =>
{
    if (clientFactory is null)
    {
        return Results.Problem("Server error", statusCode: 500);
    }

    var httpClient = clientFactory?.CreateClient("Repository");

    var response = await httpClient.GetAsync("/forecasts");
    if (response.IsSuccessStatusCode)
    {
        var contentStream = await response.Content.ReadAsStreamAsync();
        var forecasts = await JsonSerializer.DeserializeAsync<IEnumerable<ForecastDTO>>(contentStream, options.Value.SerializerOptions);

        if (forecasts is not null)
        {
            if (city is null)
            {
                return Results.Ok(forecasts);
            }
            else
            {
                var filtered = forecasts.Where(forecast => forecast.City.ToString().ToLower().Equals(city));
                if (filtered.Any())
                {
                    return Results.Ok(filtered);
                }
                return Results.NoContent();
            }
        }
        return Results.Problem("Unable to load data from repository.", statusCode: 500);
    }
    return Results.Problem("Unable to load data from repository.", statusCode: 500);
})
.WithName("GetWeatherForecast")
.Produces(200)
.Produces(204)
.ProducesProblem(500);

//app.Run();

app.Run("http://localhost:5001");
