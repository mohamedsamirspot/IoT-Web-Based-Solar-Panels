using Microsoft.EntityFrameworkCore;
using SolarPanels.Models.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolarPanels.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



        }

        public DbSet<Panel> Panel { get; set; }
        public DbSet<SensorsReading> SensorsReading { get; set; }
        public DbSet<ManualMode> ManualMode { get; set; }
    }
}