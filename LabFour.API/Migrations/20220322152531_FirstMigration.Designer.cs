﻿// <auto-generated />
using LabFour.API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LabFour.API.Migrations
{
    [DbContext(typeof(LabContext))]
    [Migration("20220322152531_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LabFour.Models.Interest", b =>
                {
                    b.Property<int>("InterestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InterestId");

                    b.HasIndex("PersonId");

                    b.ToTable("Interests");

                    b.HasData(
                        new
                        {
                            InterestId = 1,
                            Description = "Multiplayer online battle arena",
                            PersonId = 1,
                            Title = "Defense Of The Ancients 2"
                        },
                        new
                        {
                            InterestId = 2,
                            Description = "Action Adventure",
                            PersonId = 2,
                            Title = "God of War"
                        },
                        new
                        {
                            InterestId = 3,
                            Description = "Open-World Action RPG",
                            PersonId = 3,
                            Title = "Elden Ring"
                        },
                        new
                        {
                            InterestId = 4,
                            Description = "Multiplayer online battle arena",
                            PersonId = 4,
                            Title = "League of Legends"
                        });
                });

            modelBuilder.Entity("LabFour.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonId");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            PersonId = 1,
                            Name = "Erik",
                            PhoneNumber = "0703232323"
                        },
                        new
                        {
                            PersonId = 2,
                            Name = "Erik",
                            PhoneNumber = "0734343434"
                        },
                        new
                        {
                            PersonId = 3,
                            Name = "Lucas",
                            PhoneNumber = "0700654321"
                        },
                        new
                        {
                            PersonId = 4,
                            Name = "Viktor",
                            PhoneNumber = "0707333444"
                        });
                });

            modelBuilder.Entity("LabFour.Models.WebSite", b =>
                {
                    b.Property<int>("WebSiteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InterestId")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WebSiteId");

                    b.HasIndex("InterestId");

                    b.ToTable("WebSites");

                    b.HasData(
                        new
                        {
                            WebSiteId = 1,
                            Description = "Dota 2 Website",
                            InterestId = 1,
                            Link = "https://www.dota2.com/home"
                        },
                        new
                        {
                            WebSiteId = 2,
                            Description = "Wikipedia link",
                            InterestId = 2,
                            Link = "https://en.wikipedia.org/wiki/God_of_War_(2018_video_game)"
                        },
                        new
                        {
                            WebSiteId = 3,
                            Description = "Wikipedia link",
                            InterestId = 3,
                            Link = "https://en.wikipedia.org/wiki/Elden_Ring"
                        },
                        new
                        {
                            WebSiteId = 4,
                            Description = "League of Legends Website",
                            InterestId = 4,
                            Link = "https://www.leagueoflegends.com/en-gb/"
                        });
                });

            modelBuilder.Entity("LabFour.Models.Interest", b =>
                {
                    b.HasOne("LabFour.Models.Person", "Person")
                        .WithMany("Interests")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LabFour.Models.WebSite", b =>
                {
                    b.HasOne("LabFour.Models.Interest", "Interest")
                        .WithMany("WebSites")
                        .HasForeignKey("InterestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
