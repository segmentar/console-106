﻿using Core;

namespace Core.DimensionThreeThird
{
    using System;

    using System.Text;

    public partial class VirtualFilesystem
    {
        public VirtualFilesystem(Encoding virtualFileEncoding, VirtualFolder virtualFolderRoot, Boolean debug)
        {
            this.VirtualFileEncoding = virtualFileEncoding;

            this.VirtualFolderRoot = virtualFolderRoot;

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
