using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevIO.Bussines.Models;

namespace DevIO.Data.Mappings
{
    public class ConsultaMapping : IEntityTypeConfiguration<Consulta>
    {
        public void Configure(EntityTypeBuilder<Consulta> builder)
        {
            builder.HasKey(p => p.Id);


            // 1 : 1 => Paciente : Medico
            builder.HasOne(f => f.Paciente)
                .WithOne(e => e.Consulta);
          

            // 1 : N => Consultorios : Consulta
            builder.HasMany(c => c.Medicos)
                .WithOne(n => n.Consultas)
                .HasForeignKey(n => n.ConsultaId);

            // 1 : N => Consultorios : Consulta
            builder.HasMany(c => c.Consultorios)
                .WithOne(n => n.Consultas)
                .HasForeignKey(c => c.ConsultaId);

            builder.ToTable("Consulta");
        }

       
    }
}
