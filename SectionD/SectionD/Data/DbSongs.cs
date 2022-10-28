using System;
using SectionD.Models;
using Microsoft.EntityFrameworkCore;

namespace SectionD.Data
{
    public class DbSongs:DbContext
    {
        public DbSongs(DbContextOptions<DbSongs>options):base(options)
        {
        }

        public DbSet<Songs> Songs { get; set; } 
        public DbSet<Genres> Genres { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Songs>().ToTable("Song");
            modelBuilder.Entity<Genres>().ToTable("Genre");
        }

    }
}

