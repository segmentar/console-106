using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Expression
    {
        public static void SaveToCurrentDirectory(String item_NAME, Expression item_EXPRESSION)
        {
            var path__CURRENT_DIRECTORY = Directory.GetCurrentDirectory();

            var path_FILE_filename = Path.Combine(path__CURRENT_DIRECTORY, item_NAME);

            var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, ExpressionDefault.ExpressionExtensionDefault);

            Save(path_FILE_filename_with_extension, item_EXPRESSION);

            return;
        }
    }
}
