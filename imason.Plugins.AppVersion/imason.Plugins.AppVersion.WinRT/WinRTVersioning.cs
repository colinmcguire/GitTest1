using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel;

namespace imason.Plugins.AppVersion.WinRT
{
    public class WinRTVersioning : IVersioning
    {
        public string AppVersion()
        {
            PackageVersion version = Package.Current.Id.Version;
            string versionString = string.Format("{0}.{1}.{2}.{3}", version.Major, version.Minor, version.Build, version.Revision);
            return versionString;
        }
    }
}
