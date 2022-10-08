using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Models
{
    public class TelefoneMedico : Entity
    {
        public string MedicoId { get; set; }
        public string TelefoneId { get; set; }

        // relacionamentos
        public virtual Telefone Telefone { get; set; }
        public virtual Medico Medico { get; set; }
    }
}
