using AutoMapper;
using DevIO.App.ViewModels;
using DevIO.Bussines.Models;

namespace DevIO.App.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Consulta, ConsultaViewModel>().ReverseMap();
            CreateMap<Especialidade, EspecialidadeViewModel>().ReverseMap();
            CreateMap<Medico, MedicoViewModel>().ReverseMap();
            CreateMap<MedicoEspecialidade, MedicoEspecialidadeViewModel>().ReverseMap();
         

        }
    }
}