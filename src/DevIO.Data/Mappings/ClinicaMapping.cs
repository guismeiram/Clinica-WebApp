using DevIO.Bussines.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Data.Mappings
{
    public class ClinicaMapping : IEntityTypeConfiguration<Clinica>
    {
        public void Configure(EntityTypeBuilder<Clinica> builder)
        {
            builder.HasKey(prop => prop.Id);

            //1 : N Clinica : Consultas
            builder.HasMany(e => e.Consultas)
                .WithOne(m => m.Clinica)
                .HasForeignKey(m => m.ClinicaId)
                .OnDelete(DeleteBehavior.Restrict);


            //1 : N Medico : Especialidades
            builder.HasMany(e => e.TelefoneClinicas)
                .WithOne(m => m.Clinica)
                .HasForeignKey(m => m.ClinicaId);
        }
    }
}
