using Core;

namespace Core.DimensionThreeThird
{
    using System;

    public partial class VirtualFile
    {
        public VirtualFile(String filename, Byte[] contentByteArray, Boolean debug)
        {
            this.Filename = filename;

            this.ContentByteArray = contentByteArray;

            if (debug is true)
            {
                this.IsDebug = true;
            }
            else
                "false".ToString();

            return;
        }
    }
}
