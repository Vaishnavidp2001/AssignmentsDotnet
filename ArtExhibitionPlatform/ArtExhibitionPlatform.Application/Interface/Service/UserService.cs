using ArtExhibitionPlatform.Infrastructure.Repository;
using ArtexibitionPlatform.Domain;

namespace ArtExhibitionPlatform.Application.Interface.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> GetUserByIdAsync(int userId)
        {
            return await _userRepository.GetByIdAsync(userId);
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllUsersAsync();
        }

        public async Task<User> GetUserByUsernameAsync(string username)
        {
            return await _userRepository.GetByUsernameAsync(username);
        }

        public async Task<bool> CreateUserAsync(User user)
        {
            await _userRepository.AddAsync(user);
            return true;
        }

        public async Task<bool> UpdateUserAsync(User user)
        {
            await _userRepository.UpdateAsync(user);
            return true;
        }

        public async Task<bool> DeleteUserAsync(int userId)
        {
            await _userRepository.DeleteAsync(userId);
            return true;
        }
    }


}
