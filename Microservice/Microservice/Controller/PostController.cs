using Microservice.Dto;
using Microservice.Service;
using Microsoft.AspNetCore.Mvc;

namespace Microservice.Controllers
{
    [ApiController]
    [Route("api/posts")]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpPost]
        public IActionResult CreatePost(PostDto postDto)
        {
            var newPost = _postService.CreatePost(postDto);
            return Ok();
        }
    }
}
