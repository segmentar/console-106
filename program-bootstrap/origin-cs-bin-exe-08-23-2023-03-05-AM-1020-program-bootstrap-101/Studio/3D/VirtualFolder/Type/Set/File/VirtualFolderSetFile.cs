using Core;

namespace Core.DimensionThreeThird
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class VirtualFolder
    {
        public static IList<VirtualFile> VirtualFolderFileSet(VirtualFolder item__VIRTAUL_FOLDER)
        {
            ICollection<VirtualFile> collectionResult = default;

            collectionResult = new Collection<VirtualFile>();

            foreach (Object objectItem in item__VIRTAUL_FOLDER.FilesystemEntryArrayList)
            {
                Boolean isVirtualFileCheck, shouldContinueCheck;

                isVirtualFileCheck = objectItem is VirtualFile;

                shouldContinueCheck = isVirtualFileCheck is false;

                if (shouldContinueCheck is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                VirtualFile virtualFile;

                virtualFile = objectItem as VirtualFile;

                collectionResult.Add(virtualFile);

                continue;
            }

            return new List<VirtualFile>(collectionResult);
        }
    }
}
