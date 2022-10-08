using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Models
{
    public class Clinica : Entity
    {
        public string Name { get; set; }

        // relacionamentos
        public virtual List<Consulta> Consultas { get; set; }

        public virtual List<TelefoneClinica> TelefoneClinicas { get; set; }
    }
}
