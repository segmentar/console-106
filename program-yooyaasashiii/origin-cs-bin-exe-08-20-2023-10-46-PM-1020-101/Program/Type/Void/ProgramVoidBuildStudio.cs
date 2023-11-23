using Core;

namespace Core
{
    using System;

    using System.IO;

    internal partial class Program
    {
        internal static void ProgramBuildStudioVoid(String originDirectory)
        {
            var path_NAME__STUDIO = "Studio";

            var path_NAME__1D = "1D";

            var path_NAME__2D = "2D";

            var path_NAME__3D = "3D";

            var path_NAME__4D = "4D";

            var path_DIRECTORY_full_name__STUDIO = Path.Combine(originDirectory, path_NAME__STUDIO);

            var path_DIRECTORY_full_name__STUDIO__1D = Path.Combine(path_DIRECTORY_full_name__STUDIO, path_NAME__1D);

            var path_DIRECTORY_full_name__STUDIO__2D = Path.Combine(path_DIRECTORY_full_name__STUDIO, path_NAME__2D);

            var path_DIRECTORY_full_name__STUDIO__3D = Path.Combine(path_DIRECTORY_full_name__STUDIO, path_NAME__3D);

            var path_DIRECTORY_full_name__STUDIO__4D = Path.Combine(path_DIRECTORY_full_name__STUDIO, path_NAME__4D);

            Directory.CreateDirectory(path_DIRECTORY_full_name__STUDIO);

            Directory.CreateDirectory(path_DIRECTORY_full_name__STUDIO__1D);

            Directory.CreateDirectory(path_DIRECTORY_full_name__STUDIO__2D);

            Directory.CreateDirectory(path_DIRECTORY_full_name__STUDIO__3D);

            Directory.CreateDirectory(path_DIRECTORY_full_name__STUDIO__4D);

            return;
        }
    }
}
