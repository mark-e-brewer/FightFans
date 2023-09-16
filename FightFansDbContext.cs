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
    }
}
