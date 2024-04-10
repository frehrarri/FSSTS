using DAL.DAL;
using DAL.IDAL;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.Run();
