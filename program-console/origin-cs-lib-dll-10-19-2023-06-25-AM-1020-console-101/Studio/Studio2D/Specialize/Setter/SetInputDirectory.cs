using Core;

using Core.DimensionTwoSecondSecondaryII.ConsoleLJ;

namespace Core
{
    using System;

    using System.IO;

    public partial class SpecializeConsoleLJ
    {
        public static void SetInputDirectory(String inputDirectory, Boolean hasInputDirectory)
        {
            ArchitectureConsoleLJOneFirst.InputDirectory = inputDirectory;

            ArchitectureConsoleLJOneFirst.HasInputDirectory = hasInputDirectory;

            if (Directory.Exists(inputDirectory))
            {
                ArchitectureConsoleLJOneFirst.HasValidInputDirectory = true;
            }
            else
            {
                ArchitectureConsoleLJOneFirst.HasValidInputDirectory = false;
            }

            return;
        }
    }
}
