using Vitor.Models;
using Microsoft.AspNetCore.Mvc;
using Vitor;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Projeto - Folha de pagamento");

app.MapGet("/api/funcionario/listar", ([FromServices] AppDataContext ctx) =>
{
    if (ctx.tabFuncionario.Any())
    {
        return Results.Ok(ctx.tabFuncionario.ToList());
    }
    return Results.NotFound("Não há funcionários!");
});

app.MapPost("/api/funcionario/cadastrar", ([FromBody] Funcionario funcionario, [FromServices] AppDataContext ctx) =>
{

    Funcionario? funEncontrado = ctx.tabFuncionario.FirstOrDefault(x => x.Nome == funcionario.Nome);
    if (funEncontrado is null)
    {

        ctx.tabFuncionario.Add(funcionario);
        ctx.SaveChanges();
        return Results.Created("", funcionario);
    }
    return Results.BadRequest("Esse funcionário já foi cadastrado!");


});

app.MapGet("/api/folha/listar", ([FromServices] AppDataContext ctx) =>
{
    if (ctx.tabFolha.Any())
    {
        return Results.Ok(ctx.tabFolha.ToList());
    }
    return Results.NotFound("Sem folha!");
});

app.MapPost("/api/folha/cadastrar", ([FromBody] Folha f, [FromServices] AppDataContext ctx) =>
{
    ctx.tabFolha.Add(f);
    ctx.SaveChanges();
    return Results.Created("", f);
});
app.MapGet("/api/folha/buscar/{Cpf}/{Mes}/{Ano}", ([FromRoute] string Cpf, [FromRoute] int Mes, [FromRoute] int Ano,  [FromServices] AppDataContext ctx) =>
{
    Folha? folha = ctx.tabFolha.Find(Cpf, Mes, Ano);
    if (folha is null)
    {
        return Results.NotFound("Folha de funcionário não encontrada!");
    }
    Calculos.Calcular();
    return Results.Ok(folha);
});
app.Run();
