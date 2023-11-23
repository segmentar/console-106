using Core;

using Core.Shared;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class VirtualFolder
    {
        public static IList<Virtualfile> VirtualFolderFileSet(VirtualFolder virtualFolder)
        {
            ICollection<Virtualfile> collectionResult = default;

            collectionResult = new Collection<Virtualfile>();

            foreach (Object objectItem in virtualFolder.FilesystemEntryArrayList)
            {
                if ((objectItem is Virtualfile) is false)
                {
                    continue;
                }
                else
                    "false".ToString();

                collectionResult.Add(objectItem as Virtualfile);

                continue;
            }

            return new List<Virtualfile>(collectionResult);
        }
    }
}
