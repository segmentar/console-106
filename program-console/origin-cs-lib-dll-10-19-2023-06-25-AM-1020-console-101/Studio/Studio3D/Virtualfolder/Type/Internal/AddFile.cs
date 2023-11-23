using Core;

using Core.Shared;

namespace Core.Shared
{
    using System;

    using System.IO;

    using System.Text;

    public partial class VirtualFolder
    {
        public Virtualfile AddFile(String name, String extension, String content)
        {
            Virtualfile virtualFileResult = default;

            var path_FILE_filename = Path.Combine(FullName, name);

            var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, extension);

            Encoding encoding = default;

            if (VirtualFilesystem.Instance == default)
            {
                encoding = Encoding.Default;
            }
            else
            {
                encoding = VirtualFilesystem.Instance.VirtualFileEncoding;
            }

            Virtualfile virtualFile;

            virtualFile = new VirtualFileSimple(path_FILE_filename_with_extension, content, encoding).Result;

            FilesystemEntryArrayList.Add(virtualFile);

            virtualFileResult = virtualFile;

            return virtualFileResult;
        }
    }
}
