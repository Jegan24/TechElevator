using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Lecture.Web.Models;

namespace Lecture.Web.DAL
{
    public class CountrySqlDAO : ICountryDAO
    {
        private string connectionString;
        public CountrySqlDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        //4. Create DAL method to get all countries
        public IList<Country> GetCountries()
        {
            IList<Country> countries = new List<Country>();

            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM country;", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Country country = new Country()
                        {
                            Code = Convert.ToString(reader["code"]),
                            Name = Convert.ToString(reader["name"]),
                            Continent = Convert.ToString(reader["continent"]),
                            HeadOfState = Convert.ToString(reader["headofstate"])
                        };
                        countries.Add(country);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return countries;
        }

        //this is number 6 for the CreateCountry
        public void AddCountry(Country country)
        {
          
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT into country([code],[name],[continent],[region]"+
                       ",[surfacearea],[population],[localname],[governmentform],[headofstate],[code2])"+
                       "values(@code,@name,@continent, 'REG', 1, 1, @name, 'Dictatorship', @headOfState, 'abc')", conn);

                    cmd.Parameters.AddWithValue("@name", country.Name);
                    cmd.Parameters.AddWithValue("@continent", country.Continent);
                    cmd.Parameters.AddWithValue("@headOfState", country.HeadOfState);
                    cmd.Parameters.AddWithValue("@code", country.Name.Substring(0,3).ToUpper());
                    cmd.ExecuteNonQuery();

                }
            }
            catch (SqlException ex)
            {
                throw;
            }

       
        }
    }
}
