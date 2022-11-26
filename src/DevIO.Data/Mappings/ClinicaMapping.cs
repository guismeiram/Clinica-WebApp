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
    public class ClinicaMapping : IEntityTypeConfiguration<Clinica>
    {
        public void Configure(EntityTypeBuilder<Clinica> builder)
        {
            builder.HasKey(prop => prop.Id);


            builder.Property(c => c.NomeClinica)
                .IsRequired()
                .HasColumnType("varchar(200)");


            /*// 1 : N => Fornecedor : Produtos
        builder.HasMany(f => f.Produtos)
            .WithOne(p => p.Fornecedor)
            .HasForeignKey(p => p.FornecedorId);*/

            // 1 : N => Consultas : Clinicas
            builder.HasMany(f => f.Consultas)
                .WithOne(p => p.Clinicas)
                .HasForeignKey(p => p.ClinicaId);
        }
    }
}
