using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.Extensions;
namespace lemosinfotec.acaciovistorias.Data.Data
{
    public class Factory : IDesignTimeDbContextFactory<DataContexto>
    {
        public DataContexto CreateDbContext(string[] args)
        {
            
           var optionsBuilder = new DbContextOptionsBuilder<DataContexto>();
           optionsBuilder.UseMySql("Server=localhost;DataBase=DbRealEstate;Uid=root;Pwd=@Lemos318730");
           return new DataContexto(optionsBuilder.Options);
        }
    }
}
