using UserPostSolution.Core.Contracts;
using UserPostSolution.Core.Models;
using UserPostSolution.Core.Repositories;
using UserPostSolution.Core.Services;

namespace UserPostCSharpProject
{
    public class Program
    {
        public static void Main(string[] args)
        {


            IBusinessLogicService businessLogicService = SetupDependencies();
            while (true)
            {
                Console.WriteLine("1. Show all Users");
                Console.WriteLine("2. Show all Posts");
                Console.WriteLine("3. Create New User");
                Console.WriteLine("4. Create New Post");
                Console.WriteLine("5. Delete User");
                Console.WriteLine("6. Delete Post");
                Console.WriteLine("0. Exit Program");
                Console.WriteLine("-------------------------");
                string choice = Console.ReadLine();
                switch(choice)
                {
                    case "0":
                        return;
                    case "1":
                        List<User> userList = businessLogicService.GetAllUsers();
                        foreach (User user in userList)
                        {
                            Console.WriteLine(user);
                        }
                        break;
                }
            }
        }
        public static IBusinessLogicService SetupDependencies()
        {
            IUserRepository userRepository = new UserRepository("Server=localhost;Database=users_posts_db;Trusted_Connection=True;");
            IPostRepository postRepository = new PostRepository("Server=localhost;Database=users_posts_db;Trusted_Connection=True;");
            IUserService userService = new UserService(userRepository);
            IPostService postService = new PostService(postRepository);
            return new BusinessLogicService(userService, postService);
        }
    }
}

