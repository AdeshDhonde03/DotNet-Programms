using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADOPrac.BusinessLogicLayer.IRepository;
using ADOPrac.BusinessLogicLayer.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ADOPrac.DataAccessLayer.Repository
{
    public class CountryRepository : ICountryRepository
    {
        public int ChangeIsActive(int id , int flag)
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=ADOPracDb;Trusted_connection=True;TrustServerCertificate=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("ChangeIsActive", connection);
            command.Parameters.AddWithValue("@CountryId", id);
            command.Parameters.AddWithValue("@isActive", flag);
            command.CommandType = CommandType.StoredProcedure;
            var result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        public int Create(Country country)
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=ADOPracDb;Trusted_connection=True;TrustServerCertificate=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("CreateCountry" , connection);
            command.Parameters.AddWithValue("@CountryName", country.CountryName);
            command.Parameters.AddWithValue("@CountryDescription", country.CountryDescription);
            command.Parameters.AddWithValue("@CreatedOn", DateTime.Now);
            command.Parameters.AddWithValue("@CreatedBy", 1);
            command.Parameters.AddWithValue("@UpdatedBy", 1);
            command.Parameters.AddWithValue("@UpdatedOn", DateTime.Now);
            command.Parameters.AddWithValue("@isActive", 1);
            command.CommandType = CommandType.StoredProcedure;
            var result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        public int Delete(int id)
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=ADOPracDb;Trusted_connection=True;TrustServerCertificate=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("DeleteCountry", connection);
            command.Parameters.AddWithValue("@CountryId", id);
            command.CommandType = CommandType.StoredProcedure;
            var result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        public List<Country> GetCountriesList()
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=ADOPracDb;Trusted_connection=True;TrustServerCertificate=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("GetCountriesList", connection);
            SqlDataReader reader = command.ExecuteReader();
            var countryList = new List<Country>();

            while (reader.Read())
            {
                Country country = new Country();

                country.CountryId = Convert.ToInt32(reader["CountryId"]);
                country.CountryName = Convert.ToString(reader["CountryName"]);
                country.CountryDescription = Convert.ToString(reader["CountryDescription"]);
                country.isActive = Convert.ToInt32(reader["isActive"]);

                countryList.Add(country);
            }

            return countryList;
        }

        public Country GetCountryById(int id)
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=ADOPracDb;Trusted_connection=True;TrustServerCertificate=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("GetCountryById", connection);
            command.Parameters.AddWithValue("@CountryId", id);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataReader sqlDataReader = command.ExecuteReader();
            Country country = new Country();
            while (sqlDataReader.Read())
            {
                country.CountryId = Convert.ToInt32(sqlDataReader["CountryId"]);
                country.CountryName = Convert.ToString(sqlDataReader["CountryName"]);
                country.CountryDescription = Convert.ToString(sqlDataReader["CountryDescription"]);
            }

            return country;
        }

        public int Update(Country country)
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=ADOPracDb;Trusted_connection=True;TrustServerCertificate=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("UpdateCountry", connection);
            command.Parameters.AddWithValue("@CountryId", country.CountryId);
            command.Parameters.AddWithValue("@CountryName", country.CountryName);
            command.Parameters.AddWithValue("@CountryDescription", country.CountryDescription);
            command.Parameters.AddWithValue("@CreatedOn", DateTime.Now);
            command.Parameters.AddWithValue("@CreatedBy", 1);
            command.Parameters.AddWithValue("@UpdatedBy", 1);
            command.Parameters.AddWithValue("@UpdatedOn", DateTime.Now);
            command.CommandType = CommandType.StoredProcedure;
            var result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }
    }
}
