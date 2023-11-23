using Core;

namespace Core.DimensionTwoSecond
{
    using System;

    public partial class Specialize
    {
        public static void SetStudioType(String studioType)
        {
            switch (studioType)
            {
                case nameof(ProgramCode.StudioType.IncludeStudioDirectory):
                    ArchitectureTwoSecond.StudioType = ProgramCode.StudioType.IncludeStudioDirectory;
                    break;

                case nameof(ProgramCode.StudioType.IncludeStudioDirectoryWithInterop):
                    ArchitectureTwoSecond.StudioType = ProgramCode.StudioType.IncludeStudioDirectoryWithInterop;
                    break;

                default:
                    break;
            }

            return;
        }
    }
}
