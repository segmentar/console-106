using Core;

namespace Core.DimensionTwoSecondSecondaryII.Interop
{
    using System;

    using System.IO;

    using System.Reflection;

    public partial class InteropSpecialize
    {
        public static String GetStudioDirectory(Boolean answer_SYNC_should)
        {
            String stringResult = default;

            if (answer_SYNC_should is true)
            {
                var path_NAME_file = "Studio";

                var path_EXTENSION_text = "txt";

                var ExecutingAssembly__PATH = Assembly.GetExecutingAssembly().Location;

                var ExecutingAssemblyparent__PATH = Path.GetDirectoryName(ExecutingAssembly__PATH);

                var path_FILE_filename = Path.Combine(ExecutingAssemblyparent__PATH, path_NAME_file);

                var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, path_EXTENSION_text);

                if (File.Exists(path_FILE_filename_with_extension) is true)
                {
                    var text = File.ReadAllText(path_FILE_filename_with_extension);

                    SetStudioDirectory(text, true);
                }
                else
                    "false".ToString();
            }
            else
                "false".ToString();

            var boolean_safe_RETURN_should = false;

            boolean_safe_RETURN_should = boolean_safe_RETURN_should || InteropArchitecture.HasStudioDirectory is false;

            boolean_safe_RETURN_should = boolean_safe_RETURN_should || InteropArchitecture.HasValidStudioDirectory is false;

            Boolean shouldReturnCheck;

            shouldReturnCheck = boolean_safe_RETURN_should is true;

            if (shouldReturnCheck is true)
            {
                return stringResult;
            }
            else
                "false".ToString();

            var result = InteropArchitecture.StudioDirectory;

            stringResult = result;

            return stringResult;
        }
    }
}
