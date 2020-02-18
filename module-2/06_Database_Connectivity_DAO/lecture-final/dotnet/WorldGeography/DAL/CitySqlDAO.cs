using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldGeography.Models;

namespace WorldGeography.DAL
{
    public class CitySqlDAO : ICityDAO
    {
        private string connectionString;

        /// <summary>
        /// Creates a new sql-based city dao.
        /// </summary>
        /// <param name="databaseconnectionString"></param>
        public CitySqlDAO(string databaseconnectionString)
        {
            connectionString = databaseconnectionString;
        }

        public void AddCity(City city)
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(connectionString))
                {

                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO city (name, countrycode, district, population) VALUES (@name, @countryCode, @district, @population);", conn);
                    cmd.Parameters.AddWithValue("@name", city.Name);
                    cmd.Parameters.AddWithValue("@countryCode", city.CountryCode);
                    cmd.Parameters.AddWithValue("@district",city.District);
                    cmd.Parameters.AddWithValue("@population", city.Population);

                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("SELECT MAX(id) from city", conn);
                    //cmd.Connection = conn;
                    int id = Convert.ToInt32(cmd.ExecuteScalar());


                }
            }

            catch (Exception ex)
            {
                ex = ex;
                throw;
            }

  

    }

        public IList<City> GetCitiesByCountryCode(string countryCode)
        {

            List<City> cities = new List<City>();

            try
            {

                using(SqlConnection conn = new SqlConnection(connectionString))
                {

                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM city WHERE countrycode = @countryCode ORDER BY population ASC", conn);
                    cmd.Parameters.AddWithValue("@countryCode", countryCode);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        City city = new City();
                        city.CityId = Convert.ToInt32(reader["id"]);
                        city.Name = Convert.ToString(reader["name"]);
                        city.CountryCode = Convert.ToString(reader["countrycode"]);
                        city.District = Convert.ToString(reader["district"]);
                        city.Population = Convert.ToInt32(reader["population"]);

                        cities.Add(city);

                    }

                }
            }
            catch (Exception)
            {

                throw;
            }

            return cities;
        }

    }
}
