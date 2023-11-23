using Core;

namespace Core
{
    using System;

    using System.Diagnostics;

    public partial class Scope
    {
        public static void Explorer(Int32 ordinal, String Path_VALUE)
        {
            Boolean isMorethanCheck, shouldReturnCheck;

            isMorethanCheck = (ordinal > 5) is true;

            shouldReturnCheck = isMorethanCheck is true;

            if (shouldReturnCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            var Entity_EXPLORER = "explorer";

            ProcessStartInfo processStartInfo;

            processStartInfo = new ProcessStartInfo(Entity_EXPLORER, Path_VALUE);

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

                    Explorer(next, Path_VALUE);
                }

            skip:
                {
                    process.Close();

                    process.Dispose();
                }
            }

            return;
        }
    }
}
