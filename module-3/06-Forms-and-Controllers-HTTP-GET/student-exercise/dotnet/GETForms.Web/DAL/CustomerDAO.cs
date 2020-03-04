using GETForms.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace GETForms.Web.DAL
{
    public class CustomerDAO : ICustomerDAO
    {
        private string connectionString;

        public CustomerDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Searches for customers.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="sortBy"></param>
        /// <returns></returns>
        public IList<Customer> SearchForCustomers(string search, string sortBy)
        {
            IList<Customer> customers = new List<Customer>();

            string sqlCommandText = "SELECT first_name, last_name, email, COALESCE(active,0) AS active FROM customer WHERE (first_name + ' ' + last_name) LIKE '%' + @name + '%' ORDER BY " + sortBy;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand sqlCommand = new SqlCommand(sqlCommandText, conn);

                sqlCommand.Parameters.AddWithValue("@name", search);
                

                SqlDataReader dr = sqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    Customer customer = new Customer();

                    customer.FirstName = (string)dr["first_name"];
                    customer.LastName = (string)dr["last_name"];
                    customer.IsActive = Convert.ToBoolean(dr["active"]);
                    customer.Email = (string)dr["email"];

                    customers.Add(customer);
                }
            }
                return customers;
        }
    }
}
