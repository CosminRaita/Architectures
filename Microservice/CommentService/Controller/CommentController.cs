using CommentService.Dto;
using CommentService.Service;
using Microsoft.AspNetCore.Mvc;

namespace CommentService.Controller
{
    [ApiController]
    [Route("api/comments")]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpPost]
        public IActionResult CreateCommnet(CommentDto commentDto)
        {
            var newComment = _commentService.CreateComment(commentDto);
            return Ok();
        }
    }
}
