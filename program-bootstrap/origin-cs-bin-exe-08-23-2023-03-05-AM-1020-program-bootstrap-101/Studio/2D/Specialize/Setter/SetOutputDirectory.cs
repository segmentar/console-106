using Core;

namespace Core.DimensionTwoSecond
{
    using System;

    public partial class Specialize
    {
        public static void SetOutputDirectory(String outputDirectory, Boolean hasOutputDirectory)
        {
            ArchitectureOneFirst.OutputDirectory = outputDirectory;

            ArchitectureOneFirst.HasOutputDirectory = hasOutputDirectory;

            return;
        }
    }
}
