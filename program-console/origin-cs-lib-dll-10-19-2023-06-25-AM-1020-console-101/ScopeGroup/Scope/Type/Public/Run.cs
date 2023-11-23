using Core;

namespace Core
{
    using System;

    using System.Threading;

    public partial class Scope
    {
        public static void Run()
        {
            if (MeasureWait.ShouldGUI)
            {
                var thread = ScopeMainThread();

                thread.Start();

                Thread.Sleep(MeasureWait.PrimaryWait);
            }
            else
            {
                DirectionPause();
            }

            return;
        }
    }
}
