namespace DevIO.Bussines.Models
{
    public class Paciente : Entity
    {
        public string? Name { get; set; }

        public Consulta? Consulta { get; set; }
    }
}