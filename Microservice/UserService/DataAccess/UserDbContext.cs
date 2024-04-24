using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using UserService.Model;

namespace UserService.DataAccess
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
