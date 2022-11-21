﻿
using DevIO.App.Extensions;
using DevIO.Bussines.Interface;
using DevIO.Bussines.Notificacoes;
using DevIO.Bussines.Services;
using DevIO.Data.Context;
using DevIO.Data.Repository;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;

namespace DevIO.App.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<ClinicaDbContext>();
            services.AddScoped<IClinicaRepository, ClinicaRepository>();

            services.AddScoped<IConsultaRepository, ConsultaRepository>();
            services.AddScoped<IEspecialidadeRepository, EspecialidadeRepository>();
            services.AddScoped<IMedicoRepository, MedicoRepository>();
            services.AddScoped<IPacienteRepository, PacienteRepository>();

            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IClinicaService, ClinicaService>();
            services.AddScoped<IConsultaService, ConsultaService>();

            services.AddScoped<IMedicoService, MedicoService>();
    
         
            return services;
        }
    }
}