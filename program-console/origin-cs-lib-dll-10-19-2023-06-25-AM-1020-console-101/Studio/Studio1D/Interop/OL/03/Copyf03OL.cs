using Core;

using Core.DimensionTwoSecondSecondaryII.Interop;

namespace Core
{
    using System;

    using System.IO;

    public partial class Interop
    {
        public static void Copyf03L(String[] array_FILE)
        {
            Boolean isDefaultCheck, shouldReturnCheck;

            isDefaultCheck = (InteropSpecialize.GetOutputDirectory() == default) is true;

            shouldReturnCheck = isDefaultCheck is true;

            if (shouldReturnCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            foreach (var item_FILE in array_FILE)
            {
                var path_NAME_file = Path.GetFileName(item_FILE);

                var path_FILE_filename_with_extension = Path.Combine(InteropArchitecture.OutputDirectory, path_NAME_file);

                File.Copy(item_FILE, path_FILE_filename_with_extension, true);

                continue;
            }
            
            return;
        }
    } 
}
