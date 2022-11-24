using DevIO.Bussines.Interface;
using DevIO.Bussines.Models;
using DevIO.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Data.Repository
{
    public class ConsultaRepository : Repository<Consulta>, IConsultaRepository
    {
        public ConsultaRepository(ClinicaDbContext db) : base(db)
        {
        }

        public async Task<Consulta> obterConsultaMedico(string id)
        {
            return await Db.Consulta.AsNoTracking()
                           .Include(c => c.Medico)
                           .FirstOrDefaultAsync(c => c.Id == id);
        }

       
    }
}
