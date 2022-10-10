namespace DevIO.App.ViewModels
{
    public class Consulta 
    {
        public string id { get; set; }  
        public string MedicoId { get; set; }
        public string ClinicaId { get; set; }
        public string PacienteId { get; set; }

        public DateTime Data { get; set; }

        // relacionamentos
        public virtual Medico Medico { get; set; }
        public virtual Clinica Clinica { get; set; }
        public virtual Paciente Paciente { get; set; }

    }
}