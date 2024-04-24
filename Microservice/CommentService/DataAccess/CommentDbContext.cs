using CommentService.Model;
using Microsoft.EntityFrameworkCore;

namespace CommentService.DataAccess
{
    public class CommentDbContext : DbContext
    {
        public CommentDbContext(DbContextOptions<CommentDbContext> options) : base(options)
        {
        }
        public DbSet<Comment> Comments { get; set; }
    }
}
