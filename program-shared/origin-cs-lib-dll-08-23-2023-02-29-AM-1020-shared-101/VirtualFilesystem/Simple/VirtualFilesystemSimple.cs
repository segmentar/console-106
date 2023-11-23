using Core.Shared;

namespace Core.Shared
{
    using System;

    using System.Text;

    public partial class VirtualFilesystemSimple
    {
        public VirtualFilesystem Result { get; set; } = default;

        public VirtualFilesystemSimple(VirtualFolder virtualFolder)
        {
            VirtualFilesystem virtualFilesystem;

            virtualFilesystem = VirtualFilesystem.MakeVirtualFilesystemDefaultSurface(Encoding.Default, virtualFolder);

            this.Result = virtualFilesystem;

            return;
        }

        ~VirtualFilesystemSimple()
        {
            return;
        }
    }
}
