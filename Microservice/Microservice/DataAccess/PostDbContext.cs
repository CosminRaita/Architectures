using Microservice.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Microservice.DataAccess
{
    public class PostDbContext : DbContext
    {
        public PostDbContext(DbContextOptions<PostDbContext> options) : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
    }
}
