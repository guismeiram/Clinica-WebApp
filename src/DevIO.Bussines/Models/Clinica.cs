using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Models
{
    public class Clinica : Entity
    {
        public string NomeClinica { get; set; }
        public List<Consulta> Consultas { get; set; }
    }
}
