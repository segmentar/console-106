﻿using Core;

namespace Core.DimensionThreeThird
{
    using System;

    using System.Collections;

    public partial class VirtualFolder
    {
        public static VirtualFolder MakeVirtualFolderDefaultSurface(String fullName, IEnumerable enumerable)
        {
            VirtualFolder virtualFolderResult = default;

            virtualFolderResult = MakeVirtualFolderDefault(fullName, enumerable, VirtualFolderPolicy.VirtualFolderDebugPolicy);

            return virtualFolderResult;
        }
    }
}
