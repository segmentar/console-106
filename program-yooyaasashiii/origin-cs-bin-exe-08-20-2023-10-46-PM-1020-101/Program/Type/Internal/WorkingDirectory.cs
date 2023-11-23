using Core;

namespace Core
{
    using System;

    using System.IO;

    internal partial class Program
    {
        internal DirectoryInfo WorkingDirectory(String currentDirectory)
        {
            DirectoryInfo directoryInfoResult = default;

            var path_DIRECTORY_full_name = Path.Combine(currentDirectory, Immutable.WorkingDirectoryName);

            if (Directory.Exists(path_DIRECTORY_full_name) is false)
            {
                DirectoryInfo directoryInfo;

                directoryInfo = Directory.CreateDirectory(path_DIRECTORY_full_name);

                directoryInfoResult = directoryInfo;
            }
            else
            {
                var info = new DirectoryInfo(path_DIRECTORY_full_name);

                directoryInfoResult = info; 
            }

            return directoryInfoResult;
        }
    }
}
