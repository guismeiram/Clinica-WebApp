using DevIO.Bussines.Interface;
using DevIO.Bussines.Models;
using DevIO.Bussines.Models.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Services
{
    public class ConsultaService : BaseService, IConsultaService
    {
        private readonly IConsultaRepository _consultaRepository;
        private readonly IMedicoRepository _medicoRepository;
        private readonly IClinicaRepository _clinicaRepository;


        public ConsultaService(INotificador notificador, IConsultaRepository consultaRepository, IMedicoRepository medicoRepository, IClinicaRepository clinicaRepository) : base(notificador)
        {
            _consultaRepository = consultaRepository;  
            _medicoRepository = medicoRepository;
            _clinicaRepository = clinicaRepository;
        }

        public async Task Adicionar(Consulta consulta)
        {
            if (!ExecutarValidacao(new ConsultaValidation(), consulta)
                || !ExecutarValidacao(new ClinicaValidation(), consulta.Clinicas)) 
                    if(!ExecutarValidacao(new MedicoValidation(), consulta.Medicos))
                    return;
                return;

            if (_consultaRepository.Buscar(f => f.Id == consulta.Id).Result.Any())
            {
                Notificar("Já existe um ID infomado.");
                return;
            }

            await _consultaRepository.Adicionar(consulta);
        }

        public Task Atualizar(Consulta consulta)
        {
            throw new NotImplementedException();
        }

       
        public void Dispose()
        {
            _consultaRepository?.Dispose();
            _medicoRepository?.Dispose();
            _clinicaRepository?.Dispose();
        }

       

        public Task Remover(string id)
        {
            throw new NotImplementedException();
        }
    }
}
