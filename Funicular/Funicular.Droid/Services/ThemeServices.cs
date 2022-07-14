﻿using Android.OS;
using Android.Views;
using Funicular.Droid.Services;
using Funicular.Services;
using Xamarin.Essentials;
using Xamarin.Forms;

[assembly: Dependency(typeof(ThemeService))]

namespace Funicular.Droid.Services
{
    public class ThemeService : ITheme
    {
        public void SetStatusBarColor(System.Drawing.Color color, bool darkStatusBarTint)
        {
            if(Build.VERSION.SdkInt < BuildVersionCodes.Lollipop)
                return;

            var activity = Platform.CurrentActivity;
            var window = activity.Window;
            window.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);
            window.ClearFlags(WindowManagerFlags.TranslucentStatus);
            window.SetStatusBarColor(color.ToPlatformColor());

            if(Build.VERSION.SdkInt >= BuildVersionCodes.M)
            {
                var flag = (StatusBarVisibility) SystemUiFlags.LightStatusBar;
                window.DecorView.SystemUiVisibility = darkStatusBarTint ? flag : 0;
            }
        }

    }
}