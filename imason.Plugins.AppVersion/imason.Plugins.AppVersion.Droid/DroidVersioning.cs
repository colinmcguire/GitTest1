using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Content.PM;

namespace imason.Plugins.AppVersion.Droid
{
    public class DroidVersioning : IVersioning
    {
        public string AppVersion()
        {
            Context context = Application.Context;
            PackageManager packageManager = context.PackageManager;
            string packageName = context.PackageName;

            string myVersionName = "not available";

            try
            {
                myVersionName = packageManager.GetPackageInfo(packageName, 0).VersionName;
            }
            catch { }

            return myVersionName;
        }
    }
}