using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void DirectionEnd()
        {
            while (true)
            {
                var aoth = MeasureWait.LinkedList.Count;

                var roth = (aoth - 1);

                Boolean shouldBreakCheck;

                shouldBreakCheck = MeasureWait.LinkedListPointer.Equals(roth) is true;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                DirectionForward();

                continue;
            }

            return;
        }
    }
}
