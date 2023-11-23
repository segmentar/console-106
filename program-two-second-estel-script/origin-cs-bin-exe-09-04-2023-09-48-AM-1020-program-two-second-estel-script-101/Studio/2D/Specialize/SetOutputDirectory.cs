using Core;

namespace Core
{
    using System;

    public partial class Specialize
    {
        public static void SetOutputDirectory(String outputDirectory, Boolean hasOutputDirectory)
        {
            ArchitecturePageOneFirst.OutputDirectory = outputDirectory;

            ArchitecturePageOneFirst.HasOutputDirectory = hasOutputDirectory;

            return;
        }
    }
}
