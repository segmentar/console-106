using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void MeasureFlagRuntime()
        {
            MeasureFlag.EndOfFileArrayFlag = default(Boolean);

            MeasureFlag.EndOfFileFlag = default(Boolean);

            MeasureFlag.ScopeShutdownFlag = default(Boolean);

            return;
        }
    }
}