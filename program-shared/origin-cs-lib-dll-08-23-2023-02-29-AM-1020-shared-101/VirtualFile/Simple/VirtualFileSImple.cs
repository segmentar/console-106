using Core.Shared;

namespace Core.Shared
{
    using System;

    using System.IO;

    using System.Text;

    public partial class VirtualFileSimple
    {
        public VirtualFile Result { get; set; } = default;

        public VirtualFileSimple(String filename, String content, Encoding encoding)
        {
            Byte[] byteArray;

            byteArray = encoding.GetBytes(content);

            var result = VirtualFile.MakeVirtualFileDefaultSurface(filename, byteArray);

            this.Result = result;

            return;
        }

        ~VirtualFileSimple()
        {
            return;
        }
    }
}
