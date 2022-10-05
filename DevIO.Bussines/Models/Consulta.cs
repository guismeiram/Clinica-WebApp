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
        public virtual ICollection<Medico> Medico { get; set; }
        public virtual ICollection<Consultorio> Consultorio { get; set; }

        public virtual Paciente Paciente { get; set; }
    }
}
