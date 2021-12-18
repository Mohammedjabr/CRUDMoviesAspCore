using Microsoft.EntityFrameworkCore;
using Movies.Models;
using System;

namespace Movies.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>()
                .HasData(new Genre() { Id = 1, Name = "Action" });
            modelBuilder.Entity<Genre>()
                 .HasData(new Genre() { Id = 2, Name = "Drama" });
            modelBuilder.Entity<Genre>()
                .HasData(new Genre() { Id = 3, Name = "Crime" });
            modelBuilder.Entity<Genre>()
                .HasData(new Genre() { Id = 4, Name = "Biography" });
            modelBuilder.Entity<Genre>()
                .HasData(new Genre() { Id = 5, Name = "Adventure" });
            modelBuilder.Entity<Genre>()
                .HasData(new Genre() { Id = 6, Name = "Western" });
            modelBuilder.Entity<Genre>()
                .HasData(new Genre() { Id = 7, Name = "Horror" });
            modelBuilder.Entity<Genre>()
                .HasData(new Genre() { Id = 8, Name = "Romance" });
            modelBuilder.Entity<Genre>()
                .HasData(new Genre() { Id = 9, Name = "Commedy" });
            modelBuilder.Entity<Genre>()
                .HasData(new Genre() { Id = 10, Name = "Fantasy" });
            modelBuilder.Entity<Genre>()
                .HasData(new Genre() { Id = 11, Name = "Historical" });
            modelBuilder.Entity<Genre>()
                .HasData(new Genre() { Id = 12, Name = "Science fiction" });
            modelBuilder.Entity<Genre>()
                .HasData(new Genre() { Id = 13, Name = "Thriller" });
            base.OnModelCreating(modelBuilder);

        }
        public DbSet<Genre>Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}
