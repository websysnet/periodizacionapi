namespace periodizacionapi.Infraestructure
{
    using periodizacionapi.Domain;

    public class DeportesRepository : IDeportes
    {
        private readonly List<Deporte> deportes = new List<Deporte>
        {
            new Deporte { Id = 1, Nombre = "Fútbol", Descripcion = "Deporte de equipo jugado entre dos conjuntos de once jugadores cada uno.", Categoria = "Deporte de equipo", ImagenUrl = "https://example.com/futbol.jpg" },
            new Deporte { Id = 2, Nombre = "Baloncesto", Descripcion = "Deporte de equipo en el que dos conjuntos de cinco jugadores intentan anotar puntos lanzando una pelota a través de un aro.", Categoria = "Deporte de equipo", ImagenUrl = "https://example.com/baloncesto.jpg" },
            new Deporte { Id = 3, Nombre = "Natación", Descripcion = "Deporte acuático que consiste en desplazarse en el agua utilizando los brazos y las piernas.", Categoria = "Deporte individual", ImagenUrl = "https://example.com/natacion.jpg" },
            new Deporte { Id = 4, Nombre = "Tenis", Descripcion = "Deporte de raqueta que se juega entre dos jugadores (individual) o dos parejas (dobles).", Categoria = "Deporte individual", ImagenUrl = "https://example.com/tenis.jpg" }
        };
        public List<Deporte> GetAllDeportes()
        {
            return deportes;
        }
        public Deporte? GetDeporteById(int id)
        {
            return deportes.FirstOrDefault(d => d.Id == id);
        }

    }
       

}
