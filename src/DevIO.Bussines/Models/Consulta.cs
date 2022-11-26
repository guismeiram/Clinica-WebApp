namespace DevIO.Bussines.Models
{
    public class Consulta : Entity
    {
        

        public DateTime Data { get; set; }
        public string NomePaciente { get; set; }
        public string IdadePaciente { get; set; }
        public string RgPaciente { get; set; }
        public string CpfPaciente { get; set; }
        public string NomeEspecialidade { get; set; }

        //ids
        public string MedicoId { get; set; }
        public string ClinicaId { get; set; }

        // relacionamentos
        public virtual Medico Medicos { get; set; }
        public virtual Clinica Clinicas { get; set; }

    }
}