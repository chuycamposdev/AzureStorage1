using AzureBlobStorage.AzureStorage;
using AzureBlobStorage.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.Configure<AzureOptionsModel>(
    builder.Configuration.GetSection("AzureOptions"));

builder.Services.AddScoped<AzureBlobOptions>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
