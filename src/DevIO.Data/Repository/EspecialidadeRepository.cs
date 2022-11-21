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
    public class EspecialidadeRepository : Repository<Especialidade>, IEspecialidadeRepository
    {
        public EspecialidadeRepository(ClinicaDbContext db) : base(db)
        {
        }

        public async Task<IEnumerable<Especialidade>> ObterEspecialidadeMedico(string especialidadeId)
        {
            return await Db.Especialidade.Where(a => a.Id == especialidadeId)
                           .Include(a => a.Medicos)
                           .ThenInclude(b => b.Especialidade).ToListAsync();
        }
    }
}
