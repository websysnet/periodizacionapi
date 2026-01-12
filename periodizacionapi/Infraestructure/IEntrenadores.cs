using periodizacionapi.Domain;

namespace periodizacionapi.Infraestructure
{
    public interface IEntrenadores
    {
        public List<Entrenador> getAllEntrenadores();

        public Entrenador getEntrenador(int id);
    }
}
