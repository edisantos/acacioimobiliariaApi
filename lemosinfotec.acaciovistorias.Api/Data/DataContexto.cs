using Microsoft.EntityFrameworkCore;

namespace lemosinfotec.acaciovistorias.Api.Data
{
    public class DataContexto:DbContext
    {
        public DataContexto(DbContextOptions<DataContexto> options)
        :base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder){


           // builder.ApplyConfiguration(new ImobiliariaConfiguration());
            base.OnModelCreating(builder);

        
        }
    }
}