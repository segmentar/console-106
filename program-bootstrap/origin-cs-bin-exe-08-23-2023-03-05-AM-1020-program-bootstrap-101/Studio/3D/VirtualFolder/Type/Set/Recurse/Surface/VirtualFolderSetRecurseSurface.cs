using Core;

namespace Core.DimensionThreeThird
{
    using System;

    public partial class VirtualFolder
    {
        public static VirtualFolder[] VirtualFolderRecurseSetSurface(Int32 index, VirtualFolder virtualFolder)
        {
            VirtualFolder[] arrayResult = default;

            var list = VirtualFolderRecurseSet(virtualFolder);

            VirtualFolder[] virtualFolderArray;

            virtualFolderArray = new VirtualFolder[list.Count];

            list.CopyTo(virtualFolderArray, index);

            arrayResult = virtualFolderArray;

            return arrayResult;
        }
    }
}
