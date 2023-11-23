using Core;

namespace Core.DimensionTwoSecondSecondaryII.Interop
{
    using System;

    using System.IO;

    public partial class InteropSpecialize
    {
        public static void SetOutputDirectory(String OutputDirectory_VALUE, Boolean OutputDirectoryhas__ANSWER)
        {
            InteropArchitecture.OutputDirectory = OutputDirectory_VALUE;

            InteropArchitecture.HasOutputDirectory = OutputDirectoryhas__ANSWER;

            if (Directory.Exists(OutputDirectory_VALUE))
            {
                InteropArchitecture.HasValidOutputDirectory = true;
            }
            else
            {
                InteropArchitecture.HasValidOutputDirectory = false;
            }

            return;
        }
    }
}
