namespace UserPostSolution.Core.Models
{
    public class Post
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Post() { }
        public Post(int userId, string title, string content)
        {
            UserId = userId;
            Title = title;
            Content = content;
        }
        public Post(int id, int userId, string title, string content)
        {
            Id = id;
            UserId = userId;
            Title = title;
            Content = content;
        }
        public override string ToString()
        {
            return $"Post ID: {Id}, User ID: {UserId}, Title: {Title}, Content: {Content}.";
        }

    }
}
