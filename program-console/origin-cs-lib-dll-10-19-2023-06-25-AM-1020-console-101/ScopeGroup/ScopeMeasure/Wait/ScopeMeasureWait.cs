using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial struct ScopeMeasureWait
    {
        public Boolean IsRunning;

        public Boolean IsPause;

        public Boolean ShouldGUI;

        public Int32 PrimaryWait;

        public Int32 SecondaryWait;

        public LinkedList<ScopeTransaction> LinkedList;

        public Int32 LinkedListPointer;
    }
}