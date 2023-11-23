using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Text;

    public partial class Host
    {
        public static void SystemHostAppendText(Expression item_EXPRESSION, String[] String_ARRAY)
        {
            var second = String_ARRAY[0];

            var third = String_ARRAY[1];

            var File_VALUE = item_EXPRESSION.SUPeek(second);

            var Text_VALUE = item_EXPRESSION.SUPeek(third);

            var array = Encoding.Default.GetBytes(Text_VALUE.StringValue);

            FileStream fileStream;

            fileStream = File.OpenWrite(File_VALUE.StringValue);

            using (fileStream)
            {
                fileStream.Seek(0, SeekOrigin.End);

                fileStream.Write(array, 0, array.Length);

                fileStream.Close();

                fileStream.Dispose();
            }

            //ConsoleLJS.Log(false, $"val [{File_VALUE}]");

            /*var fourth = String_ARRAY[2];

            var value = item_EXPRESSION.SUPeek(second);

            var path_FILE_filename = Path.Combine(value.StringValue, third);

            var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, fourth);

            File.Create(path_FILE_filename_with_extension);

            ConsoleLJS.Log(false, $"child [{path_FILE_filename}]");*/
            return;
        }
    }
}
