using Core;

namespace Core
{
    using System;

    using System.Threading;

    public partial class Scope
    {
        public static Thread ScopeMainThread()
        {
            Thread threadResult = default;

            ThreadStart threadStart;

            threadStart = new ThreadStart(ScopeMainTargetSTA);

            Thread thread;

            thread = new Thread(threadStart, ScopePolicy.ScopeMaxStackSizePolicy);

            threadResult = thread;

            return threadResult;
        }
    }
}
