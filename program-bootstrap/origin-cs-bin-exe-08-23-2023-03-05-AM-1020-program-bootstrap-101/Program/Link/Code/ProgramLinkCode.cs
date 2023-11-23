using Core;

namespace Core
{
    using System;

    internal partial class ProgramCode
    {
        internal enum ApplicationType
        {
            Unset,
            BinaryPortableExecutable,
            LibraryDynamicLinkLibrary
        }

        internal enum StudioType
        {
            Unset,
            IncludeStudioDirectory,
            IncludeStudioDirectoryWithInterop
        }
    }
}
