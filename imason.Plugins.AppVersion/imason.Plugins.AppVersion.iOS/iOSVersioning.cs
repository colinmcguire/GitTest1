using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace imason.Plugins.AppVersion.iOS
{
    public class iOSVersioning : IVersioning
    {
        public string AppVersion()
        {
            string appVersion = "Not available";

            NSBundle mainBundle = NSBundle.MainBundle;
            NSDictionary infoDictionary = mainBundle.InfoDictionary;

            NSString shortVersionKey = new NSString("CFBundleShortVersionString");
            NSObject objShortVersion = infoDictionary.ValueForKey(shortVersionKey);
            string shortVersion = string.Empty;
            if (objShortVersion != null)
                shortVersion = objShortVersion.ToString();

            NSString versionKey = new NSString("CFBundleVersion");
            NSObject objVersion = infoDictionary.ValueForKey(versionKey);
            string version = string.Empty;
            if (objVersion != null)
                version = objVersion.ToString();

            if (!string.IsNullOrEmpty(shortVersion) && !string.IsNullOrEmpty(version))
                appVersion = string.Concat(shortVersion, version);

            return appVersion;
        }
    }
}