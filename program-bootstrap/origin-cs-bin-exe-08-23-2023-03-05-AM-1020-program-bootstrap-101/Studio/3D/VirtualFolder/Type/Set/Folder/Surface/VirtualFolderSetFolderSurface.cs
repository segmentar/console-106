using Core;

namespace Core.DimensionThreeThird
{
    using System;

    public partial class VirtualFolder
    {
        public static VirtualFolder[] VirtualFolderFolderSetSurface(Int32 index, VirtualFolder virtualFolder)
        {
            VirtualFolder[] arrayResult = default;

            var list = VirtualFolderFolderSet(virtualFolder);

            VirtualFolder[] virtualFolderArray;

            virtualFolderArray = new VirtualFolder[list.Count];

            list.CopyTo(virtualFolderArray, index);

            arrayResult = virtualFolderArray;

            return arrayResult;
        }
    }
}
