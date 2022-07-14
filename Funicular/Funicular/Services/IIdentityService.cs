using System.Threading.Tasks;
using Funicular.Models;

namespace Funicular.Services
{
    public interface IIdentityService
    {
        string CreateAuthorizationRequest();
        string CreateLogoutRequest(string token);
        Task<UserToken> GetTokenAsync(string code);
    }
}