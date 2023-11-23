using Core;

using Core.DimensionThreeThird;

namespace Core.DimensionTwoSecond
{
    using System;

    public partial class Specialize
    {
        public static void SetVirtualFilesystemInstance(VirtualFilesystem virtualFilesystem, Boolean hasVirtualFilesystem)
        {
            ArchitectureTwoSecond.VirtualFilesystem = virtualFilesystem;

            ArchitectureTwoSecond.HasVirtualFilesystem = hasVirtualFilesystem;

            return;
        }
    }
}
