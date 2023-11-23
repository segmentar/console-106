using Core;

using Core.DimensionTwoSecondSecondaryII.Interop;

namespace Core
{
    using System;

    using System.IO;

    public partial class Interop
    {
        public static void Debf05IL()
        {
            var DisplayArgument__ENTITY = "display-argument";

            if (InteropArchitecture.ArgumentList.Contains(DisplayArgument__ENTITY) is false)
            {
                return;
            }
            else
                "false".ToString();

            var Entity_COMMA = Convert.ToChar(44);

            var separator = Entity_COMMA.ToString();

            var join = String.Join(separator, InteropArchitecture.ArgumentArray);

            var path_NAME_file = "DisplayArgument";

            var path_EXTENSION_text = "txt";

            var path_FILE_filename = Path.Combine(Directory.GetCurrentDirectory(), path_NAME_file);

            var path_FILE_filename_wtih_extension = Path.ChangeExtension(path_FILE_filename, path_EXTENSION_text);

            if (File.Exists(path_FILE_filename_wtih_extension) is true)
            {
                File.Delete(path_FILE_filename_wtih_extension);
            }
            else
                "false".ToString();

            File.WriteAllText(path_FILE_filename_wtih_extension, join);

            return;
        }
    }
}
