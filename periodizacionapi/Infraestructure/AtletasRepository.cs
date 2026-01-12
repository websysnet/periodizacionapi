namespace periodizacionapi.Infraestructure
{
    using periodizacionapi.Domain;
    public class AtletasRepository: IAtleta
    {
        private readonly List<Atleta> _atletas = new List<Atleta>
        {
            new Atleta
            {
                Id = 1,
                Nombres = "Juan",
                Apellidos = "Pérez",
                FechaNacimiento = new DateTime(1995, 5, 20),
                Edad = 29,
                Sexo = "Masculino",
                Categoria = "Senior",
                AniosEntrenamiento = 10,
                Deporte = new Deporte { Id = 1, Nombre = "Fútbol", Descripcion = "Deporte de equipo jugado entre dos conjuntos de once jugadores cada uno.", Categoria = "Deporte de equipo", ImagenUrl = "https://example.com/futbol.jpg" },
                Entrenador = new Entrenador { Id = 1, Nombres = "Carlos",  AniosExperiencia = 15 , Experiencia = "Entrenador de fútbol con amplia experiencia en ligas profesionales." , LugarTrabajo = "Club Deportivo Nacional" }
            },
            new Atleta
            {
                Id = 2,
                Nombres = "María",
                Apellidos = "López",
                FechaNacimiento = new DateTime(2000, 8, 15),
                Edad = 23,
                Sexo = "Femenino",
                Categoria = "Sub-23",
                AniosEntrenamiento = 5,
                Deporte = new Deporte { Id = 3, Nombre = "Natación", Descripcion = "Deporte acuático que consiste en desplazarse en el agua utilizando los brazos y las piernas.", Categoria = "Deporte individual", ImagenUrl = "https://example.com/natacion.jpg" },
                Entrenador = new Entrenador { Id = 2, Nombres = "Ana" }
            },
            new Atleta
            {
                Id = 3,
                Nombres = "Luis",
                Apellidos = "Ramírez",
                FechaNacimiento = new DateTime(1998, 3, 10),
                Edad = 25,
                Sexo = "Masculino",
                Categoria = "Senior",
                AniosEntrenamiento = 7,
                Deporte = new Deporte { Id = 2, Nombre = "Baloncesto", Descripcion = "Deporte de equipo en el que dos conjuntos de cinco jugadores intentan anotar puntos lanzando una pelota a través de un aro.", Categoria = "Deporte de equipo", ImagenUrl = "https://example.com/baloncesto.jpg" },
                Entrenador = new Entrenador { Id = 1, Nombres = "Carlos" }
            },
            new Atleta             {
                Id = 4,
                Nombres = "Sofía",
                Apellidos = "Díaz",
                FechaNacimiento = new DateTime(2002, 11, 5),
                Edad = 21,
                Sexo = "Femenino",
                Categoria = "Sub-23",
                AniosEntrenamiento = 4,
                Deporte = new Deporte { Id = 4, Nombre = "Tenis", Descripcion = "Deporte de raqueta que se juega entre dos jugadores (individual) o dos parejas (dobles).", Categoria = "Deporte individual", ImagenUrl = "https://example.com/tenis.jpg" },
                Entrenador = new Entrenador { Id = 3, Nombres = "Luis" }
            }
        };

        public List<Atleta> GetAtletas()
        {
            return _atletas;
        }

        public Atleta? GetAtletaById(int id)
        {
            Atleta? atleta = _atletas.FirstOrDefault(a => a.Id == id);
            if(atleta == null)
            {
                throw new KeyNotFoundException("Atleta no encontrado.");
            }else
            {
                return atleta;
            }
        }   

    }
}
