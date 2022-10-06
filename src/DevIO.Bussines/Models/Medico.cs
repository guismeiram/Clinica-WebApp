namespace DevIO.Bussines.Models
{
    public class Medico : Entity
    {
        public string? Name { get; set; }
        public string? Crm { get; set; }
        public int Idade { get; set; }

        public virtual ICollection<Especialidade>? Especialidade { get; set; }

        public virtual ICollection<Consulta>? Consultas { get; set; }


    }
}