using CountryStateManager.BussinessLayer.Interface;
using CountryStateManager.BussinessLayer.Models;
using CountryStateManager.BussinessLayer.Models.ViewModels;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateManager.DataAccessLayer.Repository
{
    public class StateRepository : IStateRepository
    {
        public int Create(State state)
        {
            string connString = "Server=localhost;Database=CountryStateManager;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("CreateState", conn);
            cmd.Parameters.AddWithValue("@Name", state.Name);
            cmd.Parameters.AddWithValue("@CountryId", state.CountryId);
            cmd.Parameters.AddWithValue("@Description", state.Description);
            cmd.Parameters.AddWithValue("@CreatedBy", state.CreatedBy);
            cmd.Parameters.AddWithValue("@IsActive", state.IsActive ? true : false);
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

            SqlCommand cmd = new SqlCommand("DeleteState", conn);
            cmd.Parameters.AddWithValue("@StateId", id);
            cmd.CommandType = CommandType.StoredProcedure;

            var result = cmd.ExecuteNonQuery();

            conn.Close();

            return result;
        }

        public StateViewModel GetById(int id)
        {
            string connString = "Server=localhost;Database=CountryStateManager;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("GetStateById", conn);
            cmd.Parameters.AddWithValue("@StateId", id);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            var state = new StateViewModel();
            while (sqlDataReader.Read())
            {
                state.StateId = Convert.ToInt32(sqlDataReader["StateId"]);
                state.CountryId = Convert.ToInt32(sqlDataReader["CountryId"]);
                state.CountryName = Convert.ToString(sqlDataReader["CountryName"]);
                state.Name = Convert.ToString(sqlDataReader["Name"]);
                state.Description = Convert.ToString(sqlDataReader["Description"]);
                state.CreatedOn = Convert.ToDateTime(sqlDataReader["CreatedOn"]);
                state.CreatedBy = Convert.ToInt32(sqlDataReader["CreatedBy"]);
                state.UpdatedOn = Convert.ToDateTime(sqlDataReader["UpdatedOn"]);
                state.UpdatedBy = Convert.ToInt32(sqlDataReader["UpdatedBy"]);
                state.IsActive = Convert.ToInt32(sqlDataReader["IsActive"]) == 0 ? false : true;
            }
            if(state.StateId == 0)
            {
                return null;
            }

            conn.Close();

            return state;
        }

        public List<State> List()
        {
            string connString = "Server=localhost;Database=CountryStateManager;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("GetStates", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            var list = new List<State>();
            while (sqlDataReader.Read())
            {
                State state = new State();
                state.StateId = Convert.ToInt32(sqlDataReader["StateId"]);
                state.CountryId = Convert.ToInt32(sqlDataReader["CountryId"]);
                state.Name = Convert.ToString(sqlDataReader["Name"]);
                state.Description = Convert.ToString(sqlDataReader["Description"]);
                state.CreatedOn = Convert.ToDateTime(sqlDataReader["CreatedOn"]);
                state.CreatedBy = Convert.ToInt32(sqlDataReader["CreatedBy"]);
                state.UpdatedOn = Convert.ToDateTime(sqlDataReader["UpdatedOn"]);
                state.UpdatedBy = Convert.ToInt32(sqlDataReader["UpdatedBy"]);
                state.IsActive = Convert.ToInt32(sqlDataReader["IsActive"]) == 0 ? false : true;

                list.Add(state);
            }

            conn.Close();

            return list;
        }

        public int Update(StateViewModel state)
        {
            string connString = "Server=localhost;Database=CountryStateManager;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("UpdateState", conn);
            cmd.Parameters.AddWithValue("@StateId", state.StateId);
            cmd.Parameters.AddWithValue("@CountryId", state.CountryId);
            cmd.Parameters.AddWithValue("@Name", state.Name);
            cmd.Parameters.AddWithValue("@Description", state.Description);
            cmd.Parameters.AddWithValue("@IsActive", state.IsActive);
            cmd.Parameters.AddWithValue("@UpdatedBy", state.UpdatedBy);

            cmd.CommandType = CommandType.StoredProcedure;

            var result = cmd.ExecuteNonQuery();

            conn.Close();

            return result;
        }

        public int ActivatState(int id, bool flag)
        {
            string connString = "Server=localhost;Database=CountryStateManager;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("UpdateStateActiveStatus", conn);

            cmd.Parameters.AddWithValue("@StateId", id);
            cmd.Parameters.AddWithValue("@IsActive", flag);

            cmd.CommandType = CommandType.StoredProcedure;

            var result = cmd.ExecuteNonQuery();

            conn.Close();

            return result;
        }
    }
}
