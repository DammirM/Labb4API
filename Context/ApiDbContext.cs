using Labb4API.Models;
using Microsoft.EntityFrameworkCore;

namespace Labb4API.Context
{
    public class ApiDbContext : DbContext
    {

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }

        public DbSet<Interest> Interests { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Link>()
            .HasKey(l => new { l.PersonId, l.InterestId });

            modelBuilder.Entity<Link>()
                .HasOne(l => l.Person)
                .WithMany(p => p.Links)
                .HasForeignKey(l => l.PersonId);

            modelBuilder.Entity<Link>()
                .HasOne(l => l.Interest)
                .WithMany(i => i.Links)
                .HasForeignKey(l => l.InterestId);

            modelBuilder.Entity<Person>().HasData(
            new Person { ID = 1, FirstName = "Damir", Phone = "0762445962" },
            new Person { ID = 2, FirstName = "Daniel", Phone = "653242784295" },
            new Person { ID = 3, FirstName = "Alvin", Phone = "3275839145734289" },
            new Person { ID = 4, FirstName = "Charlie", Phone = "3473895374896327" },
            new Person { ID = 5, FirstName = "Petter", Phone = "7589324653248967" }
                 );
            modelBuilder.Entity<Link>().HasData(
                new Link { ID = 1, Url = "https://www.google.com", PersonId = 1, InterestId = 2 },
                new Link { ID = 2, Url = "https://www.github.com", PersonId = 2, InterestId = 3 },
                new Link { ID = 3, Url = "https://www.stackoverflow.com", PersonId = 3, InterestId = 1 },
                new Link { ID = 4, Url = "https://www.microsoft.com", PersonId = 4, InterestId = 5 },
                new Link { ID = 5, Url = "https://www.amazon.com", PersonId = 5, InterestId = 4 }
                     );
            modelBuilder.Entity<Interest>().HasData(
                new Interest { ID = 1, Title = "Programming", Description = "Creating software applications" },
                new Interest { ID = 2, Title = "Music", Description = "Playing and listening to music" },
                new Interest { ID = 3, Title = "Sports", Description = "Playing and watching sports" },
                new Interest { ID = 4, Title = "Reading", Description = "Reading books and articles" },
                new Interest { ID = 5, Title = "Gaming", Description = "Playing video games" }

            );
        }
    }
}
