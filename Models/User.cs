namespace FightFans.Models
{
    public class User
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Email { get; set; }
        // Navigation Property (One-to-Many with Post)
        public ICollection<Post>? Posts { get; set; }
        // Navigation Property (One-to-Many with Comment)
        public ICollection<Comment>? Comments { get; set; }
    }
}
