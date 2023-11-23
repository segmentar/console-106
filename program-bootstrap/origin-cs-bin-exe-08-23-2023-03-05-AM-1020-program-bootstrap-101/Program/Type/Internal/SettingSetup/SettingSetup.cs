using Core;

using Core.DimensionTwoSecond;

namespace Core
{
    using System;

    using System.IO;

    internal partial class Program
    {
        internal void SettingSetup()
        {
            var path_FILE_filename = Path.Combine(Directory.GetCurrentDirectory(), ImmutableOneFirst.SettingName);

            var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, ImmutableOneFirst.SettingExtension);

            if (File.Exists(path_FILE_filename_with_extension))
            {
                var text = File.ReadAllText(path_FILE_filename_with_extension);

                foreach (Tuple<String, String> tuple in ProgramSettingSetupContainerSurface__NAME_VALUE<Tuple<String, String>>(text))
                {
                    String name, value;

                    name = tuple.Item1;

                    value = tuple.Item2;

                    ProgramBindNameValueVoid(name, value);

                    continue;
                }
            }
            else
            {
                StreamWriter streamWriter;

                streamWriter = File.CreateText(path_FILE_filename_with_extension);

                using (streamWriter)
                {
                    streamWriter.Write(ArchitectureOneFirst.NativeString);

                    streamWriter.Flush();

                    streamWriter.Close();

                    streamWriter.Dispose();
                }
            }

            return;
        }
    }
}
