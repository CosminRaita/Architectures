using CommentService.Model;

namespace CommentService.DataAccess
{
    public interface ICommentRepository
    {
        Comment Create(Comment comment);
    }
}
