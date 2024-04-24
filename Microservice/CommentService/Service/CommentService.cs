using CommentService.DataAccess;
using CommentService.Dto;
using CommentService.Model;

namespace CommentService.Service
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;

        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public Comment CreateComment(CommentDto commentDto)
        {
            var comment = new Comment { Content = commentDto.Content, PostId = commentDto.PostId };

            return _commentRepository.Create(comment);
        }
    }
}
