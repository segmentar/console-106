using Core;

namespace Core.DimensionThreeThird
{
    using System;

    public partial class VirtualFile
    {
        public static VirtualFile MakeVirtualFileDefaultSurface(String filename, Byte[] contentByteArray)
        {
            VirtualFile virtualFileResult = default;

            virtualFileResult = MakeVirtualFileDefault(filename, contentByteArray, VirtualFilePolicy.VirtualFileDebugPolicy);

            return virtualFileResult;
        }
    }
}
