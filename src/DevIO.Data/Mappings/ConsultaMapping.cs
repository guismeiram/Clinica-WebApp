﻿using DevIO.Bussines.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Data.Mappings
{
    public class ConsultaMapping : IEntityTypeConfiguration<Consulta>
    {
        public void Configure(EntityTypeBuilder<Consulta> builder)
        {
            builder.HasKey(prop => prop.Id);


            builder.Property(c => c.IdadePaciente)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(c => c.CpfPaciente)
                .IsRequired()
                .HasColumnType("varchar(50)");


            builder.Property(c => c.RgPaciente)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(c => c.NomePaciente)
                .IsRequired()
                .HasColumnType("varchar(50)");


            builder.Property(c => c.TelefoneClinica)
                .IsRequired()
                .HasColumnType("varchar(200)");

            
        }
    }
}
