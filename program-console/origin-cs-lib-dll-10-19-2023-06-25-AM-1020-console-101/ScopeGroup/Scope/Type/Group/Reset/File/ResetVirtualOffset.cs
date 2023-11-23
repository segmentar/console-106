using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void ResetVirtualOffset()
        {
            MeasureFile.VirtualOffset = 0;

            return;
        }
    }
}
