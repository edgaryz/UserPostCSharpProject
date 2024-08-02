namespace UserPostSolution.Core.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public User() { }
        public User(string name, string email)
        {
            Name = name;
            Email = email;
        }
        public User(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }
        public override string ToString()
        {
            return $"User ID: {Id}, User Name: {Name}, Email: {Email}.";
        }
    }
}
