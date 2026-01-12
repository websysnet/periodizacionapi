namespace periodizacionapi.Infraestructure
{
    using periodizacionapi.Domain;

    public class  EntrenadoresRepository:IEntrenadores
    {

        private readonly List<Entrenador> entrenadores = new List<Entrenador>
        {
           new Entrenador
           {
               Id=1,
               Nombres="Juan Perez",
               Experiencia="Especialista en entrenamiento de fuerza y acondicionamiento físico.",
               Nivel=5,
               AniosExperiencia=10,
               LugarTrabajo="Gimnasio FitLife",
               deporte=new Deporte
               {
                   Id=1,
                   Nombre="Fútbol",
                   Descripcion="Deporte de equipo jugado entre dos conjuntos de once jugadores cada uno.",
                   Categoria="Deporte de equipo",
                   ImagenUrl="https://example.com/futbol.jpg"
               }
           },
              new Entrenador
              {
                Id=2,
                Nombres="Maria Gomez",
                Experiencia="Entrenadora certificada en yoga y pilates.",
                Nivel=4,
                AniosExperiencia=7,
                LugarTrabajo="Centro de Bienestar Zen",
                deporte=new Deporte
                {
                     Id=2,
                     Nombre="Yoga",
                     Descripcion="Disciplina física y mental originaria de la India.",
                     Categoria="Deporte individual",
                     ImagenUrl="https://example.com/yoga.jpg"
                }
              },
              new Entrenador
              {
                Id=3,
                Nombres="Carlos Rodriguez",
                Experiencia="Especialista en entrenamiento de resistencia y maratones.",
                Nivel=5,
                AniosExperiencia=12,
                LugarTrabajo="Club de Corredores Rápidos",
                deporte=new Deporte
                {
                     Id=3,
                     Nombre="Atletismo",
                     Descripcion="Conjunto de disciplinas deportivas que incluyen carreras, saltos y lanzamientos.",
                     Categoria="Deporte individual",
                     ImagenUrl="https://example.com/atletismo.jpg"
                }
              }
        };
        public List<Entrenador> getAllEntrenadores()
        {
            return entrenadores;
        }

        public Entrenador getEntrenador(int id)
        {
            if(id == 0)
            {
                throw new ArgumentException("El ID no puede ser cero.");

            }
            else
            {
                var entrenador = entrenadores.FirstOrDefault(e => e.Id == id);
                if (entrenador == null)
                {
                    throw new KeyNotFoundException($"No se encontró un entrenador con ID {id}.");
                }
                return entrenador;
            }
        }

    }
}
