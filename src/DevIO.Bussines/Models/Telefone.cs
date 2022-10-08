using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Models
{
    public class Telefone : Entity
    {
        public string ddd { get; set; }
        public string numero { get; set; }
        public virtual List<TelefoneClinica> TelefoneClinicas { get; set; }

    }
}
