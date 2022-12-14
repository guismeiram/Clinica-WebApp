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
    public class MedicoRepository : Repository<Medico>, IMedicoRepository
    {
        public MedicoRepository(ClinicaDbContext db) : base(db)
        {
        }

        public Task<Medico> obterMedicoConsulta(string id)
        {
            throw new NotImplementedException();
        }
    }
}
