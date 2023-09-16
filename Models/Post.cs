namespace FightFans.Models
{
    public class Post
    {
        public int Id { get; set; }

        public int? UserId { get; set; }

        public string? Title { get; set; }

        public string? Content { get; set; }

        public DateTime? CreatedOn { get; set;}
        // Navigation Property (Many-to-One with User)
        public User? User { get; set; }
        // Navigation Property (One-to-Many with Comment)
        public ICollection<Comment>? Comments { get; set; }
        // Navigation Property (Many-to-Many with Category through PostCategory)
        public ICollection<Category>? Categories { get; set; }

    }
}
