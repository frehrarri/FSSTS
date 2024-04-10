using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RPAEntityFramework;
using RPAEntityFramework.Contexts;

var builder = WebApplication.CreateBuilder(args);

//Entity Framework
string dev = builder.Configuration.GetConnectionString("Development");
builder.Services.AddDbContext<EntityContext>(options => options.UseSqlServer(dev));

var app = builder.Build();

app.Run();
