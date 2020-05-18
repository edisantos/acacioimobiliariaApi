using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace lemosinfotec.acaciovistorias.Data.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DataContexto>
    {
        public DataContexto CreateDbContext(string[] args)
        {
             var optionsBuilder = new DbContextOptionsBuilder<DataContexto>();
            optionsBuilder.UseMySql("Server=localhost;DataBase=DbRealEstate;Uid=root;Pwd=@Lemos318730");

            return new DataContexto(optionsBuilder.Options);
        }
    }
}