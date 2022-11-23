namespace DevIO.App.ViewModels
{
    public class ConsultaViewModel 
    {
        public string id { get; set; }  
        public string MedicoId { get; set; }
       

        public DateTime Data { get; set; }
        public string NomeClinica { get; set; }
        public string TelefoneClinica { get; set; }
        public string NomePaciente { get; set; }
        public string IdadePaciente { get; set; }
        public String RgPaciente { get; set; }
        public String CpfPaciente { get; set; }
        public string NomeEspecialidade { get; set; }


        // relacionamentos
        public virtual MedicoViewModel Medico { get; set; }

    }
}