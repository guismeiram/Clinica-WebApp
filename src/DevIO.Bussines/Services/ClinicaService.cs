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

        public ClinicaService(INotificador notificador,  IClinicaRepository clinicaRepository) : base(notificador)
        {
            _clinicaRepository = clinicaRepository;
        }

        public async Task Adicionar(Clinica clinica)
        {
            if (!ExecutarValidacao(new ClinicaValidation(), clinica) 
                //|| !ExecutarValidacao(new ConsultaValidation(), clinica.Consultas)
                ) return;

            await _clinicaRepository.Adicionar(clinica);

        }

        public Task AtualizaClinica(Clinica clinica)
        {
            throw new NotImplementedException();
        }

        public async Task Atualizar(Clinica clinica)
        {
            if (!ExecutarValidacao(new ClinicaValidation(), clinica)) return;

            await _clinicaRepository.Atualizar(clinica);
        }

        public void Dispose()
        {
            _clinicaRepository?.Dispose();
        }

        public async Task Remover(string id)
        {
            await _clinicaRepository.Remover(id);
        }
    }
}
