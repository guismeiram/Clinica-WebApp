using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Data.Context
{
    public class ClinicaContextFactory : IDesignTimeDbContextFactory<ClinicaDbContext>
    {
        public ClinicaDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ClinicaDbContext>();
            builder.UseSqlServer("Server=GUILHERME\\GUISMEIRAM;Database=clinicaDb;User Id=sa;Password=1234;");
            return new ClinicaDbContext(builder.Options);
        }
    }
}
