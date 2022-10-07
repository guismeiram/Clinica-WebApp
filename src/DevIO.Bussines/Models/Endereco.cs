using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Models
{
    public class Endereco : Entity
    {
        public string MedicoId { get; set; }

        // relacionamentos
        public virtual Medico Medico { get; set; }
    }
}
