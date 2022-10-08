using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Models
{
    public class TelefoneClinica : Entity
    {
        public string ClinicaId { get; set; }
        public string TelefoneId { get; set; }

        // relacionamentos
        public virtual Telefone Telefone { get; set; }
        public virtual Clinica Clinica { get; set; }
    }
}
