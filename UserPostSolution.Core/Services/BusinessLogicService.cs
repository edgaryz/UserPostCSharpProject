using UserPostSolution.Core.Contracts;
using UserPostSolution.Core.Models;
using UserPostSolution.Core.Repositories;

namespace UserPostSolution.Core.Services
{
    public class BusinessLogicService : IBusinessLogicService
    {
        public readonly IUserService _userService;
        public readonly IPostService _postService;
        public BusinessLogicService(IUserService userService, IPostService postService)
        {
            _postService = postService;
            _userService = userService;
        }

        public List<User> GetAllUsers()
        {
            return _userService.GetAllUsers();
        }
        public void CreateUser(User user)
        {
            _userService.CreateUser(user);
        }
        public void DeleteUser(int id)
        {
            _userService.DeleteUser(id);
        }
        public List<Post> GetAllPosts()
        {
            return _postService.GetAllPosts();
        }
        public void CreatePost(Post post)
        {
            _postService.CreatePost(post);
        }
        public void DeletePost(int id)
        {
            _postService.DeletePost(id);
        }
    }
}