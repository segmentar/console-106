using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Scope
    {
        public static void DirectionBackward()
        {
            Boolean shouldReturnCheck;

            shouldReturnCheck = MeasureWait.LinkedListPointer.Equals(0) is true;

            if (shouldReturnCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            MeasureWait.LinkedListPointer = MeasureWait.LinkedListPointer - 1;

            var node = new ArrayList(MeasureWait.LinkedList)[MeasureWait.LinkedListPointer];

            var reflect = (ScopeTransaction)(node as Object);

            reflect.Sync();

            return;
        }
    }
}
