using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void DirectionPause()
        {
            MeasureWait.IsPause = MeasureWait.IsPause.Equals(false);

            if (MeasureWait.IsPause is true)
            {
                Raise(true, true);

                Bundle();
            }
            else
                "false".ToString();

            return;
        }
    }
}
