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

        /*[AllowAnonymous]
        [Route("novo-clinica")]
        public async Task<IActionResult> Create()
        {
            var clinicaViewModel = await PopularFornecedores(new ClinicaViewModel());

            return View(clinicaViewModel);
        }*/

        //[ClaimsAuthorize("Clinica", "Adicionar")]
        [AllowAnonymous]
        [Route("nova-clinica")]
        public IActionResult Create()
        {
            return View();
        }

       // [ClaimsAuthorize("Clinica", "Adicionar")]
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

        [AllowAnonymous]
        //[ClaimsAuthorize("Fornecedor", "Editar")]
        [Route("editar-clinica/{id:guid}")]
        [HttpPost]
        public async Task<IActionResult> Edit(string id)
        {
            var clinicaViewModel = await ObterClinica(id);

            if (clinicaViewModel == null)
            {
                return NotFound();
            }

            return View(clinicaViewModel);
        }

        [AllowAnonymous]
        //[ClaimsAuthorize("Produto", "Editar")]
        [Route("editar-clinica/{id:guid}")]
        [HttpPost]
        public async Task<IActionResult> Edit(string id, ClinicaViewModel clinicaViewModel)
        {
            if (id != clinicaViewModel.Id) return NotFound();

            var clinicaAtualizacao = await ObterClinica(id);
            clinicaViewModel.Ddd = clinicaAtualizacao.Ddd;
            clinicaViewModel.Telefone = clinicaAtualizacao.Telefone;
            clinicaViewModel.Nome = clinicaAtualizacao.Nome;
            if (!ModelState.IsValid) return View(clinicaViewModel);

            

            await _clinicaService.Atualizar(_mapper.Map<Clinica>(clinicaAtualizacao));

            if (!OperacaoValida()) return View(clinicaViewModel);

            return RedirectToAction("Index");
        }








        [AllowAnonymous]
        // [ClaimsAuthorize("Fornecedor", "Excluir")]
        [Route("excluir-clinica/{id:guid}")]
        public async Task<IActionResult> Delete(string id)
        {
            var clinicaViewModel = await ObterClinica(id);

            if (clinicaViewModel == null)
            {
                return NotFound();
            }

            return View(clinicaViewModel);
        }

        [AllowAnonymous]
        //[ClaimsAuthorize("Produto", "Excluir")]
        [Route("excluir-clinica/{id:guid}")]
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var produto = await ObterClinica(id);

            if (produto == null)
            {
                return NotFound();
            }

            await _clinicaService.Remover(id);

            if (!OperacaoValida()) return View(produto);

            TempData["Sucesso"] = "Produto excluido com sucesso!";

            return RedirectToAction("Index");
        }

        /*[ClaimsAuthorize("Fornecedor", "Excluir")]
        [Route("excluir-fornecedor/{id:guid}")]
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var fornecedor = await ObterFornecedorEndereco(id);

            if (fornecedor == null) return NotFound();

            await _fornecedorService.Remover(id);

            if (!OperacaoValida()) return View(fornecedor);

            return RedirectToAction("Index");
        }

        /*[AllowAnonymous]
        [Route("obter-endereco-fornecedor/{id:guid}")]
        public async Task<IActionResult> ObterEndereco(Guid id)
        {
            var fornecedor = await ObterFornecedorEndereco(id);

            if (fornecedor == null)
            {
                return NotFound();
            }

            return PartialView("_DetalhesEndereco", fornecedor);
        }

        [ClaimsAuthorize("Fornecedor", "Editar")]
        [Route("atualizar-endereco-fornecedor/{id:guid}")]
        public async Task<IActionResult> AtualizarEndereco(Guid id)
        {
            var fornecedor = await ObterFornecedorEndereco(id);

            if (fornecedor == null)
            {
                return NotFound();
            }

            return PartialView("_AtualizarEndereco", new FornecedorViewModel { Endereco = fornecedor.Endereco });
        }*/

        private async Task<ClinicaViewModel> ObterClinica(string id)
        {
            return _mapper.Map<ClinicaViewModel>(await _clinicaRepository.ObterPorId(id));
        }


    }
}

