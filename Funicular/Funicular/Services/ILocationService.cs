using System.Threading.Tasks;

namespace Funicular.Services
{
    public interface ILocationService
    {
        Task UpdateUserLocation(Models.Location newLocReq, string token);
    }
}