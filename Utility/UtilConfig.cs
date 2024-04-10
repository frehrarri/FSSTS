using Microsoft.Extensions.Configuration;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
