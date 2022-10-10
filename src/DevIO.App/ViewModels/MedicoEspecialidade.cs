namespace DevIO.App.ViewModels
{
    public class MedicoEspecialidade
    {
        public String Id { get; set; }
        public string MedicoId { get; set; }
        public string EspecialidadeId { get; set; }

        // relacionamentos
        public virtual Medico Medico { get; set; }
        public virtual Especialidade Especialidade { get; set; }
    }
}