using CommentService.Dto;
using CommentService.Model;

namespace CommentService.Service
{
    public interface ICommentService
    {
        Comment CreateComment(CommentDto commentDto);
    }
}
