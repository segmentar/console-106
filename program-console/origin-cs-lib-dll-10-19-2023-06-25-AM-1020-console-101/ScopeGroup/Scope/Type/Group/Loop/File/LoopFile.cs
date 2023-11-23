using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void LoopFile()
        {
            try
            {
                ResetFileCategory();

                do
                {
                    EndOfFileCheck();

                    if (MeasureFlag.EndOfFileFlag is true)
                    {
                        EndOfFileSync();

                        break;
                    }
                    else
                        "false".ToString();

                    FileHandle();

                    AdvancePhysicalOffset();

                    continue;

                } while (true);

            } catch (Exception exception)
            {
                ScopeFatal.Action(new ScopeFatalLoopFile().Initialize(new String[0], exception));
            }

            return;
        }
    }
}
