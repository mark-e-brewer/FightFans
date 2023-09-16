namespace FightFans.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string? Title { get; set; }
        // Navigation Property (Many-to-Many with Post through PostCategory)
        public ICollection<Post>? Posts { get; set; }
    }
}
