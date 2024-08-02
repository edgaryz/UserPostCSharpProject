using Dapper;
using System.Data;
using System.Data.SqlClient;
using UserPostSolution.Core.Contracts;
using UserPostSolution.Core.Models;

namespace UserPostSolution.Core.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly string _dbConnectionString;
        public PostRepository(string connectionString)
        {
            _dbConnectionString = connectionString;
        }
        public List<Post> GetAllPosts()
        {
            using IDbConnection dbConnection = new SqlConnection(_dbConnectionString);
            dbConnection.Open();
            var result = dbConnection.Query<Post>(@"SELECT id, user_id AS UserId, title, content FROM posts").ToList();
            dbConnection.Close();
            return result;
        }
        public void CreatePost(Post post)
        {
            string sqlCommand = "INSERT INTO posts (user_id, title, content) VALUES (@UserId, @Title, @Content)";

            using (var connection = new SqlConnection(_dbConnectionString))
            {
                connection.Execute(sqlCommand, post);
            }
        }
        public void DeletePost(int id)
        {
            string sqlCommand = "DELETE FROM posts WHERE id = @Id";

            using (var connection = new SqlConnection(_dbConnectionString))
            {
                connection.Execute(sqlCommand, new { Id = id });
            }
        }
    }
}
