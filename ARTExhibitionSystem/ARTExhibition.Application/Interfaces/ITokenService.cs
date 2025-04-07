using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ARTExhibition.Application.Interfaces
{
    public interface ITokenService
    {
        string GenerateToken(string userId, string userRole);
        Task<string> LoginAsync(string username, string password);
        Task<string> RegisterAsync(string username, string password);
    }
}
