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


            builder.ToTable("Consulta");
        }

       
    }
}
