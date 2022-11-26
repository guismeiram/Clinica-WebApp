using DevIO.Bussines.Interface;
using DevIO.Bussines.Models;
using DevIO.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
                           .Include(c => c.Medicos)
                           .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Consulta> obterConsultaClinica(string id)
        {
            return await Db.Consulta.AsNoTracking()
                            .Include(f => f.Medicos)
                            .FirstOrDefaultAsync(p => p.Id == id);
        }

       

        public Task<List<Consulta>> obterConsultaMedicoClinica()
        {
            return (from consulta in Db.Consulta
                    join clinica in Db.Clinica on consulta.ClinicaId equals clinica.Id
                    join medico in Db.Medico on consulta.MedicoId equals medico.Id
                    select new
                    {
                        consulta
                    }).ToListAsync();
            
        }


        //return sameConsulta;


        /*from consulta in Db.Consulta
                                       join Clinica in Db.Clinica on consulta.ClinicaId equals Clinica.Id
                                       join Medico in Db.Medico on consulta.MedicoId equals Medico.Id
                                       where Clinica.Id == consulta.ClinicaId && Medico.Id == consulta.MedicoId
                                       select new{ Consulta.Clinicas, Consulta.Medicos };*/
        //on inventoryItemOne.Model
        /* from Consulta2 in Db.Consulta
                                       join Clinica2 in Db.Clinica on Consulta2.ClinicaId equals Clinica2.Id
                                       join Medico2 in Db.Medico on Consulta2.MedicoId equals Medico2.Id
                                       where Clinica2.Id == Consulta2.ClinicaId && Medico2.Id == Consulta2.MedicoId*/

        /*var Resultado = from Consulta in 
                        join _A in bd.Animals on _C.id equals _A.idCliente
                        join _T in bd.TipoAnimals on _A.idTipoAnimal equals _T.id
                        select new
                        {
                            Nome = _C.nome,
                            Animal = _A.nome,
                            Tipo = _T.nome
                        };*/



        /*return from Consulta in Db.Consulta join Clinica in Db.Clinica on Consulta.ClinicaId equals Clinica.Id
                                          join Medico in Db.Medico on Consulta.MedicoId equals Medico.Id
                                          where (Clinica.Id == Consulta.ClinicaId && Medico.Id == Consulta.MedicoId)
                                          select new { Consulta = Consulta};*/
        //}
        /*return await Db.Consulta.AsNoTracking().Include(f => f.Medicos)
                   .FirstOrDefaultAsync(p => p.Id == id);*/

    }
}
