using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.App.ViewModels
{
    public class Clinica
    {

        public string id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Ddd { get; set; }

        // relacionamentos
        public virtual List<Consulta> Consultas { get; set; }


        public virtual Endereco Endereco { get; set; }

        public String ClinicaId { get; set; }

    }
}
