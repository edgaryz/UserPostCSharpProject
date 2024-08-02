using UserPostSolution.Core.Models;

namespace UserPostSolution.Core.Contracts
{
    public interface IUserService
    {
        List<User> GetAllUsers();
        void CreateUser(User user);
        void DeleteUser(int id);
    }
}
