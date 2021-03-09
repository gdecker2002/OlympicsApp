using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
namespace OlympicsApp.Models
{
    public class MySession
    {
        private const string CountriesKey = "countries";

        private ISession session { get; set; }
        public MySession(ISession sess)
        {
            session = sess;
        }
        public List<Country> GetCountries() =>
            session.GetObject<List<Country>>(CountriesKey) ?? new List<Country>();
        public void SetCountries(List<Country> countries) =>
            session.SetObject(CountriesKey, countries);
    }
}
