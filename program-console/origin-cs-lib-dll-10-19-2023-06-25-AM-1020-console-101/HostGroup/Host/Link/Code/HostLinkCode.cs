using Core;

namespace Core
{
    using System;

    public partial class HostCode
    {
        public enum RenderPath
        {
            Unset,
            Core_Host_Debug,
            Core_Host_Info,
            Core_Host_Fatal,
            Core_Host_Static,
        }
    }
}
