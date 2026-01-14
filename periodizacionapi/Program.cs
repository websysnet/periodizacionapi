
using periodizacionapi.Domain;
using periodizacionapi.Infraestructure;
using periodizacionapi.Services;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/", () => "Bienvenidos a PeriodizacionAPI!").WithName("GetRootMessage");

app.MapGet("/health", () => Results.Ok(new { status = "Healthy" })).WithName("HealthCheck");    

app.MapGet("/deportes", () =>
{
    var deportesRepository = new periodizacionapi.Infraestructure.DeportesRepository();
    var deportesService = new periodizacionapi.Services.DeportesService(deportesRepository);

    var deportes = deportesService.GetAllDeportes();
    return Results.Ok(deportes);

}).WithName("GetDeportes");

app.MapGet("/deporte/{id}", (int id) =>
{
    var deportesRepository = new periodizacionapi.Infraestructure.DeportesRepository();
    var deportesService = new periodizacionapi.Services.DeportesService(deportesRepository);
    var deporte = deportesService.GetDeporteById(id);

    return deporte;

}).WithName("GetDeporteById");      

app.MapGet("/entrenador/{id}", (int id) =>
{
    var entrenadoresRepository = new periodizacionapi.Infraestructure.EntrenadoresRepository();
    var entrenadoresService = new periodizacionapi.Services.EntrenadoresService(entrenadoresRepository);
    var entrenador = entrenadoresService.GetEntrenadorById(id);

    return entrenador;

}).WithName("GetEntrenadorById");

app.MapGet("/entrenadores", () =>
{
    var entrenadoresRepository = new periodizacionapi.Infraestructure.EntrenadoresRepository();
    var entrenadoresService = new periodizacionapi.Services.EntrenadoresService(entrenadoresRepository);
    var entrenadores = entrenadoresService.GetAllEntrenadores();

    return Results.Ok(entrenadores);

}).WithName("GetEntrenadores");

app.MapGet("/atletas", () =>
{
    var atletasRepository = new periodizacionapi.Infraestructure.AtletasRepository();
    var atletasService = new periodizacionapi.Services.AtletasServices(atletasRepository);
    var atletas = atletasService.GetAtletas();
    return Results.Ok(atletas);
}).WithName("GetAtletas"); 


app.MapGet("/atleta/{id}", (int id) =>
{
    var atletasRepository = new periodizacionapi.Infraestructure.AtletasRepository();
    var atletasService = new periodizacionapi.Services.AtletasServices(atletasRepository);
    var atleta = atletasService.GetAtletaById(id);
    return atleta;
}).WithName("GetAtletaById");

app.Run();


