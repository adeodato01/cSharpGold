using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpGold
{
    class GameContext : DbContext
    {
        public DbSet<Location> Locations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=cSharpGold;Integrated Security=True;Connect Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasKey(e => e.LocationNumber)
                    .HasName("PK_Locations");

                entity.Property(e => e.LocationNumber)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LocationName)
                    .IsRequired();
            });
        }
    }
}
