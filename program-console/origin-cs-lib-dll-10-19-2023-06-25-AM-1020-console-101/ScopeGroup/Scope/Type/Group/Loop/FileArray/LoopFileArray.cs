using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void LoopFileArray()
        {
            try
            {
                do
                {
                    EndOfFileArrayCheck();

                    if (MeasureFlag.EndOfFileArrayFlag is true)
                    {
                        EndOfFileArraySync();

                        break;
                    }
                    else
                        "false".ToString();

                    FileArrayHandle();

                    AdvanceFilePointer();

                    continue;

                } while (true);

            } catch (Exception exception)
            {
                ScopeFatal.Action(new ScopeFatalLoopFileArray().Initialize(new String[0], exception));
            }

            return;
        }
    }
}
