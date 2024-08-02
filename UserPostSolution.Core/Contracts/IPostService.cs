using UserPostSolution.Core.Models;

namespace UserPostSolution.Core.Contracts
{
    public interface IPostService
    {
        List<Post> GetAllPosts();
        void CreatePost(Post post);
        void DeletePost(Post post);
    }
}
