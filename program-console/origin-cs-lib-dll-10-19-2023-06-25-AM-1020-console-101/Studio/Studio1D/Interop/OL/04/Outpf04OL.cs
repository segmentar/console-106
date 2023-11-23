using Core;

using Core.DimensionTwoSecondSecondaryII.ConsoleLJ;

using Core.DimensionTwoSecondSecondaryII.Interop;

namespace Core
{
    using System;

    using System.IO;

    public partial class Interop
    {
        public static void Outpf04OL(String[] array_FILE)
        {
            Boolean isDefaultCheck, shouldRetunCheck;

            isDefaultCheck = (InteropSpecialize.GetOutputDirectory() == default) is true;

            shouldRetunCheck = isDefaultCheck is true;

            if (shouldRetunCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            var path_FILE_filename = Path.Combine(ArchitectureConsoleLJOneFirst.OutputDirectory, ImmutableConsoleLJZeroTen.OutputFileName);

            var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, ImmutableConsoleLJZeroTen.OutputExtension);

            if (File.Exists(path_FILE_filename_with_extension) is true)
            {
                File.Delete(path_FILE_filename_with_extension);
            }
            else
                "false".ToString();

            var line_feed = Convert.ToChar(10);

            var join = String.Join(line_feed.ToString(), array_FILE);

            File.WriteAllText(path_FILE_filename_with_extension, join);

            return;
        }
    }
}
