using CountryStateManager.BussinessLayer.Interface;
using CountryStateManager.BussinessLayer.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CountryStateManager.DataAccessLayer.Repository
{
    public class CountryRepository : ICountryRepository
    {
        public int Create(Country country)
        {
            string connString = "Server=localhost;Database=CountryStateManager;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("CreateCountry", conn);
            cmd.Parameters.AddWithValue("@Name", country.Name);
            cmd.Parameters.AddWithValue("@Description", country.Description);
            cmd.Parameters.AddWithValue("@CreatedBy", country.CreatedBy);
            cmd.Parameters.AddWithValue("@UpdatedBy", country.CreatedBy);
            cmd.Parameters.AddWithValue("@IsActive", country.IsActive ? true : false);
            cmd.CommandType = CommandType.StoredProcedure;

            var result = cmd.ExecuteNonQuery();

            conn.Close();

            return result;
        }

        public int Delete(int id)
        {
            string connString = "Server=localhost;Database=CountryStateManager;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("DeleteCountry", conn);
            cmd.Parameters.AddWithValue("@CountryId", id);
            cmd.CommandType = CommandType.StoredProcedure;

            var result = cmd.ExecuteNonQuery();

            conn.Close();

            return result;
        }

        public Country GetById(int id)
        {
            string connString = "Server=localhost;Database=CountryStateManager;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("GetCountryById", conn);
            cmd.Parameters.AddWithValue("@CountryId", id);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            var country = new Country();
            while (sqlDataReader.Read())
            {
                country.CountryId = Convert.ToInt32(sqlDataReader["CountryId"]);
                country.Name = Convert.ToString(sqlDataReader["Name"]);
                country.Description = Convert.ToString(sqlDataReader["Description"]);
                country.CreatedOn = Convert.ToDateTime(sqlDataReader["CreatedOn"]);
                country.CreatedBy = Convert.ToInt32(sqlDataReader["CreatedBy"]);
                country.UpdatedOn = Convert.ToDateTime(sqlDataReader["UpdatedOn"]);
                country.UpdatedBy = Convert.ToInt32(sqlDataReader["UpdatedBy"]);
                country.IsActive = Convert.ToInt32(sqlDataReader["IsActive"]) == 0 ? false : true;
            }
            if(country.CountryId == 0)
            {
                return null;
            }

            conn.Close();

            return country;
        }

        public List<Country> List()
        {
            string connString = "Server=localhost;Database=CountryStateManager;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("GetCountries", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            var list = new List<Country>();
            while (sqlDataReader.Read())
            {
                Country country = new Country();
                country.CountryId = Convert.ToInt32(sqlDataReader["CountryId"]);
                country.Name = Convert.ToString(sqlDataReader["Name"]);
                country.Description = Convert.ToString(sqlDataReader["Description"]);
                country.CreatedOn = Convert.ToDateTime(sqlDataReader["CreatedOn"]);
                country.CreatedBy = Convert.ToInt32(sqlDataReader["CreatedBy"]);
                country.UpdatedOn = Convert.ToDateTime(sqlDataReader["UpdatedOn"]);
                country.UpdatedBy = Convert.ToInt32(sqlDataReader["UpdatedBy"]);
                country.IsActive = Convert.ToInt32(sqlDataReader["IsActive"]) == 0 ? false : true;

                list.Add(country);
            }

            if(list.Count == 0)
            {
                return null;
            }
            conn.Close();

            return list;
        }

        public int Update(Country country)
        {
            string connString = "Server=localhost;Database=CountryStateManager;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("UpdateCountry", conn);
            cmd.Parameters.AddWithValue("@CountryId", country.CountryId);
            cmd.Parameters.AddWithValue("@Name", country.Name);
            cmd.Parameters.AddWithValue("@Description", country.Description);
            cmd.Parameters.AddWithValue("@IsActive", country.IsActive);
            //cmd.Parameters.AddWithValue("@CreatedOn", country.CreatedOn);
            //cmd.Parameters.AddWithValue("@CreatedBy", country.CreatedBy);
            cmd.Parameters.AddWithValue("@UpdatedBy", country.UpdatedBy);

            cmd.CommandType = CommandType.StoredProcedure;
            
            var result = cmd.ExecuteNonQuery();

            conn.Close();

            return result;
        }

        public int ActivateCountry(int id, bool flag)
        {
            string connString = "Server=localhost;Database=CountryStateManager;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("UpdateCountryActiveStatus", conn);

            cmd.Parameters.AddWithValue("@CountryId", id);
            cmd.Parameters.AddWithValue("@IsActive", flag);

            cmd.CommandType = CommandType.StoredProcedure;

            var result = cmd.ExecuteNonQuery();

            conn.Close();

            return result;
        }
    }
}
