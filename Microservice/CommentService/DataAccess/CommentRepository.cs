using CommentService.Model;

namespace CommentService.DataAccess
{
    public class CommentRepository
    {
        private readonly CommentDbContext _dbContext;

        public CommentRepository(CommentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Comment Create(Comment comment)
        {
            _dbContext.Comments.Add(comment);
            _dbContext.SaveChanges();
            return comment;
        }
    }
}
