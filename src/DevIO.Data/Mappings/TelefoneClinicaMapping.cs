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
    public class TelefoneClinicaMapping : IEntityTypeConfiguration<TelefoneClinica>
    {
        

        public void Configure(EntityTypeBuilder<TelefoneClinica> builder)
        {
            builder.HasKey(prop => prop.Id);
        }
    }
}
