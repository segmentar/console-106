using Core;

namespace Core
{
    using System;

    public partial class Hostlocalline
    {
        static Hostlocalline()
        {
            return;
        }
        
        public static void Procedure()
        {
            HostlocallinePolicy.HostlocallineDebugPolicy = true;

            HostlocallinePolicy.HostlocallineInfoPolicy = true;

            return;
        }

        public static void Manual()
        {
            return;
        }

        public static void Raise()
        {
            if (HostlocallinePolicy.HostlocallineInfoPolicy is true)
            {
                Host.Render($"{nameof(HostCode.RenderPath.Core_Host_Info)}-{nameof(Hostlocalline)}Info", HostlocallinePolicy.HostlocallineArrayList.ToArray());
            }
            else
                "false".ToString();

            return;
        }

        public static void Bundle()
        {
            Procedure();

            Manual();

            Raise();

            return;
        }
    }
}
