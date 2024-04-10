using DAL.DAL;
using DAL.IDAL;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ILoginDAL, LoginDAL>();
builder.Services.AddScoped<IAccountInfoDAL, AccountInfoDAL>();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.Run();
