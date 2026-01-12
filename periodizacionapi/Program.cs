
using periodizacionapi.Domain;
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
    var deportes = new List<Deporte>
    {
        new Deporte { Id = 1, Nombre = "Fútbol", Descripcion = "Deporte de equipo jugado con una pelota.", Categoria = "Deporte de equipo", ImagenUrl = "https://example.com/futbol.jpg" },
        new Deporte { Id = 2, Nombre = "Baloncesto", Descripcion = "Deporte de equipo jugado con una pelota y una canasta.", Categoria = "Deporte de equipo", ImagenUrl = "https://example.com/baloncesto.jpg" },
        new Deporte { Id = 3, Nombre = "Natación", Descripcion = "Deporte acuático que consiste en nadar.", Categoria = "Deporte individual", ImagenUrl = "https://example.com/natacion.jpg" }
    };
    return Results.Ok(deportes);

}).WithName("GetDeportes");

app.Run();


