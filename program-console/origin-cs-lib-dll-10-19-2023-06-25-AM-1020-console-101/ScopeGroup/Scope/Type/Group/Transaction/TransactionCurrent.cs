using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Scope
    {
        public static LinkedListNode<ScopeTransaction> TransactionCurrent()
        {
            LinkedListNode<ScopeTransaction> nodeResult = default;

            var list = new ArrayList(MeasureWait.LinkedList);

            var node = list[MeasureWait.LinkedListPointer];

            var reflect = (ScopeTransaction)(node as Object);

            var result = MeasureWait.LinkedList.Find(reflect);

            nodeResult = result;

            return nodeResult;
        }
    }
}
