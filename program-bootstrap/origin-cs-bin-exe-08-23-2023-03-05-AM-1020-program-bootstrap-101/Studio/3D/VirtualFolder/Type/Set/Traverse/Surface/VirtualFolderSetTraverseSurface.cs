using Core;

namespace Core.DimensionThreeThird
{
    using System;

    public partial class VirtualFolder
    {
        public static Object[] VirtualFolderTraverseSetSurface(Int32 index, VirtualFolder[] virtualFolderArray)
        {
            Object[] arrayResult = default;

            var list = VirtualFolderTraverseSet(virtualFolderArray);

            Object[] objectArray;

            objectArray = new Object[list.Count];

            list.CopyTo(objectArray, index);

            arrayResult = objectArray;

            return arrayResult;
        }
    }
}
