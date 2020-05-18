using System;
using lemosinfotec.acaciovistorias.Data.EntityConfig;
using lemosinfotec.acaciovistorias.domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace lemosinfotec.acaciovistorias.Data.Data
{
    public class DataContexto:DbContext
    {
        //Intidades
        public DbSet<Imobiliarias> Imobiliarias {get;set;}
        public DataContexto(DbContextOptions<DataContexto> options)
        :base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder){


            builder.ApplyConfiguration(new ImobiliariaConfiguration());
            base.OnModelCreating(builder);

        }
    }
}
