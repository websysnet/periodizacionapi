namespace periodizacionapi.Infraestructure
{
    using periodizacionapi.Domain;
    public interface IAtleta
    {
        public List<Atleta> GetAtletas();

        public Atleta? GetAtletaById(int id);

        
    }
}
