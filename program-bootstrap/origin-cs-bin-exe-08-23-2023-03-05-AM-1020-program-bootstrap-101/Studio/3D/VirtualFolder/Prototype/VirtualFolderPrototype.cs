using Core;

namespace Core.DimensionThreeThird
{
    using System;

    using System.Collections;

    public partial class VirtualFolder
    {
        public VirtualFolder(String fullName, ArrayList filesystemEntryArrayList, Boolean debug)
        {
            this.FullName = fullName;

            this.FilesystemEntryArrayList = filesystemEntryArrayList;

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
