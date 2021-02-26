using System;
using System.Runtime.InteropServices;

namespace AyatanaAppIndicator
{
    public partial class ApplicationIndicator : GLib.Object
    {
        [DllImport ("ayatana-appindicator.dll")]
        static extern int app_indicator_get_status (IntPtr i);

        [DllImport ("ayatana-appindicator.dll")]
        static extern int app_indicator_get_category (IntPtr i);

        [DllImport ("ayatana-appindicator.dll")]
        static extern void app_indicator_set_status (IntPtr i, int s);

        [GLib.Property ("status")]
        public AppIndicatorStatus AppIndicatorStatus
        {
            get
            {
                return (AppIndicatorStatus) app_indicator_get_status (Handle);
            }

            set
            {
                app_indicator_set_status (Handle, (int) value);
            }
        }

        [GLib.Property ("category")]
        public AppIndicatorCategory AppIndicatorCategory
        {
            get
            {
                return (AppIndicatorCategory) app_indicator_get_category (Handle);
            }
        }
    }
}
