using Core;

namespace Core.DimensionThreeThird
{
    using System;

    using System.Collections;

    public partial class VirtualFolder
    {
        public static VirtualFolder MakeVirtualFolderDefault(String fullName, IEnumerable enumerable, Boolean debug)
        {
            VirtualFolder virtualFolderResult = default;

            var result = new VirtualFolderSequence(fullName, enumerable, debug).Result;

            VirtualFolderPolicy.VirtualFolderArrayList.Add(result);

            virtualFolderResult = result;

            return virtualFolderResult;
        }
    }
}
