using Core.Entidades;
using Core.IRepositorio;
using Core.IService;
using Api.Endpoints;
using Service;
using ZapatosRepo;
using ServiceZapatos;
using calzadosIService;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

builder.Services.AddScoped<Repocliente>();
builder.Services.AddScoped<IClienteService, ServiceCliente>();
builder.Services.AddScoped<IRepoDevolucion, RepoDevolucion>();
builder.Services.AddScoped<IDevolucionService, ServiceDevolucion>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapEndpointsCliente();

app.MapGet("/clientes", (Repocliente repoCliente) =>
{
    var clientes = repoCliente.GetClientes();
    return Results.Ok(clientes);
});

app.MapPost("/devoluciones", (Devolucion devolucion, IDevolucionService service) =>
{
    var resultado = service.AltaDevolucion(devolucion);
    return resultado.Success
        ? Results.Created($"/devoluciones/{resultado.Data!.idDevolucion}", resultado.Data)
        : Results.BadRequest(resultado);
});

app.Run();