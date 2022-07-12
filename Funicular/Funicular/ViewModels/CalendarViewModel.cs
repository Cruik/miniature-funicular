using System.Threading.Tasks;
using Funicular.Base;
using Funicular.Views;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace Funicular.ViewModels
{
    public class CalendarViewModel : ViewModelBase
    {

        public IAsyncCommand ButtonSelectedCommand { get; }
        
        bool _canExecute;

        public bool CanExecute
        {
            get => _canExecute;
            set
            {
                if(_canExecute != value)
                {
                    _canExecute = value;
                    ButtonSelectedCommand.RaiseCanExecuteChanged();
                }
            }
        }
        public CalendarViewModel()
        {
        }

        private async Task GoToCommand()
        {
            var page = new Calendar();
            await NavigationDispatcher.Instance.Navigation.PushAsync(page);
        }
    }
}