using UserPostSolution.Core.Contracts;
using UserPostSolution.Core.Models;

namespace UserPostSolution.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository) {
            _userRepository = userRepository;
        }
        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }
        public void CreateUser(User user)
        {
            _userRepository.CreateUser(user);
        }
        public void DeleteUser(int id)
        {
            _userRepository.DeleteUser(id);
        }
    }
}
