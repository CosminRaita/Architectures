using Microsoft.EntityFrameworkCore;
using Monolith.Model;
using System.Collections.Generic;

namespace Monolith.DataAccess
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }
    }

}
