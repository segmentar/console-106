using Core;

namespace Core
{
    using System;

    public partial class Virtualfile
    {
        public static Virtualfile MakeVirtualfileDefaultSurface(String Filename_VALUE, Byte[] Content_ARRAY)
        {
            Virtualfile virtualFileResult = default;

            virtualFileResult = MakeVirtualfileDefault(Filename_VALUE, Content_ARRAY, VirtualfilePolicy.VirtualFileDebugPolicy);

            return virtualFileResult;
        }
    }
}
