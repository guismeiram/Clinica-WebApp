namespace DevIO.Bussines.Models
{
    public class Consulta : Entity
    {
        public string MedicoId { get; set; }

        public DateTime Data { get; set; }

        public string NomeClinica { get; set; }
        public string TelefoneClinica { get; set; }
        public string NomePaciente { get; set; }
        public string IdadePaciente { get; set; }
        public string RgPaciente { get; set; }
        public string CpfPaciente { get; set; }

        // relacionamentos
        public virtual Medico Medico { get; set; }

    }
}