﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OlympicsApp.Models;
using System.Linq;

namespace OlympicsApp.Controllers
{
    public class HomeController : Controller
    {
        private CountryContext context;
        public HomeController(CountryContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index(string activeGame = "all", string activeSport = "all")
        {
            var session = new CountrySession(HttpContext.Session);
            session.SetActiveGame(activeGame);
            session.SetActiveSport(activeSport);

            var model = new OlympicsListViewModel
            {
                ActiveGame = activeGame,
                ActiveSport = activeSport,
                Games = context.Games.ToList(),
                Sports = context.Sports.ToList()
            };
            IQueryable<Country> query = context.Countries;
            if (activeGame != "all")
                query = query.Where(t => t.Game.GameID.ToLower() == activeGame.ToLower());
            if (activeSport != "all")
                query = query.Where(t => t.Sport.SportID.ToLower() == activeSport.ToLower());
            model.Countries = query.ToList();
            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Details(OlympicsViewModel model)
        {
            TempData["ActiveGame"] = model.ActiveGame;
            TempData["ActiveSport"] = model.ActiveSport;
            return RedirectToAction("Details", new { ID = model.Country.CountryID });
        }
        [HttpGet]
        public ViewResult Details(string id)
        {
            var session = new CountrySession(HttpContext.Session);
            var model = new OlympicsViewModel
            {
                Country = context.Countries
                    .Include(t => t.Game)
                    .Include(t => t.Sport)
                    .FirstOrDefault(t => t.CountryID == id),
                ActiveGame = session.GetActiveGame(),
                ActiveSport = session.GetActiveSport()
            };
            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Add(OlympicsViewModel model)
        {
            model.Country = context.Countries   
                .Include(t => t.Game)
                .Include(t => t.Sport)
                .Where(t => t.CountryID == model.Country.CountryID)
                .FirstOrDefault();

            var session = new CountrySession(HttpContext.Session); 
            var countries = session.GetMyCountries();
            countries.Add(model.Country);
            session.SetMyCountries(countries);

            TempData["message"] = $"{model.Country.Name} added to your favorites";  

            return RedirectToAction("Index",    
                new
                {
                    ActiveGame = session.GetActiveGame(),
                    ActiveSport = session.GetActiveSport()
                });
        }
    }
}