using Core;

namespace Core
{
    using System;

    using System.IO;

    internal partial class Program
    {
        internal static void ProgramBuildVoid(String workingDirectory)
        {
            var path_NAME__ORIGIN = $"origin-cs-bin-exe-{DateTime.Now.ToString("MM")}-{DateTime.Now.ToString("dd")}-{DateTime.Now.ToString("yyyy")}-{DateTime.Now.ToString("hh")}-{DateTime.Now.ToString("mm")}-{DateTime.Now.ToString("tt")}-1020-101";

            var path_DIRECTORY_full_name__ORIGIN = Path.Combine(workingDirectory, path_NAME__ORIGIN);

            Directory.CreateDirectory(path_DIRECTORY_full_name__ORIGIN);

            ProgramBuildReadMeVoid(path_DIRECTORY_full_name__ORIGIN);

            ProgramBuildStudioVoid(path_DIRECTORY_full_name__ORIGIN);

            ProgramBuildProgramVoid(path_DIRECTORY_full_name__ORIGIN);

            return;
        }
    }
}
