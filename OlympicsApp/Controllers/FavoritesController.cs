using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using OlympicsApp.Models;
using Newtonsoft.Json;

namespace OlympicsApp.Controllers
{
	public class FavoritesController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			var session = new CountrySession(HttpContext.Session);
			var model = new OlympicsListViewModel
			{
				ActiveGame = session.GetActiveGame(),
				ActiveSport = session.GetActiveSport(),
				Countries = session.GetMyCountries()
			};

			return View(model);
		}


		[HttpPost]
		public RedirectToActionResult Delete()
		{
			var session = new CountrySession(HttpContext.Session);
			var cookies = new OlympicsCookies(Response.Cookies);

			session.RemoveMyCountries();
			cookies.RemoveMyCountryIds();

			TempData["message"] = "Favorite countries were cleared";

			return RedirectToAction("Index", "Home",
				new
				{
					ActiveGame = session.GetActiveGame(),
					ActiveSport = session.GetActiveSport()
				});
		}
	}
}