var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

// 1. Registrar Repocliente en el contenedor de inyección de dependencias
builder.Services.AddScoped<Repocliente>();

var app = builder.Build();

// Configuración del pipeline HTTP
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/clientes", (Repocliente repoCliente) =>
{
    var clientes = repoCliente.GetClientes();
    return Results.Ok(clientes);
});

app.Run();