using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Models
{
    public class Clinica : Entity
    {
        public string Nome { get; set; }
        

        // relacionamentos
        public virtual List<Consulta> Consultas { get; set; }

        public virtual List<TelefoneClinica> TelefoneClinicas { get; set; }

        public virtual Endereco Endereco { get; set; }

        public String ClinicaId { get; set; }

    }
}
