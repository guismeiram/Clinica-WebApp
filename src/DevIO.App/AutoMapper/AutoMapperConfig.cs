using AutoMapper;
using DevIO.App.ViewModels;
using DevIO.Bussines.Models;

namespace DevIO.App.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Clinica, ClinicaViewModel>().ReverseMap();
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
            CreateMap<Convenio, ConvenioViewModel>().ReverseMap();
            CreateMap<Consulta, ConsultaViewModel>().ReverseMap();
            CreateMap<Especialidade, EspecialidadeViewModel>().ReverseMap();
            CreateMap<Medico, MedicoViewModel>().ReverseMap();
            CreateMap<MedicoEspecialidade, MedicoEspecialidadeViewModel>().ReverseMap();
            CreateMap<Paciente, PacienteViewModel>().ReverseMap();
            CreateMap<Pagamento, PagamentoViewModel>().ReverseMap();
            CreateMap<TipoPagamento, TipoPagamentoViewModel>().ReverseMap();
            CreateMap<PacienteTipoPagamento, PacienteTipoPagamentoViewModel>().ReverseMap();

        }
    }
}