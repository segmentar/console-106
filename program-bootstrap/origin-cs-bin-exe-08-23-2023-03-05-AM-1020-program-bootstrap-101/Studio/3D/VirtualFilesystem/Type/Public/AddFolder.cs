using Core;

namespace Core.DimensionThreeThird
{
    using System;

    using System.IO;

    public partial class VirtualFilesystem
    {
        public static VirtualFolder AddFolder(VirtualFolder item__VIRTUAL_FOLDER, String item_NAME)
        {
            VirtualFolder virtualFolderResult = default;

            var path_DIRECTORY_full_name = Path.Combine(item__VIRTUAL_FOLDER.FullName, item_NAME);

            VirtualFolder virtualFolder;

            virtualFolder = new VirtualFolderSimple(path_DIRECTORY_full_name).Result;

            item__VIRTUAL_FOLDER.FilesystemEntryArrayList.Add(virtualFolder);

            virtualFolderResult = virtualFolder;

            return virtualFolderResult;
        }
    }
}
