using Microservice.Model;

namespace Microservice.DataAccess
{
    public interface IPostRepository
    {
        Post Create(Post post);
    }

}
