using Core;

using Core.DimensionThreeThird;

namespace Core.DimensionTwoSecond
{
    using System;

    public partial class Specialize
    {
        public static VirtualFilesystem GetVirtualFilesystemInstance()
        {
            VirtualFilesystem virtualFilesystemResult = default;

            if (ArchitectureTwoSecond.HasVirtualFilesystem is false)
            {
                return virtualFilesystemResult;
            }
            else
                "false".ToString();

            VirtualFilesystem virtualFilesystem;

            virtualFilesystem = ArchitectureTwoSecond.VirtualFilesystem;

            return virtualFilesystem;
        }
    }
}
