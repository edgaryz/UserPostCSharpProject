using UserPostSolution.Core.Models;

namespace UserPostSolution.Core.Contracts
{
    public interface IPostRepository
    {
        List<Post> GetAllPosts();
        void CreatePost(Post post);
        void DeletePost(Post post);
    }
}
