using Core;

namespace Core.DimensionThreeThird
{
    using System;

    public partial class VirtualFilesystem
    {
        public void Render()
        {
            var array_FOLDER = VirtualFolder.VirtualFolderRecurseSetSurface(0, VirtualFolderRoot);

            var array_FILE = VirtualFolder.VirtualFolderTraverseSetSurface(0,array_FOLDER);

            return;
        }
    }
}
