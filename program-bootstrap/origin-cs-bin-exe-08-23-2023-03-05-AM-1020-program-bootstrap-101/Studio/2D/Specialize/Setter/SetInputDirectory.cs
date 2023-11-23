using Core;

namespace Core.DimensionTwoSecond
{
    using System;

    public partial class Specialize
    {
        public static void SetInputDirectory(String inputDirectory, Boolean hasInputDirectory)
        {
            ArchitectureOneFirst.InputDirectory = inputDirectory;

            ArchitectureOneFirst.HasInputDirectory = hasInputDirectory;

            return;
        }
    }
}
