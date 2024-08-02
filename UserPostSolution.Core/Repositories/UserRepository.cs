using System.Data;
using UserPostSolution.Core.Models;
using Dapper;
using System.Data.SqlClient;
using UserPostSolution.Core.Contracts;

namespace UserPostSolution.Core.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly string _dbConnectionString;
        public UserRepository(string connectionString)
        {
            _dbConnectionString = connectionString;
        }
        public List<User> GetAllUsers()
        {
            using IDbConnection dbConnection = new SqlConnection(_dbConnectionString);
            dbConnection.Open();
            var result = dbConnection.Query<User>(@"SELECT * FROM users").ToList();
            dbConnection.Close();
            return result;
        }
        public void CreateUser(User user)
        {
            string sqlCommand = "INSERT INTO users (name, email) VALUES (@Name, @Email)";

            using (var connection = new SqlConnection(_dbConnectionString))
            {
                connection.Execute(sqlCommand, user);
            }
        }
        public void DeleteUser(int id)
        {
            string sqlCommand = "DELETE FROM users WHERE id = @Id";

            using (var connection = new SqlConnection(_dbConnectionString))
            {
                connection.Execute(sqlCommand, new {Id = id });
            }
        }

    }
}
