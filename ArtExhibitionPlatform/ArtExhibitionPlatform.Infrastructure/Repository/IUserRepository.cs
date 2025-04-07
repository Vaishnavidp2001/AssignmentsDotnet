using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtexibitionPlatform.Domain;

namespace ArtExhibitionPlatform.Infrastructure.Repository
{
    public interface IUserRepository
    {
        Task<User> GetByIdAsync(int userId);
        Task<User> GetByUsernameAsync(string username);
        Task<bool> AddAsync(User user);
        Task<bool> UpdateAsync(User user);
        Task<bool> RemoveAsync(int userId);
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task DeleteAsync(int userId);
    }
}
