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


        public void GetCitiesByCountryCode_Should_ReturnRightNumberOfCities(string countryCode, int expectedCityCount)
        {
            // Arrange
            // Act
            // Assert
        }

        [TestMethod]
        public void AddCity_Should_IncreaseCountBy1()
        {
            // Arrange
            // Act
            // Assert
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void AddCity_Should_Fail_IfCountryDoesNotExist()
        {
            // Arrange
            // Act
            // Assert
        }
    }
}
