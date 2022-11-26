using AutoMapper;
using DevIO.App.ViewModels;
using DevIO.Bussines.Interface;
using DevIO.Bussines.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.App.Controllers
{
    [Authorize]
    public class ConsultaController : BaseController
    {

        private readonly IMedicoRepository _medicoRepository;
        private readonly IConsultaRepository _consultaRepository;
        private readonly IClinicaRepository _clinicaRepository;

        private readonly IMedicoService _medicoService;
        private readonly IClinicaService _clinicaService;
        private readonly IConsultaService _consultaService;

        private readonly IMapper _mapper;

        public ConsultaController(INotificador notificador, IMedicoRepository medicoRepository, IConsultaRepository consultaRepository, IClinicaRepository clinicaRepository, IMedicoService medicoService, IClinicaService clinicaService, IConsultaService consultaService) : base(notificador)
        {
            _medicoRepository = medicoRepository;
            _consultaRepository = consultaRepository;
            _clinicaRepository = clinicaRepository;
            _medicoService = medicoService;
            _clinicaService = clinicaService;
            _consultaService = consultaService;
        }


        [AllowAnonymous]
        [Route("lista-de-consulta")]
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<Consulta>>(_consultaRepository.obterConsultaMedicoClinica()));
        }//.obterConsultaMedicoClinica())

        //[ClaimsAuthorize("Clinica", "Adicionar")]
        [AllowAnonymous]
        [Route("nova-consulta")]
        public IActionResult Create()
        {
            return View();
        }

        //[ClaimsAuthorize("Consulta", "Adicionar")]
        [AllowAnonymous]
        [Route("nova-consulta")]
        [HttpPost]
        public async Task<IActionResult> Create(ConsultaViewModel consultaViewModel)
        {
            if (!ModelState.IsValid) return View(consultaViewModel);

            var consulta = _mapper.Map<Consulta>(consultaViewModel);

            await _consultaService.Adicionar(consulta);

            if (!OperacaoValida()) return View(consultaViewModel);

            return RedirectToAction("Index");
        }
    }
}
