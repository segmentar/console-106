using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Scope
    {
        public static void DirectionForward()
        {
            var aoth = MeasureWait.LinkedList.Count;

            var roth = (aoth - 1);

            Boolean shouldReturnCheck;

            shouldReturnCheck = MeasureWait.LinkedListPointer.Equals(roth) is true;

            if (shouldReturnCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            MeasureWait.LinkedListPointer = MeasureWait.LinkedListPointer + 1;

            var node = new ArrayList(MeasureWait.LinkedList)[MeasureWait.LinkedListPointer];

            var reflect = (ScopeTransaction)(node as Object);

            reflect.Sync();

            return;
        }
    }
}
