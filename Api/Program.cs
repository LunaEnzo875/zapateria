using Api;
using Api.Endpoints;
using Core.Entidades;
using Core.IRepositorio;
using Core.IService;
using Service;
using Scalar.AspNetCore;
using ServiceZapatos;
using calzadosIService;
using ZapatosRepo;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

builder.Services.AddScoped<IDataBaseConnectionService, DatabaseConnectionService>();
builder.Services.AddScoped<IGetRolActualService, CurrentRolService>();
builder.Services.AddScoped<IAdo, Ado>();

builder.Services.AddScoped<Repocliente>();
builder.Services.AddScoped<IRepoCliente, Repocliente>();
builder.Services.AddScoped<IClienteService, ServiceCliente>();
builder.Services.AddScoped<IRepoColor, RepoColor>();
builder.Services.AddScoped<IColorService, ServiceColor>();
builder.Services.AddScoped<IRepoDetalleCompra, RepoDetalleCompra>();
builder.Services.AddScoped<IDetallleCompraService, ServiceDetCom>();
builder.Services.AddScoped<IRepoDevolucion, RepoDevolucion>();
builder.Services.AddScoped<IDevolucionService, ServiceDevolucion>();
builder.Services.AddScoped<IRepoFabricante, RepoFabricante>();
builder.Services.AddScoped<IFabricanteService, ServiceFabricante>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();

    app.MapScalarApiReference(); 
}

app.UseHttpsRedirection();

app.MapEndpointsCliente();
app.MapEndpointsColor();
app.MapEndpointsCompra();
app.MapEndpointsDetalleCompra();
app.MapEndpointsFabricante();

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