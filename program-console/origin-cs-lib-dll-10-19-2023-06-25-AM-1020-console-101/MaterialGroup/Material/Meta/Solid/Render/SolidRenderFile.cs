using Core;

namespace Core
{
    using System;

    using System.IO;

    internal partial class Material
    {
        internal static String SolidRenderFile(String Path_ITEM, String Name_ITEM, String Value_ITEM, Boolean answer_CREATE_should)
        {
            String stringResult = default;

            var path_FILE_filename = Path.Combine(Path_ITEM, Name_ITEM);

            var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, "txt");

            var boolean_CREATE_should = true;

            boolean_CREATE_should = boolean_CREATE_should && answer_CREATE_should is true;

            boolean_CREATE_should = boolean_CREATE_should && File.Exists(path_FILE_filename_with_extension) is false;

            Boolean shouldCreateCheck;

            shouldCreateCheck = boolean_CREATE_should is true;

            if (shouldCreateCheck is true)
            {
                StreamWriter streamWriter;

                streamWriter = File.CreateText(path_FILE_filename_with_extension);

                using (streamWriter)
                {
                    streamWriter.Write(Value_ITEM);

                    streamWriter.Flush();

                    streamWriter.Close();

                    streamWriter.Dispose();
                }
            }
            else
                "false".ToString();

            var result = path_FILE_filename_with_extension;

            stringResult = result;

            return stringResult;
        }
    }
}
