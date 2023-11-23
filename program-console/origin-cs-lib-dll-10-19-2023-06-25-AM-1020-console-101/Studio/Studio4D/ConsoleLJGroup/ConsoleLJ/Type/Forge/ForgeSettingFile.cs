using Core;

namespace Core
{
    using System;
 
    using System.IO;

    public partial class ConsoleLJ
    {
        public static Tuple<String, String, Boolean, InteropStartInfo> ForgeSettingFile__PATH_TEXT_HAS_INTEROP_START_INFO(String item__SETTING_NAME, String item__SETTING_EXTENSION, Boolean answer_CREATE_should)
        {
            Tuple<String, String, Boolean, InteropStartInfo> tupleResult = default;

            var path_FILE_filename = Path.Combine(Directory.GetCurrentDirectory(), item__SETTING_NAME);

            var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, item__SETTING_EXTENSION);

            var boolean_match_CREATE_should = true;

            boolean_match_CREATE_should = boolean_match_CREATE_should && answer_CREATE_should is true;

            boolean_match_CREATE_should = boolean_match_CREATE_should && File.Exists(path_FILE_filename_with_extension) is false;

            Boolean shouldCreateCheck;

            shouldCreateCheck = boolean_match_CREATE_should is true;

            if (shouldCreateCheck is true)
            {
                StreamWriter streamWriter;

                streamWriter = File.CreateText(path_FILE_filename_with_extension);

                using (streamWriter)
                {
                    streamWriter.Flush();

                    streamWriter.Close();

                    streamWriter.Dispose();
                }
            }
            else
                "false".ToString();

            var text = File.ReadAllText(path_FILE_filename_with_extension);

            Boolean hasSignatureCheck;

            hasSignatureCheck = text.Contains("secret") is true;

            InteropStartInfo interopStartInfo;

            interopStartInfo = default;

            if (hasSignatureCheck is true)
            {
                var line_feed = Convert.ToChar(10);

                var split = text.Split(new String[] { line_feed.ToString() }, StringSplitOptions.None);

                var second = split[1];

                var third = split[2];

                var fourth = split[3];

                var fifth = split[4];

                String escape, terminator, native, shared;

                escape = second;

                terminator = third;

                native = fourth;

                shared = fifth;

                var oth_ESCAPE = escape[0];

                var oth_TERMINATOR = terminator[0];

                String nativeFormat, sharedFormat;

                nativeFormat = native.TrimEnd();

                sharedFormat = shared.TrimEnd();

                Char escapeCharacter, terminatorCharacter;

                escapeCharacter = oth_ESCAPE;

                terminatorCharacter = oth_TERMINATOR;

                interopStartInfo = new InteropStartInfo(escapeCharacter, terminatorCharacter, nativeFormat, sharedFormat);
            }
            else
                "false".ToString();

            var path = path_FILE_filename_with_extension;

            Tuple<String, String, Boolean, InteropStartInfo> tuple;

            tuple = new Tuple<String, String, Boolean, InteropStartInfo>(path, text, hasSignatureCheck, interopStartInfo);

            tupleResult = tuple;

            return tupleResult;
        }
    }
}
