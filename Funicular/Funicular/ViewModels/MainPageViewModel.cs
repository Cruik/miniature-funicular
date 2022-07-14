using System;
using System.Threading.Tasks;
using Funicular.Base;
using Funicular.Views;
using Xamarin.CommunityToolkit.ObjectModel;

namespace Funicular.ViewModels
{
    public class MainPageViewModel: ViewModelBase
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
        public MainPageViewModel()
        {
            try
            {
                ButtonSelectedCommand = new AsyncCommand(() => GoToCommand(), _ => CanExecute);
                
                CanExecute = true;

            }
            catch(Exception ex)
            {
                
            }
        }

        private async Task GoToCommand()
        {
            try
            {

            
                await NavigationService.NavigateToAsync("Login");
            }
            catch(Exception ex)
            {
                
            }
        }
    }
}