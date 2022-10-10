using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.App.ViewModels
{
    public class Especialidade
    {
        public string id { get; set; }
        public string Nome { get; set; }
        public virtual List<MedicoEspecialidade> Medicos { get; set; }

    }
}
