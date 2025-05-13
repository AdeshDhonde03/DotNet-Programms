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
    public class CompanyRepository : ICompanyRepository
    {
        public int Create(Company company)
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=ADOPracDb;Trusted_connection=True;TrustServerCertificate=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("CreateCompany", connection);
            command.Parameters.AddWithValue("@CompanyName", company.CompanyName);
            command.Parameters.AddWithValue("@CompanyAddress", company.CompanyAddress);
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
            SqlCommand command = new SqlCommand("DeleteCompany", connection);
            command.Parameters.AddWithValue("@CompanyId", id);
            command.CommandType = CommandType.StoredProcedure;
            var result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        public Company GetCompanyById(int id)
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=ADOPracDb;Trusted_connection=True;TrustServerCertificate=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("GetCompanyById", connection);
            command.Parameters.AddWithValue("@CompanyId", id);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataReader sqlDataReader = command.ExecuteReader();
            Company company = new Company();

            while (sqlDataReader.Read())
            {
                company.CompanyId = Convert.ToInt32(sqlDataReader["CompanyId"]);
                company.CompanyName = Convert.ToString(sqlDataReader["CompanyName"]);
                company.CompanyAddress = Convert.ToString(sqlDataReader["CompanyAddress"]);
            }

            return company;
        }

        public List<Company> ListAllCompanies()
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=ADOPracDb;Trusted_connection=True;TrustServerCertificate=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("GetCompanyList", connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            var companyList = new List<Company>();

            while (sqlDataReader.Read())
            {
                Company company = new Company();
                company.CompanyId = Convert.ToInt32(sqlDataReader["CompanyId"]);
                company.CompanyAddress = Convert.ToString(sqlDataReader["CompanyAddress"]);
                company.CompanyName = Convert.ToString(sqlDataReader["CompanyName"]);
                companyList.Add(company);
            }

            return companyList;
            
        }

        public int Update(Company company)
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=ADOPracDb;Trusted_connection=True;TrustServerCertificate=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("UpdateCompany", connection);
            command.Parameters.AddWithValue("@CompanyId", company.CompanyId);
            command.Parameters.AddWithValue("@CompanyName", company.CompanyName);
            command.Parameters.AddWithValue("@CompanyAddress", company.CompanyAddress);
            command.CommandType = CommandType.StoredProcedure;
            var result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }
    }
}
