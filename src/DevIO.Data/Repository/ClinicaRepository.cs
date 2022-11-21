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
    public class ClinicaRepository : Repository<Clinica>, IClinicaRepository
    {
        public ClinicaRepository(ClinicaDbContext db) : base(db)
        {

        }

        public async Task<IEnumerable<Clinica>> ObterClinicaConsultaEndereco(string id)
        {
            return await Db.Clinica.Where(c => c.Id == id)
                .Include(a => a.Consultas)
                .Include(a => a.Consultas.Medico)
                .Include(a => a.Consultas.Medico.Especialidades)
                .Include(a => a.Consultas.Paciente)
                .ToListAsync();
        }
    }
}
