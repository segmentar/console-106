using Core;

namespace Core.DimensionThreeThird
{
    using System;

    public partial class VirtualFolder
    {
        public static VirtualFile[] VirtualFolderFileSetSurface(Int32 index, VirtualFolder item__VIRTUAL_FOLDER)
        {
            VirtualFile[] arrayResult = default;

            var list = VirtualFolderFileSet(item__VIRTUAL_FOLDER);

            VirtualFile[] virtualFileArray;

            virtualFileArray = new VirtualFile[list.Count];

            list.CopyTo(virtualFileArray, index);   

            arrayResult = virtualFileArray;

            return arrayResult;
        }
    }
}
