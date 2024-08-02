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
                switch (choice)
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
                    case "2":
                        List<Post> postList = businessLogicService.GetAllPosts();
                        foreach (Post post in postList)
                        {
                            Console.WriteLine(post);
                        }
                        break;
                    case "3":
                        User newUser = new User();
                        Console.WriteLine("Enter User Name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter Email");
                        string email = Console.ReadLine();
                        newUser = new User(name, email);
                        businessLogicService.CreateUser(newUser);
                        Console.WriteLine("User creation successful!");
                        break;
                    case "4":
                        Post newPost = new Post();
                        Console.WriteLine("Enter Post Creators UserId");
                        int userId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Post Title");
                        string title = Console.ReadLine();
                        Console.WriteLine("Enter Post Content");
                        string content = Console.ReadLine();
                        newPost = new Post(userId, title, content);
                        businessLogicService.CreatePost(newPost);
                        Console.WriteLine("Post creation successful!");
                        break;
                    case "5":
                        Console.WriteLine("Enter UserId to delete user");
                        int deleteUserId = int.Parse(Console.ReadLine());
                        businessLogicService.DeleteUser(deleteUserId);
                        Console.WriteLine("User delete successful!");
                        break;
                    case "6":
                        Console.WriteLine("Enter ID to delete post");
                        int deletePostId = int.Parse(Console.ReadLine());
                        businessLogicService.DeletePost(deletePostId);
                        Console.WriteLine("Post delete successful!");
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

