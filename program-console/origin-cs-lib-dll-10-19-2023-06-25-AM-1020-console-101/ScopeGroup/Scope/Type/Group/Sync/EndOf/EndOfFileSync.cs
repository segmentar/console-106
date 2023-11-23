using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void EndOfFileSync()
        {
            MeasureFlag.EndOfFileFlag = false;

            return;
        }
    }
}
