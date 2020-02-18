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
        [TestMethod]
        [DataRow("USA", 1)]
        [DataRow("BLA", 0)]
        public void GetLanguagesTest(string countryCode, int expectedCount)
        {
            // Arrange
            LanguageSqlDAO dao = new LanguageSqlDAO(ConnectionString);

            // Act
            IList <Language> languages = dao.GetLanguages(countryCode);

            // Assert
            Assert.AreEqual(expectedCount, languages.Count);
        }

        [TestMethod]
        public void AddLanguage()
        {
            // Arrange
            LanguageSqlDAO languageDAO = new LanguageSqlDAO(ConnectionString);
            int initialRowCount = GetRowCount("countrylanguage");
            Language lang = new Language();
            lang.CountryCode = "USA";
            lang.Name = "English";
            lang.IsOfficial = true;
            lang.Percentage = 50;

            // Act

            languageDAO.AddNewLanguage(lang);

            // Assert
            int finalRowCount = GetRowCount("countrylanguage");
            Assert.AreEqual(initialRowCount + 1, finalRowCount);

        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void AddLanguage_FailsBecauseLanguageExists()
        {
            // Arrange
            LanguageSqlDAO languageDAO = new LanguageSqlDAO(ConnectionString);
            int initialRowCount = GetRowCount("countrylanguage");
            Language lang = new Language();
            lang.CountryCode = "USA";
            lang.Name = "Test Language";
            lang.IsOfficial = true;
            lang.Percentage = 50;

            // Act

            languageDAO.AddNewLanguage(lang);
            // Assert
            // should not work

        }

        [TestMethod]
        public void RemoveLanguage()
        {
            // Arrange
            LanguageSqlDAO languageDAO = new LanguageSqlDAO(ConnectionString);
            int initialRowCount = GetRowCount("countrylanguage");
            Language lang = new Language();
            lang.CountryCode = "USA";
            lang.Name = "Test Language";
            lang.IsOfficial = true;
            lang.Percentage = 50;

            // Act

            languageDAO.RemoveLanguage(lang);
            int finalRowCount = GetRowCount("countrylanguage");
            // Assert
            Assert.AreEqual(initialRowCount - 1, finalRowCount);
        }

    }
}
