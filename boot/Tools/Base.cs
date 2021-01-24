using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boot.Tools
{
    public static class Base
    {
        public static void SetCore()
        {
            string appName = AppDomain.CurrentDomain.SetupInformation.ApplicationName;
            RegistryKey key = Registry.CurrentUser;
            RegistryKey software = key.CreateSubKey(@"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION\" + appName);
            RegistryKey ieVersion = key.OpenSubKey(@"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true);
            object version = 0x02710;
            ieVersion.SetValue(appName, version, RegistryValueKind.DWord);

        }
       
    }
}
