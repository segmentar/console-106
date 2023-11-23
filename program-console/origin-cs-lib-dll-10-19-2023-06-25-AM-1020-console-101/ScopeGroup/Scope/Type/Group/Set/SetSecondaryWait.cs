using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void SetSecondaryWait(Int32 SecondaryWait__VALUE)
        {
            MeasureWait.SecondaryWait = SecondaryWait__VALUE;

            return;
        }
    }
}
