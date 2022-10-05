using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Models
{
    public class Especialidade : Entity
    {
        public string? Especialidades { get; set; }

        public Medico? Medico { get; set; }

        public Guid MedicoId { get; set; }

    }
}
