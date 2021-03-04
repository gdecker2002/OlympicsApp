﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OlympicsApp.Models;

namespace OlympicsApp.Migrations
{
    [DbContext(typeof(CountryContext))]
    partial class CountryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OlympicsApp.Models.Country", b =>
                {
                    b.Property<string>("CountryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FlagImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GameID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SportID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CountryID");

                    b.HasIndex("GameID");

                    b.HasIndex("SportID");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryID = "CA",
                            FlagImage = "CA.png",
                            GameID = "winter olympics",
                            Name = "Canada",
                            SportID = "curling"
                        },
                        new
                        {
                            CountryID = "SW",
                            FlagImage = "SW.png",
                            GameID = "winter olympics",
                            Name = "Sweden",
                            SportID = "curling"
                        },
                        new
                        {
                            CountryID = "GB",
                            FlagImage = "GB.png",
                            GameID = "winter olympics",
                            Name = "Great Britain",
                            SportID = "curling"
                        },
                        new
                        {
                            CountryID = "JA",
                            FlagImage = "JA.png",
                            GameID = "winter olympics",
                            Name = "Jamaica",
                            SportID = "bobsleigh"
                        },
                        new
                        {
                            CountryID = "IL",
                            FlagImage = "IL.png",
                            GameID = "winter olympics",
                            Name = "Italy",
                            SportID = "bobsleigh"
                        },
                        new
                        {
                            CountryID = "JP",
                            FlagImage = "JP.png",
                            GameID = "winter olympics",
                            Name = "Japan",
                            SportID = "bobsleigh"
                        },
                        new
                        {
                            CountryID = "GA",
                            FlagImage = "GA.png",
                            GameID = "summer olympics",
                            Name = "Germany",
                            SportID = "diving"
                        },
                        new
                        {
                            CountryID = "CN",
                            FlagImage = "CN.png",
                            GameID = "summer olympics",
                            Name = "China",
                            SportID = "diving"
                        },
                        new
                        {
                            CountryID = "MX",
                            FlagImage = "MX.png",
                            GameID = "summer olympics",
                            Name = "Mexico",
                            SportID = "diving"
                        },
                        new
                        {
                            CountryID = "BR",
                            FlagImage = "BR.png",
                            GameID = "summer olympics",
                            Name = "Brazil",
                            SportID = "road cycling"
                        },
                        new
                        {
                            CountryID = "NL",
                            FlagImage = "NL.png",
                            GameID = "summer olympics",
                            Name = "Netherlands",
                            SportID = "road cycling"
                        },
                        new
                        {
                            CountryID = "US",
                            FlagImage = "US.png",
                            GameID = "summer olympics",
                            Name = "United States",
                            SportID = "road cycling"
                        },
                        new
                        {
                            CountryID = "TH",
                            FlagImage = "TH.png",
                            GameID = "paralympics",
                            Name = "Thailand",
                            SportID = "archery"
                        },
                        new
                        {
                            CountryID = "UY",
                            FlagImage = "UY.png",
                            GameID = "paralympics",
                            Name = "Uruguay",
                            SportID = "archery"
                        },
                        new
                        {
                            CountryID = "UA",
                            FlagImage = "UA.png",
                            GameID = "paralympics",
                            Name = "Ukraine",
                            SportID = "archery"
                        },
                        new
                        {
                            CountryID = "AT",
                            FlagImage = "AT.png",
                            GameID = "paralympics",
                            Name = "Austria",
                            SportID = "canoe sprint"
                        },
                        new
                        {
                            CountryID = "PK",
                            FlagImage = "PK.png",
                            GameID = "paralympics",
                            Name = "Pakistan",
                            SportID = "canoe sprint"
                        },
                        new
                        {
                            CountryID = "ZI",
                            FlagImage = "ZI.png",
                            GameID = "paralympics",
                            Name = "Zimbabwe",
                            SportID = "canoe sprint"
                        },
                        new
                        {
                            CountryID = "FR",
                            FlagImage = "FR.png",
                            GameID = "youth olympic games",
                            Name = "France",
                            SportID = "break dancing"
                        },
                        new
                        {
                            CountryID = "CY",
                            FlagImage = "CY.png",
                            GameID = "youth olympic games",
                            Name = "Cyprus",
                            SportID = "break dancing"
                        },
                        new
                        {
                            CountryID = "RU",
                            FlagImage = "RU.png",
                            GameID = "youth olympic games",
                            Name = "Russia",
                            SportID = "break dancing"
                        },
                        new
                        {
                            CountryID = "FI",
                            FlagImage = "FI.png",
                            GameID = "youth olympic games",
                            Name = "Finland",
                            SportID = "skateboarding"
                        },
                        new
                        {
                            CountryID = "SK",
                            FlagImage = "SK.png",
                            GameID = "youth olympic games",
                            Name = "Slovakia",
                            SportID = "skateboarding"
                        },
                        new
                        {
                            CountryID = "PT",
                            FlagImage = "PT.png",
                            GameID = "youth olympic games",
                            Name = "Portugal",
                            SportID = "skateboarding"
                        });
                });

            modelBuilder.Entity("OlympicsApp.Models.Game", b =>
                {
                    b.Property<string>("GameID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameID");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            GameID = "winter olympics",
                            Name = "Winter Olympics"
                        },
                        new
                        {
                            GameID = "summer olympics",
                            Name = "Summer Olympics"
                        },
                        new
                        {
                            GameID = "paralympics",
                            Name = "Paralympics"
                        },
                        new
                        {
                            GameID = "youth olympic games",
                            Name = "Youth Olympic Games"
                        });
                });

            modelBuilder.Entity("OlympicsApp.Models.Sport", b =>
                {
                    b.Property<string>("SportID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SportID");

                    b.ToTable("Sports");

                    b.HasData(
                        new
                        {
                            SportID = "curling",
                            Name = "Curling/Indoor"
                        },
                        new
                        {
                            SportID = "bobsleigh",
                            Name = "Bobsleigh/Outdoor"
                        },
                        new
                        {
                            SportID = "diving",
                            Name = "Diving/Indoor"
                        },
                        new
                        {
                            SportID = "road cycling",
                            Name = "Road Cycling/Outdoor"
                        },
                        new
                        {
                            SportID = "archery",
                            Name = "Archery/Indoor"
                        },
                        new
                        {
                            SportID = "canoe sprint",
                            Name = "Canoe Sprint/Outdoor"
                        },
                        new
                        {
                            SportID = "break dancing",
                            Name = "Break Dancing/Indoor"
                        },
                        new
                        {
                            SportID = "skateboarding",
                            Name = "Skateboarding/Outdoor"
                        });
                });

            modelBuilder.Entity("OlympicsApp.Models.Country", b =>
                {
                    b.HasOne("OlympicsApp.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameID");

                    b.HasOne("OlympicsApp.Models.Sport", "Sport")
                        .WithMany()
                        .HasForeignKey("SportID");

                    b.Navigation("Game");

                    b.Navigation("Sport");
                });
#pragma warning restore 612, 618
        }
    }
}
