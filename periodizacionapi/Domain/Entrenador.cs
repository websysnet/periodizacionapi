namespace periodizacionapi.Domain
{
    public class Entrenador
    {
        public int Id { get; set; }
        public string? Nombres { get; set; }

        public string? Experiencia { get; set; }

        public int Nivel { get; set; }  

        public int AniosExperiencia { get; set; }

        public int imagenUrl { get; set; }

        public string? LugarTrabajo { get; set; }

        public Deporte deporte { get; set; } = new Deporte();

    }
}
