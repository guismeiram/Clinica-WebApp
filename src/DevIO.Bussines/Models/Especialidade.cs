using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Models
{
    public class Especialidade : Entity
    {
        public string Nome { get; set; }
        public virtual IEnumerable<MedicoEspecialidade> Medicos { get; set; }

    }
}
