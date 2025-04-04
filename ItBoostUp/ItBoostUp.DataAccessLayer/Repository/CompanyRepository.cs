using ItBoostUp.BuisnessLayer.Interface;
using ItBoostUp.BuisnessLayer.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItBoostUp.DataAccessLayer.Repository
{

    public class CompanyRepository : ICompanyRepository
    {

        public int Create(Company company)
        {
            string connString = "Server=localhost;Database=ItBoostUp;Integrated Security=True;TrustServerCertificate=True";
            
            SqlConnection con = new SqlConnection(connString);
            con.Open();

            SqlCommand cmd = new SqlCommand("CreateCompany", con);
            cmd.Parameters.AddWithValue("@Name", company.Name);
            cmd.Parameters.AddWithValue("@Address", company.Address);
            cmd.CommandType = CommandType.StoredProcedure;
            var result = cmd.ExecuteNonQuery();
            con.Close();

            return result;
        }

        public Company GetById(int id)
        {
            string connString = "Server=localhost;Database=ItBoostUp;Integrated Security=True;TrustServerCertificate=True";

            SqlConnection con = new SqlConnection(connString);
            con.Open();

            SqlCommand cmd = new SqlCommand("GetById", con);
            cmd.Parameters.AddWithValue("@CompanyId", id);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            var company = new Company();

            while (sqlDataReader.Read())
            {
                company.Id = Convert.ToInt32(sqlDataReader["CompanyId"]);
                company.Name = sqlDataReader.GetString(1);
                company.Address = sqlDataReader.GetString(2);

            }
            if(company.Id == 0)
            {
                return null;
            }
            return company;
        }

        public List<Company> List()
        {
            string connString = "Server=localhost;Database=ItBoostUp;Integrated Security=True;TrustServerCertificate=True";

            SqlConnection con = new SqlConnection(connString);
            con.Open();

            SqlCommand cmd = new SqlCommand("GetCompanies", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            var list = new List<Company>();

            while (sqlDataReader.Read())
            {
                Company company = new Company();
                company.Id = Convert.ToInt32(sqlDataReader["CompanyId"]);
                company.Name = sqlDataReader.GetString(1);
                company.Address = sqlDataReader.GetString(2);

                list.Add(company);
            }
            if(list.Count == 0)
            {
                return null;
            }
            return list;
        }

        public int Update(Company company)
        {
            string connString = "Server=localhost;Database=ItBoostUp;Integrated Security=True;TrustServerCertificate=True";

            SqlConnection con = new SqlConnection(connString);
            con.Open();

            SqlCommand cmd = new SqlCommand("UpdateCompany", con);
            cmd.Parameters.AddWithValue("@CompanyId", company.Id);
            cmd.Parameters.AddWithValue("@Name", company.Name);
            cmd.Parameters.AddWithValue("@Address", company.Address);

            cmd.CommandType = CommandType.StoredProcedure;
            var result = cmd.ExecuteNonQuery();
            con.Close();

            return result;


        }

        public int Delete(int id)
        {
            string connString = "Server=localhost;Database=ItBoostUp;Integrated Security=True;TrustServerCertificate=True";

            SqlConnection con = new SqlConnection(connString);
            con.Open();

            SqlCommand cmd = new SqlCommand("DeleteCompany", con);
            cmd.Parameters.AddWithValue("@CompanyId", id);
            cmd.CommandType = CommandType.StoredProcedure;
            var result = cmd.ExecuteNonQuery();
            con.Close();

            return result;
        }
    }
}
