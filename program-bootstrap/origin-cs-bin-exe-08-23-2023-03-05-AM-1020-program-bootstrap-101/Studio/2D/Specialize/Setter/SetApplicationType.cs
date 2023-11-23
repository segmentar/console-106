using Core;

namespace Core.DimensionTwoSecond
{
    using System;

    public partial class Specialize
    {
        public static void SetApplicationType(String applicationType)
        {
            switch (applicationType)
            {
                case nameof(ProgramCode.ApplicationType.BinaryPortableExecutable):
                    ArchitectureTwoSecond.ApplicationType = ProgramCode.ApplicationType.BinaryPortableExecutable;
                    break;

                case nameof(ProgramCode.ApplicationType.LibraryDynamicLinkLibrary):
                    ArchitectureTwoSecond.ApplicationType = ProgramCode.ApplicationType.LibraryDynamicLinkLibrary;
                    break;

                default:
                    break;
            }

            return;
        }
    }
}
