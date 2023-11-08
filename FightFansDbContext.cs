using Microsoft.EntityFrameworkCore;
using FightFans.Models;

namespace FightFans
{
    public class FightFansDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }

        public FightFansDbContext(DbContextOptions<FightFansDbContext> options) : base(options)
        {

        }
        // This is an override of the OnModelCreating method from the base DbContext class.
        // It is called when Entity Framework Core is building the model for your database.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // This line calls the base class's OnModelCreating method.
            // It ensures that any configurations defined in the base class are applied before your custom configurations.
            base.OnModelCreating(modelBuilder);

            // This line specifies that you are configuring the User entity.
            modelBuilder.Entity<User>().HasData( //(.HasData) This method is used to specify the seed data for the User entity.
                new User { Id = 1, Name = "User1", Email = "user1@example.com" },
                new User { Id = 2, Name = "User2", Email = "user2@example.com" }
            );

            // Seed Posts
            modelBuilder.Entity<Post>().HasData(
                new Post { Id = 1, UserId = 1, Title = "Post Title 1", Content = "Content for Post 1" },
                new Post { Id = 2, UserId = 2, Title = "Post Title 2", Content = "Content for Post 2" }
            );

            // Seed Comments
            modelBuilder.Entity<Comment>().HasData(
                new Comment { Id = 1, PostId = 1, UserId = 1, Content = "Comment 1 for Post 1" },
                new Comment { Id = 2, PostId = 2, UserId = 2, Content = "Comment 1 for Post 2" }
            );

            // Seed Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Title = "Category 1" },
                new Category { Id = 2, Title = "Category 2" }
            );
        }
    }
}
