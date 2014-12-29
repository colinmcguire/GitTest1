using Cirrious.CrossCore;
using Cirrious.CrossCore.Plugins;

namespace imason.Plugins.AppVersion.WinRT
{
    public class Plugin : IMvxPlugin
    {
        public void Load()
        {
            Mvx.RegisterType<IVersioning, WinRTVersioning>();
        }
    }
}
