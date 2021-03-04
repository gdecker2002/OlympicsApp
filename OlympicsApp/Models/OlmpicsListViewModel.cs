﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympicsApp.Models
{
    public class OlympicsListViewModel : OlympicsViewModel
    {
        public List<Country> Countries { get; set; }
        public string ActiveGame { get; set; }
        public string ActiveSport { get; set; }

        private List<Game> games;
        public List<Game> Games
        {
            get => games;
            set
            {
                games = value;
                games.Insert(0,
                    new Game { GameID = "all", Name = "All" });
            }
        }

        private List<Sport> sports;
        public List<Sport> Sports
        {
            get => sports;
            set
            {
                sports = value;
                sports.Insert(0,
                    new Sport { SportID = "all", Name = "All" });
            }
        }

        public string CheckActiveGame(string g) => g.ToLower() == ActiveGame.ToLower() ? "active" : "";
        public string CheckActiveSport(string s) => s.ToLower() == ActiveSport.ToLower() ? "active" : "";
    }
}