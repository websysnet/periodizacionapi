namespace periodizacionapi.Services
{
    using periodizacionapi.Domain;
    using periodizacionapi.Infraestructure;
    public class AtletasServices
    {
        private readonly IAtleta _atletaRepository;
        public AtletasServices(IAtleta atletaRepository)
        {
            _atletaRepository = atletaRepository;
        }
        public List<Atleta> GetAtletas()
        {
            return _atletaRepository.GetAtletas();
        }
        public Atleta? GetAtletaById(int id)
        {
            return _atletaRepository.GetAtletaById(id);
        }

    }
}
