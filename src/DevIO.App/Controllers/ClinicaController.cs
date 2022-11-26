using AutoMapper;
using DevIO.App.ViewModels;
using DevIO.Bussines.Interface;
using DevIO.Bussines.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.App.Controllers
{
    public class ClinicaController : BaseController
    {
        private readonly IConsultaRepository _consultaRepository;
        private readonly IClinicaRepository _clinicaRepository;
        private readonly IClinicaService _clinicaService;
        private readonly IMapper _mapper;

        public ClinicaController(IConsultaRepository consultaRepository,
                                  IClinicaRepository clinicaRepository,
                                  IMapper mapper,
                                  IClinicaService clinicaService,
                                  INotificador notificador) : base(notificador)
        {
            _consultaRepository = consultaRepository;
            _clinicaRepository = clinicaRepository;
            _clinicaService = clinicaService;
            _mapper = mapper;
        }

        [AllowAnonymous]
        [Route("lista-de-Clinicas")]
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<Clinica>>(await _clinicaRepository.ObterTodos()));
        }

        //[ClaimsAuthorize("Clinica", "Adicionar")]
        [AllowAnonymous]
        [Route("nova-clinica")]
        public IActionResult Create()
        {
            return View();
        }

        //[ClaimsAuthorize("Clinica", "Adicionar")]
        [AllowAnonymous]
        [Route("nova-clinica")]
        [HttpPost]
        public async Task<IActionResult> Create(ClinicaViewModel clinicaViewModel)
        {
            if (!ModelState.IsValid) return View(clinicaViewModel);

            var clinica = _mapper.Map<Clinica>(clinicaViewModel);

            await _clinicaService.Adicionar(clinica);

            if (!OperacaoValida()) return View(clinicaViewModel);

            return RedirectToAction("Index");
        }

    }
}
