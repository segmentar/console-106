using Core;

using Core.Shared;

namespace Core.Shared
{
    using System;

    public partial class VirtualFolder
    {
        public static Virtualfile[] VirtualFolderFileSetSurface(VirtualFolder virtualFolder)
        {
            Virtualfile[] arrayResult = default;

            var list = VirtualFolderFileSet(virtualFolder);

            Virtualfile[] virtualFileArray;

            virtualFileArray = new Virtualfile[list.Count];

            list.CopyTo(virtualFileArray, 0);   

            arrayResult = virtualFileArray;

            return arrayResult;
        }
    }
}
