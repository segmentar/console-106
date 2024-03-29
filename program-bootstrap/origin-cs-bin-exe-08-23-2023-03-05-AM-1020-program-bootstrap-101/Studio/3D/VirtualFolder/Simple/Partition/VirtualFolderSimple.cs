﻿using Core;

namespace Core.DimensionThreeThird
{
    using System;

    public partial class VirtualFolderSimple
    {
        public VirtualFolder Result { get; set; } = default;

        public VirtualFolderSimple()
        {
            return;
        }

        ~VirtualFolderSimple()
        {
            return;
        }
    }
}

namespace Core.DimensionThreeThird
{
    using System;

    using System.Collections;

    public partial class VirtualFolderSimple
    {
        public VirtualFolderSimple(String fullName, params Object[] array__FILESYSTEM_ENTRY)
        {
            var list = new ArrayList();

            foreach (Object objectItem in array__FILESYSTEM_ENTRY)
            {
                var match_FILESYSTEM_ENTRY_is = false;

                match_FILESYSTEM_ENTRY_is = match_FILESYSTEM_ENTRY_is || objectItem is VirtualFile;

                match_FILESYSTEM_ENTRY_is = match_FILESYSTEM_ENTRY_is || objectItem is VirtualFolder;

                Boolean shouldContinueCheck;

                shouldContinueCheck = match_FILESYSTEM_ENTRY_is is false;

                if (shouldContinueCheck is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                list.Add(objectItem);

                continue;
            }

            var result = VirtualFolder.MakeVirtualFolderDefaultSurface(fullName, list);

            this.Result = result;

            return;
        }
    }
}


namespace Core.DimensionThreeThird
{
    using System;

    using System.IO;

    using System.Reflection;

    public partial class VirtualFolderSimple
    {
        public VirtualFolderSimple(params Object[] array__FILESYSTEM_ENTRY)
        {
            var path_FILE_filename_with_extension__ENTRY = Assembly.GetEntryAssembly().Location;

            var path_DIRECTORY_full_name__ENTRY = Path.GetDirectoryName(path_FILE_filename_with_extension__ENTRY);

            var result = new VirtualFolderSimple(path_DIRECTORY_full_name__ENTRY, array__FILESYSTEM_ENTRY).Result;

            this.Result = result;

            return;
        }
    }
}