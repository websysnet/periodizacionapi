namespace periodizacionapi.Domain
{
    public interface IDeportes
    {
        List<Deporte> GetAllDeportes();
        Deporte? GetDeporteById(int id);
    }
}
