using Core;

namespace Core.DimensionTwoSecondSecondaryII.Interop
{
    using System;

    using System.IO;

    public partial class InteropSpecialize
    {
        public static void SetInputDirectory(String InputDirectory__VALUE, Boolean InputDirectoryhas__ANSWER)
        {
            InteropArchitecture.InputDirectory = InputDirectory__VALUE;

            InteropArchitecture.HasInputDirectory = InputDirectoryhas__ANSWER;

            if (Directory.Exists(InputDirectory__VALUE))
            {
                InteropArchitecture.HasValidInputDirectory = true;
            }
            else
            {
                InteropArchitecture.HasValidInputDirectory = false;
            }

            return;
        }
    }
}
