using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void SetPrimaryWait(Int32 PrimaryWait__VALUE)
        {
            MeasureWait.PrimaryWait = PrimaryWait__VALUE;

            return;
        }
    }
}
