namespace DevIO.App.ViewModels
{
    public class Medico 
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Crm { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        public string Ddd { get; set; }
        // relacionamentos
        public virtual Endereco Endereco { get; set; }
        public virtual List<Consulta> Consultas { get; set; }
        public virtual List<MedicoEspecialidade> Especialidades { get; set; }

    }
}