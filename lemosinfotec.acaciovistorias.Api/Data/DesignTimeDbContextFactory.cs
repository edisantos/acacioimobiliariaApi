using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace lemosinfotec.acaciovistorias.Api.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DataContexto>
    {
        public DataContexto CreateDbContext(string[] args)
        {
             var optionsBuilder = new DbContextOptionsBuilder<DataContexto>();
            optionsBuilder.UseMySql("Data Source=blog.db");

            return new DataContexto(optionsBuilder.Options);
        }
    }
}
