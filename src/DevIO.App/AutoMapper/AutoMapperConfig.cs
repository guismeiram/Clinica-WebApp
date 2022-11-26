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
            CreateMap<Clinica, ClinicaViewModel>().ReverseMap();
            CreateMap<Medico, MedicoViewModel>().ReverseMap();
         

        }
    }
}