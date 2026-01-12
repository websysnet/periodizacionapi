using periodizacionapi.Domain;

namespace periodizacionapi.Infraestructure
{
    public interface IDeportes
    {
        List<Deporte> GetAllDeportes();
        Deporte? GetDeporteById(int id);
    }
}
