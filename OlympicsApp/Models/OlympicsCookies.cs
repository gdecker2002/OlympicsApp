using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace OlympicsApp.Models
{
	public class OlympicCookies
	{
		private const string MyCountries = "mycountries";
		private const string Delimiter = "-";

		private IRequestCookieCollection requestCookies { get; set; }
		private IResponseCookies responseCookies { get; set; }

		public OlympicCookies(IRequestCookieCollection cookies)
		{
			requestCookies = cookies;
		}
		public OlympicCookies(IResponseCookies cookies)
		{
			responseCookies = cookies;
		}
		public void SetMyCountryIds(List<Country> mycountries)
		{
			List<string> ids = mycountries.Select(t => t.CountryID).ToList();
			string idString = String.Join(Delimiter, ids);
			CookieOptions options = new CookieOptions
			{
				Expires = DateTime.Now.AddDays(30)
			};
		}
		public string[] GetMyCountryIds()
		{
			string cookie = requestCookies[MyCountries];
			if (string.IsNullOrEmpty(cookie))
			{
				return new string[] { }; //empty string array
			}
			else
			{
				return cookie.Split(Delimiter);
			}
		}

		public void RemoveMyCountryIds()
		{
			responseCookies.Delete(MyCountries);
		}
	}
}
