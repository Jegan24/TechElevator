using Forms.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forms.Web.DAL
{
    public class MockCityDAO : ICityDAO
    {
        void ICityDAO.AddCity(City city)
        {
            throw new NotImplementedException();
        }

        IList<City> ICityDAO.GetCities()
        {
            IList<City> myList= new List<City>();
            City oz = new City();
            oz.CityId = 1;
            oz.CountryCode = "USA";
            oz.District = "Kansas";
            oz.Population = 10;
            oz.Name = "Oz";
            myList.Add(oz);
            City b = new City();
            b.CityId = 1;
            b.CountryCode = "USA";
            b.District = "Florida";
            b.Population = 0;
            b.Name = "Atlantis";
            myList.Add(b);

            return myList;
        }

        IList<City> ICityDAO.GetCities(string countryCode, string district)
        {
            IList<City> myList = new List<City>();
            City oz = new City();
            oz.CityId = 1;
            oz.CountryCode = "USA";
            oz.District = "Kansas";
            oz.Population = 10;
            oz.Name = "Oz";
            myList.Add(oz);
            City b = new City();
            b.CityId = 1;
            b.CountryCode = "USA";
            b.District = "Florida";
            b.Population = 0;
            b.Name = "Atlantis";
            myList.Add(b);

            return myList;
        }

        IList<string> ICityDAO.GetCountryCodes()
        {
            IList<string> myList = new List<string>() { "USA", "GBR", "CHN" };
            return myList;
        }
    }
}
