using Microsoft.EntityFrameworkCore;
using VTLP1J_Prog4.Models;

namespace VTLP1J_Prog4.Repository.Database
{
    public class MovieDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Director> Directors { get; set; }

        public MovieDbContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
            {
                builder
                    .UseLazyLoadingProxies()
                    .UseInMemoryDatabase("movie");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Movie>(movie => movie
                .HasOne(movie => movie.Director)
                .WithMany(director => director.Movies)
                .HasForeignKey(movie => movie.DirectorId)
                .OnDelete(DeleteBehavior.Cascade));

            modelBuilder.Entity<Actor>()
                .HasMany(x => x.Movies)
                .WithMany(x => x.Actors)
                .UsingEntity<Role>(
                    x => x.HasOne(x => x.Movie)
                        .WithMany().HasForeignKey(x => x.MovieId).OnDelete(DeleteBehavior.Cascade),
                    x => x.HasOne(x => x.Actor)
                        .WithMany().HasForeignKey(x => x.ActorId).OnDelete(DeleteBehavior.Cascade));

            modelBuilder.Entity<Role>()
                .HasOne(r => r.Actor)
                .WithMany(actor => actor.Roles)
                .HasForeignKey(r => r.ActorId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Role>()
                .HasOne(r => r.Movie)
                .WithMany(movie => movie.Roles)
                .HasForeignKey(r => r.MovieId)
                .OnDelete(DeleteBehavior.Cascade);


        }




    }
}
