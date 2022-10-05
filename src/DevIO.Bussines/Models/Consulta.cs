using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Models
{
    public class Consulta : Entity
    {
        public int MedicoId { get; set; }
        public int ConsultorioId { get; set; }

        public Guid PacienteId { get; set; }
        public virtual Medico? Medico { get; set; }

        public virtual Consultorio? Consultorios { get; set; }

        public virtual Paciente? Paciente { get; set; }
    }
}
