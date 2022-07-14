using System.Threading.Tasks;

namespace Funicular.Services
{
    public interface IOpenUrlService
    {
        Task OpenUrl(string url);
    }
}