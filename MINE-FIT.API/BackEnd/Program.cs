using Microsoft.EntityFrameworkCore;
using MINE_FIT.API;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=minefit.db"));

var app = builder.Build();

app.MapGet("/", () => "Mine-Fit API rodando!");

app.Run();
