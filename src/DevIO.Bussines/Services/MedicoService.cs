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
    public class MedicoService : BaseService, IMedicoService
    {
        private readonly IMedicoRepository _medicoRepository;
        private readonly IConsultaRepository _consultaRepository;

        public MedicoService(INotificador notificador, IConsultaRepository consultaRepository, IMedicoRepository medicoRepository) : base(notificador)
        {
            _consultaRepository = consultaRepository;
            _medicoRepository = medicoRepository;
        }

        public async Task Adicionar(Medico medico)
        {
            if (!ExecutarValidacao(new MedicoValidation(), medico))
                  return;

            await _medicoRepository.Adicionar(medico);
        }

        public Task Atualizar(Medico medico)
        {
            throw new NotImplementedException();
        }

        public Task AtualizarMedico(Medico medico)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _medicoRepository?.Dispose();

        }

        public Task Remover(string id)
        {
            throw new NotImplementedException();
        }
    }
}
