using Microservice.DataAccess;
using Microservice.Dto;
using Microservice.Model;

namespace Microservice.Service
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;

        public PostService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public Post CreatePost(PostDto postDto)
        {
            var post = new Post { Title = postDto.Title, Content = postDto.Content };

            return _postRepository.Create(post);
        }
    }

}
