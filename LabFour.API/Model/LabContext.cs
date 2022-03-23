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
            //modelBuilder.Entity<PersonInterest>()
            //    .HasKey(pi => new { pi.PersonId, pi.InterestId });
            //modelBuilder.Entity<PersonInterest>()
            //    .HasOne(pi => pi.Person)
            //    .WithMany(pi => pi.Interests)
            //    .HasForeignKey(pi => pi.PersonId);
            //modelBuilder.Entity<PersonInterest>()
            //    .HasOne(pi => pi.Interest)
            //    .WithMany(pi => pi.Persons)
            //    .HasForeignKey(pi => pi.InterestId);

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Person>().
                HasData(new Person
                {
                    PersonId = 1,
                    Name = "Erik",
                    PhoneNumber = "0703232323"
                    
                });
            modelBuilder.Entity<Person>().
                HasData(new Person
                {
                    PersonId = 2,
                    Name = "Erik",
                    PhoneNumber = "0734343434"
                });
            modelBuilder.Entity<Person>().
                HasData(new Person
                {
                    PersonId = 3,
                    Name = "Lucas",
                    PhoneNumber = "0700654321"
                });
            modelBuilder.Entity<Person>().
                HasData(new Person
                {
                    PersonId = 4,
                    Name = "Viktor",
                    PhoneNumber = "0707333444"
                });
            modelBuilder.Entity<Interest>().
                HasData(new Interest
                {
                    InterestId = 1,
                    Title = "Defense Of The Ancients 2",
                    Description = "Multiplayer online battle arena",
                    PersonId = 1

                });
            modelBuilder.Entity<Interest>().
                HasData(new Interest
                {
                    InterestId = 2,
                    Title = "God of War",
                    Description = "Action Adventure",
                    PersonId = 2

                });
            modelBuilder.Entity<Interest>().
                HasData(new Interest
                {
                    InterestId = 3,
                    Title = "Elden Ring",
                    Description = "Open-World Action RPG",
                    PersonId = 3
                });
            modelBuilder.Entity<Interest>().
                HasData(new Interest
                {
                    InterestId = 4,
                    Title = "League of Legends",
                    Description = "Multiplayer online battle arena",
                    PersonId = 4
                });
            modelBuilder.Entity<WebSite>().
                HasData(new WebSite
                {
                    WebSiteId = 1,
                    Link = "https://www.dota2.com/home",
                    Description = "Dota 2 Website",
                    InterestId = 1
                });
            modelBuilder.Entity<WebSite>().
                HasData(new WebSite
                {
                    WebSiteId = 2,
                    Link = "https://en.wikipedia.org/wiki/God_of_War_(2018_video_game)",
                    Description = "Wikipedia link",
                    InterestId = 2
                });
            modelBuilder.Entity<WebSite>().
                HasData(new WebSite
                {
                    WebSiteId = 3,
                    Link = "https://en.wikipedia.org/wiki/Elden_Ring",
                    Description = "Wikipedia link",
                    InterestId = 3
                });
            modelBuilder.Entity<WebSite>().
                HasData(new WebSite
                {
                    WebSiteId = 4,
                    Link = "https://www.leagueoflegends.com/en-gb/",
                    Description = "League of Legends Website",
                    InterestId = 4
                });


        }
    }
}
