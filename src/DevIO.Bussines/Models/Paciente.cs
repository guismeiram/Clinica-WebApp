using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Models
{
    public class Paciente : Entity
    {
        public string? Name { get; set; }
        public Consulta? Consulta { get; set; }
    }
}
