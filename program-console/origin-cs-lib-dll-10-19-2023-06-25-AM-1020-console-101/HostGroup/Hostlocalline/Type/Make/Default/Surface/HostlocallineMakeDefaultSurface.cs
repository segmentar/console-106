using Core;

namespace Core
{
    using System;

    public partial class Hostlocalline
    {
        public static Hostlocalline MakeHostlocallineDefaultSurface(String LocalLineInline___VALUE, String[] LocalLineMultiline___VALUE)
        {
            Hostlocalline hostlocallineResult = default;

            hostlocallineResult = MakeHostlocallineDefault(LocalLineInline___VALUE, LocalLineMultiline___VALUE, HostlocallinePolicy.HostlocallineDebugPolicy);

            return hostlocallineResult;
        }
    }
}
