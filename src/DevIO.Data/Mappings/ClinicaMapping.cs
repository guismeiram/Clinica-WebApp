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


            builder.Property(c => c.Telefone)
            .IsRequired()
            .HasColumnType("varchar(200)");

            builder.Property(c => c.Ddd)
                .IsRequired()
                .HasColumnType("varchar(200)");

            //1 : 1 Clinica : Consultas
            builder.HasOne(e => e.Consultas)
                .WithOne(m => m.Clinica);
       

            /*1 : 1 Clinica : Endereco
            builder.HasOne(e => e.Endereco)
                .WithOne(m => m.Clinica);*/
        }
    }
}
