using Cirrious.CrossCore;
using Cirrious.CrossCore.Plugins;

namespace imason.Plugins.AppVersion.Droid
{
    public class Plugin : IMvxPlugin
    {
        public void Load()
        {
            Mvx.RegisterType<IVersioning, DroidVersioning>();
        }
    }
}
