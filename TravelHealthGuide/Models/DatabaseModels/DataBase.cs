using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using TravelHealthGuide.Models.DatabaseModels.Seeds;

namespace TravelHealthGuide.Models.DatabaseModels
{
    public class DataBase : DbContext
    {
        public DbSet<DestinationInfo> Destinations { get; set; }
        public DbSet<UserInfo> Users { get; set; }

        public DataBase()
        {
            // Memastikan database sudah terbuat
            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=TravelHealthGuide.db");

        // Default values
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DestinationsSeed destinationsSeed = new DestinationsSeed();
            modelBuilder.Entity<DestinationInfo>().HasData(destinationsSeed.Items);

            UsersSeed usersSeed = new UsersSeed();
            modelBuilder.Entity<UserInfo>().HasData(usersSeed.Items);
        }
    }
}