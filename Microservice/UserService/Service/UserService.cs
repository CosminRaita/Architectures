using UserService.DataAccess;
using UserService.Dto;
using UserService.Model;

namespace UserService.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository postRepository)
        {
            _userRepository = postRepository;
        }

        public User CreateUser(UserDto userDto)
        {
            var user = new User { Username = userDto.Username, Email = userDto.Email };

            return _userRepository.Create(user);
        }
    }
}
