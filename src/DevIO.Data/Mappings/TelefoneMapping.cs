using DevIO.Bussines.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Data.Mappings
{
    public class TelefoneMapping : IEntityTypeConfiguration<Telefone>
    {
        public void Configure(EntityTypeBuilder<Telefone> builder)
        {
            builder.HasKey(prop => prop.Id);

            //1 : N Telefone : Clinicas
            builder.HasMany(e => e.TelefoneClinicas)
                .WithOne(m => m.Telefone)
                .HasForeignKey(m => m.TelefoneId);

            //1 : N Telefone : Medico
            builder.HasMany(e => e.TelefoneMedicos)
                .WithOne(m => m.Telefone)
                .HasForeignKey(m => m.TelefoneId);


            //1 : N Telefone : Pacientes
            builder.HasMany(e => e.TelefonePacientes)
                .WithOne(m => m.Telefone)
                .HasForeignKey(m => m.TelefoneId);
        }
    }
}
