using UserPostSolution.Core.Contracts;
using UserPostSolution.Core.Models;

namespace UserPostSolution.Core.Services
{
    public class PostService: IPostService
    {
        private readonly IPostRepository _postRepository;
        public PostService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public List<Post> GetAllPosts()
        {
            return _postRepository.GetAllPosts();
        }
        public void CreatePost(Post post)
        {
            _postRepository.CreatePost(post);
        }
        public void DeletePost(int id)
        {
            _postRepository.DeletePost(id);
        }
    }
}
