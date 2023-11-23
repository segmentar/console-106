using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void EndOfFileArraySync()
        {
            MeasureFlag.EndOfFileArrayFlag = false;

            return;
        }
    }
}
