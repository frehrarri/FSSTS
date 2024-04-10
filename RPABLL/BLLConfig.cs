using RPADAL.DAL;
using RPADAL.IDAL;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ILoginDAL, LoginDAL>();
builder.Services.AddScoped<IAccountInfoDAL, AccountInfoDAL>();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.Run();
