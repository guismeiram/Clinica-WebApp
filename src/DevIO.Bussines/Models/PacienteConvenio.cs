using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Models
{
    public class PacienteConvenio : Entity
    {
        public string PacienteId { get; set; }
        public string ConvenioId { get; set; }

        // relacionamentos
        public virtual Paciente Paciente { get; set; }
        public virtual Convenio Convenio { get; set; }
    }
}
