using Core.Shared;

namespace Core.Shared
{
    using System;

    public partial class VirtualFile
    {
        public static VirtualFile MakeVirtualFileDefaultSurface(String filename, Byte[] contentByteArray)
        {
            VirtualFile virtualFileResult = default;

            virtualFileResult = MakeVirtualFileDefault(filename, contentByteArray, Policy.VirtualFileDebugPolicy);

            return virtualFileResult;
        }
    }
}
