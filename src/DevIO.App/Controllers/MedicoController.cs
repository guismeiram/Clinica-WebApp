using AutoMapper;
using DevIO.Api.Extensions;
using DevIO.App.ViewModels;
using DevIO.Bussines.Interface;
using DevIO.Bussines.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.App.Controllers
{
    public class MedicoController : BaseController
    {
        private readonly IConsultaRepository _consultaRepository;
        private readonly IMedicoRepository _medicoRepository;
        private readonly IMedicoService _medicoService;
        private readonly IMapper _mapper;

        public MedicoController(IConsultaRepository consultaRepository,
                                  IMedicoRepository medicoRepository,
                                  IMapper mapper,
                                  IMedicoService medicoService, 
                                  INotificador notificador) : base(notificador)
        {
            _consultaRepository = consultaRepository;
            _medicoRepository = medicoRepository;
            _medicoService = medicoService;
            _mapper = mapper;
        }

        [AllowAnonymous]
        [Route("lista-de-Medicos")]
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<MedicoViewModel>>(await _medicoRepository.ObterTodos()));
        }

        //[ClaimsAuthorize("Medico", "Adicionar")]
        [AllowAnonymous]
        [Route("novo-medico")]
        public IActionResult Create()
        {
            return View();
        }

        //[ClaimsAuthorize("Medico", "Adicionar")]
        [AllowAnonymous]
        [Route("novo-medico")]
        [HttpPost]
        public async Task<IActionResult> Create(MedicoViewModel medicoViewModel)
        {
            if (!ModelState.IsValid) return View(medicoViewModel);

            var medico = _mapper.Map<Medico>(medicoViewModel);

            await _medicoService.Adicionar(medico);

            if (!OperacaoValida()) return View(medicoViewModel);

            return RedirectToAction("Index");
        }



    }
}
