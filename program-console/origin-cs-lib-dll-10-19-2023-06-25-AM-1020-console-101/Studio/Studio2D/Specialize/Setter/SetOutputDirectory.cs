using Core;

using Core.DimensionTwoSecondSecondaryII.ConsoleLJ;

namespace Core
{
    using System;

    using System.IO;

    public partial class SpecializeConsoleLJ
    {
        public static void SetOutputDirectory(String outputDirectory, Boolean hasOutputDirectory)
        {
            ArchitectureConsoleLJOneFirst.OutputDirectory = outputDirectory;

            ArchitectureConsoleLJOneFirst.HasOutputDirectory = hasOutputDirectory;

            if (Directory.Exists(outputDirectory))
            {
                ArchitectureConsoleLJOneFirst.HasValidOutputDirectory = true;
            }
            else
            {
                ArchitectureConsoleLJOneFirst.HasValidOutputDirectory = false;
            }

            return;
        }
    }
}
