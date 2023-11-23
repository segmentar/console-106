using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void GetRelateOffset()
        {
            var Entity_LINE_FEED = Convert.ToChar(10);

            var index = MeasureFileArray.Text.StringValue.LastIndexOf(Entity_LINE_FEED, MeasureFile.PhysicalOffset);

            Boolean isEqualCheck;

            isEqualCheck = index.Equals(-1) is true;

            if (isEqualCheck is true)
            {
                index = 0;
            }
            else
                "false".ToString();

            Boolean hasNextCheck;

            hasNextCheck = MeasureFileArray.Text.StringValue.Length.Equals(index + 1) is true;

            if (hasNextCheck is true)
            {
                index = index + 1;
            }
            else
                "false".ToString();

            MeasureFile.RelateOffset = index;

            return;
        }
    }
}
