using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using Microsoft.EntityFrameworkCore;

namespace TravelHealthGuide.Models.DatabaseModels
{
    public class databaseContext : DbContext
    {
        public databaseContext()
        {
            Database.Migrate();
        }
        public DbSet<DestinationInfo> Destinations { get; set; }
        public DbSet<UserInfo> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=TravelHealthGuide.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DestinationsSeed seed = new DestinationsSeed();
            modelBuilder.Entity<DestinationInfo>().HasData(seed.Items);

            MessageBox.Show("Database is being initialized for the first time.");
            //}
        }
    }
}