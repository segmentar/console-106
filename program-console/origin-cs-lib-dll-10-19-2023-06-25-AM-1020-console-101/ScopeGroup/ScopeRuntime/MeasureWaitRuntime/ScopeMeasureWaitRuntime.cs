using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Scope
    {
        public static void MeasureWaitRuntime()
        {
            MeasureWait.IsRunning = true;

            MeasureWait.IsPause = true;

            MeasureWait.ShouldGUI = false;

            MeasureWait.PrimaryWait = -1;

            MeasureWait.SecondaryWait = -1;

            MeasureWait.LinkedList = new LinkedList<ScopeTransaction>();

            MeasureWait.LinkedListPointer = -1;

            return;
        }
    }
}