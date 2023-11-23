using Core;

using Core.DimensionTwoSecondSecondaryII.ConsoleLJ;

namespace Core
{
    using System;

    using System.Diagnostics;

    using System.Reflection;

    public partial class Interop
    {
        public static void Callf01OL(Int32 ordinal, String file, params String[] array_ARGUMENT)
        {
            var boolean_safe_RETURN_should = false;
            
            boolean_safe_RETURN_should = boolean_safe_RETURN_should || (ordinal > 5) is true;

            boolean_safe_RETURN_should = boolean_safe_RETURN_should || ArchitectureConsoleLJOneFirst.HasEscapeCharacter is false;

            boolean_safe_RETURN_should = boolean_safe_RETURN_should || ArchitectureConsoleLJOneFirst.HasNativeString is false;

            boolean_safe_RETURN_should = boolean_safe_RETURN_should || ArchitectureConsoleLJOneFirst.HasSharedString is false;

            Boolean shouldReturnCheck;

            shouldReturnCheck = boolean_safe_RETURN_should is true;

            if (shouldReturnCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            var whitespace = Convert.ToChar(32);

            var join = String.Join(whitespace.ToString(), array_ARGUMENT);

            String fileName, arguments;

            fileName = file;

            arguments = join;

            ProcessStartInfo processStartInfo;

            processStartInfo = new ProcessStartInfo();

            processStartInfo.FileName = fileName;

            processStartInfo.Arguments = arguments;

            Process process;

            process = new Process();

            process.StartInfo = processStartInfo;

            using (process)
            {
                if (process.Start())
                {
                    goto skip;
                }
                else
                {
                    var next = (ordinal + 1);

                    Callf01OL(next, file, array_ARGUMENT);
                }

                skip:
                {
                    process.Close();

                    process.Dispose();
                }
            }

            Boolean isSelfCheck;

            isSelfCheck = Assembly.GetEntryAssembly().Location.Equals(file) is true;

            if (isSelfCheck is true)
            {
                Environment.Exit(0);
            }
            else
                "false".ToString();

            return;
        }
    }
}
