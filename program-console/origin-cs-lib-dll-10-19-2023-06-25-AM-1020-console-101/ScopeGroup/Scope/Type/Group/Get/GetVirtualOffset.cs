using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void GetVirtualOffset()
        {
            var Entity_LINE_FEED = Convert.ToChar(10);

            var position = MeasureFileArray.Text.StringValue.LastIndexOf(Entity_LINE_FEED, MeasureFile.PhysicalOffset);

            Boolean isNotSuccessContagentCheck;

            isNotSuccessContagentCheck = position.Equals(-1) is true;

            if (isNotSuccessContagentCheck is true)
            {
                position = 0;
            }
            else
                "false".ToString();

            var difference = (MeasureFile.PhysicalOffset - position);

            MeasureFile.VirtualOffset = difference;

            return;
        }
    }
}
