using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Reflection;

    using System.Diagnostics;

    internal partial class Program
    {
        internal static Tuple<String, String> ForgeCurrentTuple__FILE_DIRECTORY(Boolean reflect)
        {
            Tuple<String, String> tupleResult = default;

            String filename, directory;

            if (reflect)
            {
                var path_FILE_filename_with_extension = Assembly.GetExecutingAssembly().Location;

                filename = path_FILE_filename_with_extension;
            }
            else
            {
                var path_FILE_filename_with_extension = Process.GetCurrentProcess().MainModule.FileName;

                filename = path_FILE_filename_with_extension;
            }

            if (reflect)
            {
                var path_DIRECTORY_full_name = Directory.GetCurrentDirectory();

                directory = path_DIRECTORY_full_name;
            }
            else
            {
                var path_DIRECTORY_full_name = Path.GetDirectoryName(filename);

                directory = path_DIRECTORY_full_name;
            }

            Tuple<String, String> tuple;

            tuple = new Tuple<String, String>(filename, directory);

            tupleResult = tuple;

            return tupleResult;
        }
    }
}
