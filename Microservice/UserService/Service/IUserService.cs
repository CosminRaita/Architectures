using UserService.Dto;
using UserService.Model;

namespace UserService.Service
{
    public interface IUserService
    {
        User CreateUser(UserDto userDto);
    }
}
