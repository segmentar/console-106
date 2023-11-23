using Core;

using Core.DimensionTwoSecond;

namespace Core.DimensionThreeThird
{
    using System;

    using System.IO;

    using System.Text;

    public partial class VirtualFilesystem
    {
        public static VirtualFile AddFile(VirtualFolder item__VIRTUAL_FOLDER, String item_NAME, String item_EXTENSION, String item_CONTENT)
        {
            VirtualFile virtualFileResult = default;

            var path_FILE_filename = Path.Combine(item__VIRTUAL_FOLDER.FullName, item_NAME);

            var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, item_EXTENSION);

            Encoding encoding;

            if (ArchitectureTwoSecond.HasVirtualFilesystem)
            {
                encoding = Specialize.GetVirtualFilesystemInstance().VirtualFileEncoding;
            }
            else
            {
                encoding = Encoding.Default;
            }

            VirtualFile virtualFile;

            virtualFile = new VirtualFileSimple(path_FILE_filename_with_extension, item_CONTENT, encoding).Result;

            item__VIRTUAL_FOLDER.FilesystemEntryArrayList.Add(virtualFile);

            virtualFileResult = virtualFile;

            return virtualFileResult;
        }
    }
}
