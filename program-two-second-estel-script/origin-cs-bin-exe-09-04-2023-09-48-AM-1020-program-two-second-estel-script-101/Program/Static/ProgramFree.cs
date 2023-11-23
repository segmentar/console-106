using Core;

namespace Core
{
    using System;

    using System.IO;

    internal partial class Program
    {
        internal static void Free()
        {
            foreach (String name in Enum.GetNames(typeof(ProgramCode.SpecialDirectory)))
            {
                var path_DIRECTORY_full_name = Path.Combine(Directory.GetCurrentDirectory(), name);

                if (Directory.Exists(path_DIRECTORY_full_name) is false)
                {
                    continue;
                }
                else
                    "false".ToString();

                Directory.Delete(path_DIRECTORY_full_name, true);

                continue;
            }

            return;
        }
    }
}
