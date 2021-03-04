using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OlympicsApp.Models
{
    public class CountryContext : DbContext
    {
        public CountryContext(DbContextOptions<CountryContext> options)
            : base(options) { }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Sport> Sports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Game>().HasData(
                new Game { GameID = "winter olympics", Name = "Winter Olympics" },
                new Game { GameID = "summer olympics", Name = "Summer Olympics" },
                new Game { GameID = "paralympics", Name = "Paralympics" },
                new Game { GameID = "youth olympic games", Name = "Youth Olympic Games" }
                );

            modelBuilder.Entity<Sport>().HasData(
                new Sport { SportID = "curling", Name = "Curling/Indoor" },
                new Sport { SportID = "bobsleigh", Name = "Bobsleigh/Outdoor" },
                new Sport { SportID = "diving", Name = "Diving/Indoor" },
                new Sport { SportID = "road cycling", Name = "Road Cycling/Outdoor" },
                new Sport { SportID = "archery", Name = "Archery/Indoor" },
                new Sport { SportID = "canoe sprint", Name = "Canoe Sprint/Outdoor" },
                new Sport { SportID = "break dancing", Name = "Break Dancing/Indoor" },
                new Sport { SportID = "skateboarding", Name = "Skateboarding/Outdoor" }
                );

            modelBuilder.Entity<Country>().HasData(
                    new { CountryID = "CA", Name = "Canada", SportID = "curling", GameID = "winter olympics", FlagImage = "CA.png" },
                    new { CountryID = "SW", Name = "Sweden", SportID = "curling", GameID = "winter olympics", FlagImage = "SE.png" },
                    new { CountryID = "GB", Name = "Great Britain", SportID = "curling", GameID = "winter olympics", FlagImage = "GB.png" },
                    new { CountryID = "JA", Name = "Jamaica", SportID = "bobsleigh", GameID = "winter olympics", FlagImage = "JM.png" },
                    new { CountryID = "IL", Name = "Italy", SportID = "bobsleigh", GameID = "winter olympics", FlagImage = "IT.png" },
                    new { CountryID = "JP", Name = "Japan", SportID = "bobsleigh", GameID = "winter olympics", FlagImage = "JP.png" },
                    new { CountryID = "GA", Name = "Germany", SportID = "diving", GameID = "summer olympics", FlagImage = "GA.png" },
                    new { CountryID = "CN", Name = "China", SportID = "diving", GameID = "summer olympics", FlagImage = "CN.png" },
                    new { CountryID = "MX", Name = "Mexico", SportID = "diving", GameID = "summer olympics", FlagImage = "MX.png" },
                    new { CountryID = "BR", Name = "Brazil", SportID = "road cycling", GameID = "summer olympics", FlagImage = "BR.png" },
                    new { CountryID = "NL", Name = "Netherlands", SportID = "road cycling", GameID = "summer olympics", FlagImage = "NL.png" },
                    new { CountryID = "US", Name = "United States", SportID = "road cycling", GameID = "summer olympics", FlagImage = "US.png" },
                    new { CountryID = "TH", Name = "Thailand", SportID = "archery", GameID = "paralympics", FlagImage = "TH.png" },
                    new { CountryID = "UY", Name = "Uruguay", SportID = "archery", GameID = "paralympics", FlagImage = "UY.png" },
                    new { CountryID = "UA", Name = "Ukraine", SportID = "archery", GameID = "paralympics", FlagImage = "UA.png" },
                    new { CountryID = "AT", Name = "Austria", SportID = "canoe sprint", GameID = "paralympics", FlagImage = "AT.png" },
                    new { CountryID = "PK", Name = "Pakistan", SportID = "canoe sprint", GameID = "paralympics", FlagImage = "PK.png" },
                    new { CountryID = "ZI", Name = "Zimbabwe", SportID = "canoe sprint", GameID = "paralympics", FlagImage = "ZW.png" },
                    new { CountryID = "FR", Name = "France", SportID = "break dancing", GameID = "youth olympic games", FlagImage = "FR.png" },
                    new { CountryID = "CY", Name = "Cyprus", SportID = "break dancing", GameID = "youth olympic games", FlagImage = "CY.png" },
                    new { CountryID = "RU", Name = "Russia", SportID = "break dancing", GameID = "youth olympic games", FlagImage = "RU.png" },
                    new { CountryID = "FI", Name = "Finland", SportID = "skateboarding", GameID = "youth olympic games", FlagImage = "FI.png" },
                    new { CountryID = "SK", Name = "Slovakia", SportID = "skateboarding", GameID = "youth olympic games", FlagImage = "SK.png" },
                    new { CountryID = "PT", Name = "Portugal", SportID = "skateboarding", GameID = "youth olympic games", FlagImage = "PT.png" }
                );
        }
    }
}
