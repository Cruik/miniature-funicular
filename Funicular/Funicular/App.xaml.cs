using System;
using System.Globalization;
using System.Threading.Tasks;
using Funicular.Base;
using Funicular.Interfaces;
using Funicular.ViewModels;
using Funicular.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Calendar = Funicular.Views.Calendar;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace Funicular
{
    public partial class App : Application
    {
        
        ISettingsService _settingsService;
        public App()
        {
            InitializeComponent();

            InitApp();
            MainPage = new AppShell ();
            
        }

        private void InitApp()
        {
            _settingsService = ViewModelLocator.Resolve<ISettingsService>();
            if (!_settingsService.UseMocks)
                ViewModelLocator.UpdateDependencies(_settingsService.UseMocks);
        }

        private Task InitNavigation()
        {
            var navigationService = ViewModelLocator.Resolve<INavigationService>();
            return navigationService.InitializeAsync();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}