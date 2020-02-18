using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Data.SqlClient;
using WorldGeography.DAL;
using WorldGeography.Models;
using WorldGeography.Tests.DAL;

namespace WorldGeography.Tests
{
    [TestClass]
    public class LanguageSqlDAOTests : WorldDAOTests
    {

        public void GetLanguagesTest(string countryCode, int expectedCount)
        {
            // Arrange
            // Act
            // Assert
        }

        [TestMethod]
        public void AddLanguage()
        {
            // Arrange
            // Act
            // Assert
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void AddLanguage_FailsBecauseLanguageExists()
        {
            // Arrange
            // Act
            // Assert
        }

        [TestMethod]
        public void RemoveLanguage()
        {
            // Arrange
            // Act
            // Assert

        }

    }
}
