using Core;

namespace Core.DimensionTwoSecondSecondaryII.Interop
{
    using System;

    using System.IO;

    public partial class InteropSpecialize
    {
        public static void SetStudioDirectory(String StudioDirectory__VALUE, Boolean InputDirectoryhas__ANSWER)
        {
            InteropArchitecture.StudioDirectory = StudioDirectory__VALUE;

            InteropArchitecture.HasStudioDirectory = InputDirectoryhas__ANSWER;

            if (Directory.Exists(StudioDirectory__VALUE))
            {
                InteropArchitecture.HasValidStudioDirectory = true;
            }
            else
            {
                InteropArchitecture.HasValidStudioDirectory = false;
            }

            return;
        }
    }
}
