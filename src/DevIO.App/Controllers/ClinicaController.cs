using AutoMapper;
using DevIO.App.Extensions;
using DevIO.App.ViewModels;
using DevIO.Bussines.Interface;
using DevIO.Bussines.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.App.Controllers
{
    [Authorize]
    public class ClinicaController : BaseController
    {
        private readonly IClinicaRepository _clinicaRepository;
        private readonly IClinicaService _clinicaService;
        private readonly IMapper _mapper;
        public ClinicaController(
            IClinicaRepository clinicaRepository,
            IClinicaService clinicaService,
            IMapper mapper,
            INotificador notificador) : base(notificador)
        {
            _clinicaRepository = clinicaRepository;
            _clinicaService = clinicaService;
            _mapper = mapper;
        }

        [AllowAnonymous]
        [Route("lista-de-clinicas")]
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<ClinicaViewModel>>(await _clinicaRepository.ObterTodos()));
        }

        [ClaimsAuthorize("clinica", "Adicionar")]
        [Route("novo-clinica")]
        public IActionResult Create()
        {
            return View();
        }

        [ClaimsAuthorize("Clinica", "Adicionar")]
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

