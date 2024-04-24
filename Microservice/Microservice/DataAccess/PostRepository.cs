using Microservice.Model;

namespace Microservice.DataAccess
{
    public class PostRepository : IPostRepository
    {
        private readonly PostDbContext _dbContext;

        public PostRepository(PostDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Post Create(Post post)
        {
            _dbContext.Posts.Add(post);
            _dbContext.SaveChanges();
            return post;
        }
    }

}
