using UserPostSolution.Core.Models;
using UserPostSolution.Core.Services;

namespace UserPostSolution.Core.Contracts
{
    public interface IBusinessLogicService
    {
        public List<User> GetAllUsers();
        public void CreateUser(User user);
        public void DeleteUser(int id);
        public List<Post> GetAllPosts();
        public void CreatePost(Post post);
        public void DeletePost(int id);
    }
}
