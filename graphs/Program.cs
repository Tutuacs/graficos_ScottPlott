using System.Reflection.Metadata;
using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using Microsoft.AspNetCore.Mvc;
using ScottPlot;
using System.IO;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

GraphService graphService = new();

app.MapGet("/graph1", () =>
{
    byte[] imageBytes = graphService.Graph1();
    return Results.Content(Convert.ToBase64String(imageBytes.ToArray()));
});

app.MapGet("/graph2", () =>
{
    graphService.Graph2();
    return Results.Ok();
});

app.MapGet("/graph3", () =>
{
    graphService.Graph3();
    return Results.Ok();
});

app.MapGet("/graph4", () =>
{
    graphService.Graph4();
    return Results.Ok();
});

app.Run();

record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}