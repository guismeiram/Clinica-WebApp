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
    public class ConsultorioMapping : IEntityTypeConfiguration<Consultorio>
    {
        public void Configure(EntityTypeBuilder<Consultorio> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(c => c.Numero)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(c => c.Data_Hora)
                .IsRequired()
                .HasColumnType("varchar(50)");

          

            builder.ToTable("Consultorio");
        }
    }
}
