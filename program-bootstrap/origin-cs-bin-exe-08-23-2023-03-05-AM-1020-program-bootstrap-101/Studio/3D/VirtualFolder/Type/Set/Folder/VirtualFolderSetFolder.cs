using Core;

namespace Core.DimensionThreeThird
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class VirtualFolder
    {
        public static IList<VirtualFolder> VirtualFolderFolderSet(VirtualFolder item__VIRTAUL_FOLDER)
        {
            ICollection<VirtualFolder> collectionResult = default;

            collectionResult = new Collection<VirtualFolder>();

            foreach (Object objectItem in item__VIRTAUL_FOLDER.FilesystemEntryArrayList)
            {
                Boolean isVirtualFolderCheck, shouldContinueCheck;

                isVirtualFolderCheck = objectItem is VirtualFolder;

                shouldContinueCheck = isVirtualFolderCheck is false;

                if (shouldContinueCheck is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                VirtualFolder virtaulFolder;

                virtaulFolder = objectItem as VirtualFolder;

                collectionResult.Add(virtaulFolder);

                continue;
            }

            return new List<VirtualFolder>(collectionResult);
        }
    }
}
