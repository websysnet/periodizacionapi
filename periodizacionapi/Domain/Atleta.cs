namespace periodizacionapi.Domain
{
    public class Atleta
    {
        public int Id { get; set; }
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; } = DateTime.MinValue;
        public int Edad { get; set; }

        public string? Sexo { get; set; }

        public string? Categoria { get; set; }

        public int AniosEntrenamiento{ get; set; }

        public Deporte? Deporte { get; set; }

        public  Entrenador? Entrenador { get; set; }
    }
}
