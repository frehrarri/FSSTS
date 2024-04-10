using RPADAL.DAL;
using RPADAL.IDAL;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ILoginDAL, LoginDAL>();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.Run();
