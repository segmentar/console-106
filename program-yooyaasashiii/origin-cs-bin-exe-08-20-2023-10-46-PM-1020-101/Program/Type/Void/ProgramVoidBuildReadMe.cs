using Core;

namespace Core
{
    using System;

    using System.IO;

    internal partial class Program
    {
        internal static void ProgramBuildReadMeVoid(String originDirectory)
        {
            var descriptor_README = String.Join('\n'.ToString(), new String[] {
                String.Empty,
                String.Empty + '\t' + "Remember to put AppConfig in Studio 4D" + ' ' + '.',
                String.Empty,
                String.Empty + '\t' + "Remember to make yourself a personalized icon" + ' ' + '.',
                String.Empty
            });

            var path_NAME__README = "ReadMe";

            var path_FILE_filename__README = Path.Combine(originDirectory, path_NAME__README);

            var path_FILE_filename_with_extension__README = Path.ChangeExtension(path_FILE_filename__README, "txt");

            File.WriteAllText(path_FILE_filename_with_extension__README, descriptor_README);

            return;
        }
    }
}
