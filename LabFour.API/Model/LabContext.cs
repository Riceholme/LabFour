using LabFour.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabFour.API.Model
{
    public class LabContext : DbContext
    {
        public LabContext(DbContextOptions<LabContext> options) : base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<WebSite> WebSites { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonInterest>()
                .HasKey(pi => new { pi.PersonId, pi.InterestId });
            modelBuilder.Entity<PersonInterest>()
                .HasOne(pi => pi.Person)
                .WithMany(pi => pi.Interests)
                .HasForeignKey(pi => pi.PersonId);
            modelBuilder.Entity<PersonInterest>()
                .HasOne(pi => pi.Interest)
                .WithMany(pi => pi.Persons)
                .HasForeignKey(pi => pi.InterestId);

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Person>().
                HasData(new Person
                {
                    PersonId = 1,
                    Name = "Erik",
                    PhoneNumber = "0703232323",
                    //Interests =
                });

        }
    }
}
