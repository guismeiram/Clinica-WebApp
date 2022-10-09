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
    public class PacienteConvenioMapping : IEntityTypeConfiguration<PacienteConvenio>
    {
        public void Configure(EntityTypeBuilder<PacienteConvenio> builder)
        {
            builder.HasKey(p => p.Id);


        }
    }
}
