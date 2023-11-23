using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void DirectionStart()
        {
            while (true)
            {
                Boolean shouldBreakCheck;

                shouldBreakCheck = MeasureWait.LinkedListPointer.Equals(0) is true;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                DirectionBackward();

                continue;
            }

            return;
        }
    }
}
