using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Models
{
    public class Clinica : Entity
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Ddd { get; set; }

        // relacionamentos
        public virtual Consulta Consultas { get; set; }



    }
}
