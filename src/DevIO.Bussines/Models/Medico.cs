namespace DevIO.Bussines.Models
{
    public class Medico : Entity
    {
        public string Name { get; set; }
        public string Crm { get; set; }
        public int Idade { get; set; }

        // relacionamentos
        public virtual Endereco Endereco { get; set; }
        public virtual List<Consulta> Consultas { get; set; }
        public virtual List<MedicoEspecialidade> Especialidades { get; set; }
    }
}