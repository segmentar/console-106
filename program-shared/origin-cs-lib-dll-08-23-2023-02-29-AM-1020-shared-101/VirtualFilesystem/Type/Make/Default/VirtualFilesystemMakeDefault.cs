using Core.Shared;

namespace Core.Shared
{
    using System;

    using System.Text;

    public partial class VirtualFilesystem
    {
        public static VirtualFilesystem MakeVirtualFilesystemDefault(Encoding encoding, VirtualFolder virtualFolder, Boolean debug)
        {
            VirtualFilesystem virtualFilesystemResult = default;

            var result = new VirtualFilesystemSequence(encoding, virtualFolder, debug).Result;

            Policy.VirtualFilesystemArrayList.Add(result);

            virtualFilesystemResult = result;

            return virtualFilesystemResult;
        }
    }
}
