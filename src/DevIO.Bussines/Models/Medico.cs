namespace DevIO.Bussines.Models
{
    public class Medico : Entity
    {
        public string Nome { get; set; }
        public string Crm { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        public string Ddd { get; set; }
        // relacionamentos
        public virtual List<Consulta> Consultas { get; set; }

       
    }
}