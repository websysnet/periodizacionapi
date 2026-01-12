namespace periodizacionapi.Services
{
    using periodizacionapi.Domain;
    using periodizacionapi.Infraestructure;
    public class DeportesService
    {
        private readonly IDeportes _deportesRepository;
        public DeportesService(IDeportes deportesRepository)
        {
            _deportesRepository = deportesRepository;
        }
        public List<Deporte> GetAllDeportes()
        {
            return _deportesRepository.GetAllDeportes();
        }
        public Deporte? GetDeporteById(int id)
        {
            return _deportesRepository.GetDeporteById(id);
        }
    }
}
