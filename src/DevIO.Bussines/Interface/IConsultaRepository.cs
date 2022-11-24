using DevIO.Bussines.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Interface
{
    public interface IConsultaRepository : IRepository<Consulta>
    {

        Task<Consulta> obterConsultaMedico(string id);

        
   
    }
}
