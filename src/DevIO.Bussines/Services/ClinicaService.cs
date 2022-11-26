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
    public class ClinicaService : BaseService, IClinicaService
    {
        private readonly IClinicaRepository _clinicaRepository;
        private readonly IConsultaRepository _consultaRepository;

        public ClinicaService(INotificador notificador, IConsultaRepository consultaRepository, IClinicaRepository clinicaRepository) : base(notificador)
        {
            _consultaRepository = consultaRepository;
            _clinicaRepository = clinicaRepository;
        }

        public async Task Adicionar(Clinica clinica)
        {
            if (!ExecutarValidacao(new ClinicaValidation(), clinica))
                return;

            await _clinicaRepository.Adicionar(clinica);
        }

        public Task Atualizar(Clinica clinica)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _clinicaRepository?.Dispose();
        }

        public Task Remover(string id)
        {
            throw new NotImplementedException();
        }
    }
}
