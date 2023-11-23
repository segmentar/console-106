using Core;

namespace Core
{
    using System;

    public partial class Specialize
    {
        public static void SetInputDirectory(String inputDirectory, Boolean hasInputDirectory)
        {
            ArchitecturePageOneFirst.InputDirectory = inputDirectory;

            ArchitecturePageOneFirst.HasInputDirectory = hasInputDirectory;

            return;
        }
    }
}
