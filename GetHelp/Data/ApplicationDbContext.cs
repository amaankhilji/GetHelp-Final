using GetHelp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace GetHelp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Problem> Problem { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            {
                base.OnModelCreating(modelBuilder);

                modelBuilder.Entity<Problem>().HasData(
                    new Problem { Id = 1, Name = "rotten oranges", Link = "google.com", Notes = "abc" ,Level=Level.Easy},
                    new Problem { Id = 2, Name = "2sum", Link = "google.com", Notes = "abc", Level = Level.Medium }
                   
                    );
            }
        }
    }
}
