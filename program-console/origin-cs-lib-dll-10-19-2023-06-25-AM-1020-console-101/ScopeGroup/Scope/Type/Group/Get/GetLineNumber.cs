using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void GetLineNumber()
        {
            var start = 0;

            var difference = (MeasureFile.PhysicalOffset - start);

            var sub = MeasureFileArray.Text.StringValue.Substring(start, difference);

            MeasureFile.LineNumber = LineNumberCompound(sub);

            return;
        }
    }
}
