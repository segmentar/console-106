using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void AdvanceLinkedList(ScopeTransaction ScopeTransaction__VALUE)
        {
            MeasureWait.LinkedList.AddLast(ScopeTransaction__VALUE);

            MeasureWait.LinkedListPointer = MeasureWait.LinkedList.Count;

            MeasureWait.LinkedListPointer = MeasureWait.LinkedListPointer - 1;

            return;
        }
    }
}
