using AdoPrac.Models;
using Microsoft.Data.SqlClient;

namespace AdoPrac.Repository
{
    public class StudentRepository : IStudentRepository
    {
        public int CreateStudent(Students students)
        {
            string connectionstring = "Server=localhost;Database=ADO;Trusted_connection=True;TrustServerCertificate=True;";
            SqlConnection connection = new SqlConnection(connectionstring);

            connection.Open();
            SqlCommand sqlCommand = new SqlCommand()
        }
    }
}
