using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using EntityFramework;
using EntityFramework.Contexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<EntityContext>();

var app = builder.Build();

app.Run();
