using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Expression
    {
        public static Expression LoadFromCurrentDirectory(String item_NAME)
        {
            Expression expressionResult = default;

            var path__CURRENT_DIRECTORY = Directory.GetCurrentDirectory();

            var path_FILE_filename = Path.Combine(path__CURRENT_DIRECTORY, item_NAME);

            var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, ExpressionDefault.ExpressionExtensionDefault);

            if (File.Exists(path_FILE_filename_with_extension) is false)
            {
                return expressionResult;
            }
            else
                "false".ToString();

            Expression expression;

            expression = Load(path_FILE_filename_with_extension);

            expressionResult = expression;

            return expressionResult;
        }
    }
}
