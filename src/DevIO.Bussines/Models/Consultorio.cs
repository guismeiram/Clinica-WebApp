namespace DevIO.Bussines.Models
{
    public class Consultorio : Entity
    {
        public string? Numero { get; set; }
        public DateTime Data_Hora { get; set; }

        public virtual ICollection<Consulta>? Consulta { get; set; }

        
    }
}