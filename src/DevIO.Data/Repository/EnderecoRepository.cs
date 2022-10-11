using DevIO.Bussines.Interface;
using DevIO.Bussines.Models;
using DevIO.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(ClinicaDbContext db) : base(db)
        {
        }

        public Task<Endereco> ObterEnderecoClinica(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Endereco> ObterEnderecoMedico(string id)
        {
            throw new NotImplementedException();
        }
    }
}
