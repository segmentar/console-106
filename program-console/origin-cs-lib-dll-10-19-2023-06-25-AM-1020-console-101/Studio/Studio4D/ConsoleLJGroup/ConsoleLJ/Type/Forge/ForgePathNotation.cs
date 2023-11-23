using Core;

using Core.DimensionTwoSecondSecondaryII.ConsoleLJ;

namespace Core
{
    using System;

    using System.IO;

    using System.Reflection;

    public partial class ConsoleLJ
    {
        public static String ForgePathNotation(String item_PATH)
        {
            String stringResult = default;

            var path_NAME_filesystem_entry = String.Empty;

            var split = item_PATH.Split(new String[] { Path.DirectorySeparatorChar.ToString() }, StringSplitOptions.None);

            foreach (String stringItem in split)
            {
                if (stringItem.Equals(ImmutableConsoleLJZeroTen.NotationDirectory) is true)
                {
                    path_NAME_filesystem_entry = Directory.GetCurrentDirectory();
                }
                else if (stringItem.Equals(ImmutableConsoleLJZeroTen.NotationBack) is true)
                {
                    path_NAME_filesystem_entry = Path.GetDirectoryName(path_NAME_filesystem_entry);
                }
                else if (stringItem.Equals(ImmutableConsoleLJZeroTen.NotationFile) is true)
                {
                    path_NAME_filesystem_entry = Assembly.GetEntryAssembly().Location;
                }
                else
                {
                    path_NAME_filesystem_entry = Path.Combine(path_NAME_filesystem_entry, stringItem);
                }

                continue;
            }

            var result = path_NAME_filesystem_entry;

            stringResult = result;

            return stringResult;
        }
    }
}
