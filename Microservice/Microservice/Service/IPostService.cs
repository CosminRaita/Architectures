using Microservice.Dto;
using Microservice.Model;

namespace Microservice.Service
{
    public interface IPostService
    {
        Post CreatePost(PostDto postDto);
    }

}
