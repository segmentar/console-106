using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void MaterialFooterCheck()
        {
            var position = MeasureFileArray.Text.StringValue.IndexOf(ScopeImmutable.MaterialStringEnd, MeasureFile.PhysicalOffset);

            Boolean shouldReturnContiniousCheck;

            shouldReturnContiniousCheck = position.Equals(-1) is true;

            if (shouldReturnContiniousCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            var start = 0;

            start = start + MeasureFile.PhysicalOffset;

            start = start + MeasureFile.Line.StringValue.Length;

            var end = 0;

            end = end + position;

            end = end - 1;

            var difference = (end - start);

            var MoreThan__BOOLEAN_SAFE = (difference > 0) is true;

            shouldReturnContiniousCheck = MoreThan__BOOLEAN_SAFE is false;

            if (shouldReturnContiniousCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            MeasureFlag.MaterialFooterFlag = true;

            var total = (difference + 1);

            var sub = MeasureFileArray.Text.StringValue.Substring(start, total);

            MeasureValue.MaterialFooterSubstring = ScopeStringSafe.Simple(sub);

            return;
        }
    }
}
