using Android.App;
using Android.Content.PM;
using Cirrious.MvvmCross.Droid.Views;

namespace imason.Plugins.AppVersion.Droid
{
    [Activity(
		Label = "imason.Plugins.AppVersion.Droid"
		, MainLauncher = true
		, Icon = "@drawable/icon"
		, Theme = "@style/Theme.Splash"
		, NoHistory = true
		, ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}