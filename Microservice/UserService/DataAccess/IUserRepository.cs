using UserService.Model;

namespace UserService.DataAccess
{
    public interface IUserRepository
    {
        User Create(User user);
    }
}
