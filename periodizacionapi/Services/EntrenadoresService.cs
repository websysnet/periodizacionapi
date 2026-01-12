namespace periodizacionapi.Services
{
    using periodizacionapi.Domain;
    using periodizacionapi.Infraestructure;
    public class EntrenadoresService
    {
        private readonly IEntrenadores _entrenadoresRepository;

        public EntrenadoresService(IEntrenadores entrenadoresRepository)
        {
            _entrenadoresRepository = entrenadoresRepository;
        }

        public List<Entrenador> GetAllEntrenadores()
        {
            return _entrenadoresRepository.getAllEntrenadores();
        }

        public Entrenador? GetEntrenadorById(int id)
        {
            return _entrenadoresRepository.getEntrenador(id);
        }
    }
}
