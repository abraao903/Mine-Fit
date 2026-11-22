using Microsoft.EntityFrameworkCore;
using MINE_FIT.API;
using System.Collections.Generic;

var builder = WebApplication.CreateBuilder(args);

List<Instrutores> listaInstrutores = new List<Instrutores>();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=DataBase/MINE-FIT.db"));

var app = builder.Build();

app.MapGet("/", () => "Mine-Fit API rodando!");
app.MapGet("/cadastrados", () => "alunos cadastrados");
app.MapPost("/api/instrutor/listar", () =>
{
    return listaInstrutores;
});
app.MapGet("/alunos/cadastrar", () => "cadastrar alunos");
app.MapPost("/instrutor/cadastrar", (Instrutores Instrutor) =>
{
    listaInstrutores.Add(Instrutor);
});


app.Run();