using Microsoft.EntityFrameworkCore;
using MINE_FIT.API;
using System.Collections.Generic;

var builder = WebApplication.CreateBuilder(args);

List<Instrutores> listaInstrutores = new List<Instrutores>();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=DataBase/MINE-FIT.db"));

var app = builder.Build();

app.MapGet("/", () => "Mine-Fit API rodando!");
app.MapGet("/api/instrutor/listar", () =>
{
    if (listaInstrutores.Count == 0)
        return Results.NotFound("A lista está vazia");
    return Results.Ok(listaInstrutores);
});

app.MapGet("/alunos/cadastrar", () => "cadastrar alunos");

app.MapPost("/instrutor/cadastrar", (Instrutores? Instrutor) =>
{
    if (Instrutor is null)
        return Results.BadRequest("Nenhum dado informado");

    if (listaInstrutores.Any(x => x.Nome == Instrutor.Nome))
    {
        return Results.BadRequest("Já cadastrado(a)");
    }
    listaInstrutores.Add(Instrutor);
    return Results.Created("", Instrutor);
});


app.Run();  