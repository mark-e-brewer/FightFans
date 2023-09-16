namespace FightFans.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public int? PostId { get; set; }

        public int? UserId { get; set; }

        public string? Content { get; set; }

        public DateTime? createdOn { get; set; }
        // Navigation Property (Many-to-One with Post)
        public User? User { get; set; }
        // Navigation Property (Many-to-One with User)
        public Post? Post { get; set; }
    }
}
