using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WorldGeography.DAL;
using WorldGeography.Models;
using WorldGeography.Tests.DAL;

namespace WorldGeography.Tests
{
    [TestClass]
    public class CountrySQLDALTests : WorldDAOTests
    {
        [TestMethod]
        public void GetCountriesTest_Should_ReturnAllCountries()
        {
            // Arrange
            // Act
            // Assert
        }

        public void GetCountriesByContinent_Should_ReturnCorrectNumberOfCountries(string continent, int expectedCount)
        {
            // Arrange
            // Act
            // Assert
        }
    }
}
