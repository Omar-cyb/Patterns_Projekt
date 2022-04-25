using Microsoft.AspNetCore.Http.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<Repository>();
builder.Services.Configure<JsonOptions>(config =>
{
    config.SerializerOptions.AddWheatherModelsConverters();
});
builder.Services.AddCors(cors =>
{
    cors.AddPolicy("RepositoryCorsPolicy", options => options.WithOrigins("http://localhost:5001"));
});

var app = builder.Build();

app.UseCors(options => options.WithOrigins("http://localhost:5001"));

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

using (var scope = app.Services.CreateScope())
{
    var repository = scope.ServiceProvider.GetService<Repository>();
    if (repository is null)
    {
        throw new Exception("Repository is not loaded.");
    }
    repository.Seed();
}

app.MapGet("/forecasts", (Repository repo) =>
{
    return repo.Forecasts.ToArray();
})
.WithName("GetForecasts");

//app.Run();

app.Run("http://localhost:7051");
