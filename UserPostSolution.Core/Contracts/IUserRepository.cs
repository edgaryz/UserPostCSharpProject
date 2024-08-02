using UserPostSolution.Core.Models;

namespace UserPostSolution.Core.Contracts
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
        void CreateUser(User user);
        void DeleteUser(User user);
    }
}
