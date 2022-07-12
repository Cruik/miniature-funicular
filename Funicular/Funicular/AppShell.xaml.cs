using System;
using Funicular.Base;
using Funicular.Interfaces;
using Funicular.ViewModels;
using Funicular.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Funicular
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeRouting();
            InitializeComponent();

            var settingsService = ViewModelLocator.Resolve<ISettingsService>();

            if(string.IsNullOrEmpty(settingsService.AuthAccessToken))
            {
                this.GoToAsync("//Login");
            }
        }

        private void InitializeRouting()
        {
            Routing.RegisterRoute("Calendar", typeof(Calendar));
        }
    }
}