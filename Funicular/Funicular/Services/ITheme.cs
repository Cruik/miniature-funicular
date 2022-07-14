using System.Drawing;

namespace Funicular.Services
{
    public interface ITheme
    {
        void SetStatusBarColor(Color color, bool darkStatusBarTint);
    }
}