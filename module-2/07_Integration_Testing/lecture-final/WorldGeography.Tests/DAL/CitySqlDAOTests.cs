using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Data.SqlClient;
using WorldGeography.DAL;
using WorldGeography.Models;
using WorldGeography.Tests.DAL;

namespace WorldGeography.Tests
{
    [TestClass]
    public class CitySQLDALTests : WorldDAOTests
    {

        [DataTestMethod]
        [DataRow("USA", 1)]
        [DataRow("FRA",0)]
        public void GetCitiesByCountryCode_Should_ReturnRightNumberOfCities(string countryCode, int expectedCityCount)
        {
            // Arrange
            CitySqlDAO dao = new CitySqlDAO(ConnectionString);
            // Act
            IList<City> cities = dao.GetCitiesByCountryCode(countryCode);
            // Assert
            Assert.AreEqual(expectedCityCount, cities.Count);
        }

        [TestMethod]
        public void AddCity_Should_IncreaseCountBy1()
        {
            // Arrange
            City city = new City();
            city.CountryCode = "USA";
            city.Name = "Test City";
            city.Population = 123;
            city.District = "who cares";

            CitySqlDAO dao = new CitySqlDAO(ConnectionString);
            int startCount = GetRowCount("city");

            // Act
            dao.AddCity(city);
            int endCount = GetRowCount("city");
            // Assert
            Assert.AreEqual(startCount+1, endCount);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void AddCity_Should_Fail_IfCountryDoesNotExist()
        {
            // Arrange
            City city = new City();
            city.CountryCode = "ZZZ";
            city.Name = "Test City";
            city.Population = 123;
            city.District = "who cares";

            CitySqlDAO dao = new CitySqlDAO(ConnectionString);
            // Act
            dao.AddCity(city);
            // Assert
        }
    }
}
