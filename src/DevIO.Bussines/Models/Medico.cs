namespace DevIO.Bussines.Models
{
    public class Medico : Entity
    {
        public string? Name { get; set; }
        public string? Crm { get; set; }
        public int Idade { get; set; }

        public virtual IEnumerable<Especialidade>? Especialidade { get; set; }

        public virtual IEnumerable<Consulta>? Consultas { get; set; }


        public Guid EspecialidadeId { get; set; }
    }
}