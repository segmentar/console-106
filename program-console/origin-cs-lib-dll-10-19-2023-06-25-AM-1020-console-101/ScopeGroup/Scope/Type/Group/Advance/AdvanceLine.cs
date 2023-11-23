using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void AdvanceLine()
        {
            MeasureFile.PhysicalOffset = MeasureFile.PhysicalOffset + MeasureFile.Line.StringValue.Length;

            MeasureFile.PhysicalOffset = MeasureFile.PhysicalOffset - 1;

            return;
        }
    }
}
