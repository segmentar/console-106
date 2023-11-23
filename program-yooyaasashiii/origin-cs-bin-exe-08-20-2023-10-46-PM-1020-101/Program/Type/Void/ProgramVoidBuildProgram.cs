using Core;

namespace Core
{
    using System;

    using System.IO;

    internal partial class Program
    {
        internal static void ProgramBuildProgramVoid(String originDirectory)
        {
            var descriptor_PROGRAM = String.Join('\n'.ToString(), new String[] {
                String.Empty + "using" + ' ' + "Core" + ';',
                String.Empty,
                String.Empty + "namespace" + ' ' + "Core",
                String.Empty + '{',
                String.Empty + '\t' + "using" + ' ' + "System" + ';',
                String.Empty,
                String.Empty,
                String.Empty + '\t' + "internal partial class Program",
                String.Empty + '\t' + '{',
                String.Empty,
                String.Empty + '\t' + '\t' + "internal Program" + '(' + ')',
                String.Empty + '\t' + '\t' + '{',
                String.Empty + '\t' + '\t' + '\t' + "return" + ';',
                String.Empty + '\t' + '\t' + '}',
                String.Empty,
                String.Empty + '\t' + '\t' + '~' + "Program" + '(' + ')',
                String.Empty + '\t' + '\t' + '{',
                String.Empty + '\t' + '\t' + '\t' + "return" + ';',
                String.Empty + '\t' + '\t' + '}',
                String.Empty + '\t' + '}',
                String.Empty + '}'
            });

            var path_NAME__PROGRAM = "Program";

            var path_DIRECTORY_full_name__PROGRAM = Path.Combine(originDirectory, path_NAME__PROGRAM);

            var path_FILE_filename__PROGRAM = Path.Combine(path_DIRECTORY_full_name__PROGRAM, path_NAME__PROGRAM);

            var path_FILE_filename_with_extension__PROGRAM__MAIN = Path.ChangeExtension(path_FILE_filename__PROGRAM, "cs");

            Directory.CreateDirectory(path_DIRECTORY_full_name__PROGRAM);

            File.WriteAllText(path_FILE_filename_with_extension__PROGRAM__MAIN, descriptor_PROGRAM);

            return;
        }
    }
}
