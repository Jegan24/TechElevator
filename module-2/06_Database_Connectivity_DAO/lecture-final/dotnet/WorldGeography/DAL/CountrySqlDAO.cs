using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WorldGeography.Models;

namespace WorldGeography.DAL
{
    public class CountrySqlDAO : ICountryDAO
    {
        private string connectionString;

        /// <summary>
        /// Creates a sql based country dao.
        /// </summary>
        /// <param name="databaseconnectionString"></param>
        public CountrySqlDAO(string databaseconnectionString)
        {
            connectionString = databaseconnectionString;
        }        

        public IList<Country> GetCountries()
        {
            List<Country> countries = new List<Country>();


            try {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {

                    conn.Open();

  
                    SqlCommand cmd = new SqlCommand("SELECT * FROM country;", conn);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Country ctry = new Country();

                        ctry.Code = Convert.ToString(reader["code"]);
                        ctry.Name = Convert.ToString(reader["name"]);
                        ctry.Continent = Convert.ToString(reader["continent"]);
                        ctry.Region = Convert.ToString(reader["region"]);
                        ctry.SurfaceArea = Convert.ToDouble(reader["surfacearea"]);
                        ctry.Population = Convert.ToInt32(reader["population"]);
                        ctry.GovernmentForm = Convert.ToString(reader["governmentform"]);

                        countries.Add(ctry);
                    }

                }
         
            } catch (SqlException ex)
            {
                Console.WriteLine("Error Getting Countries");
                Console.WriteLine("The error was: " + ex.Message);
            }

     
            return countries;

        }

        public IList<Country> GetCountries(string continent)
        {
            IList<Country> countries = new List<Country>();
            try
            {

                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM country WHERE continent = @continent;", conn);
                    cmd.Parameters.AddWithValue("@continent", continent);

                    
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Country ctry = new Country();

                        ctry.Code = Convert.ToString(reader["code"]);
                        ctry.Name = Convert.ToString(reader["name"]);
                        ctry.Continent = Convert.ToString(reader["continent"]);
                        ctry.Region = Convert.ToString(reader["region"]);
                        ctry.SurfaceArea = Convert.ToDouble(reader["surfacearea"]);
                        ctry.Population = Convert.ToInt32(reader["population"]);
                        ctry.GovernmentForm = Convert.ToString(reader["governmentform"]);

                        countries.Add(ctry);

                    }

                }


            }
            catch (Exception)
            {


                throw;
            }

            return countries;

        }
    }
}
