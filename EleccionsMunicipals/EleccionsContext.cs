using EleccionsMunicipals.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleccionsMunicipals
{
    public class EleccionsContext :DbContext
    {
        public DbSet<Municipi> Municipis { get; set; }
        public DbSet<PartitMunicipi> PartitsPolitics { get; set; }
        public DbSet<TaulaElectoral> TaulesElectorals { get; set; }
        public DbSet<ResultatsTaula> ResultatsTaules { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer(@"Data Source=FORMACIO1\SQLEXPRESS03;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False; Database=EleccionsMunicipalsDB");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
