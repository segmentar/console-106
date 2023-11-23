using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void MaterialHeaderCheck()
        {
            var Entity_PERIOD = Convert.ToChar(46);

            var Entity_COMMA = Convert.ToChar(44);

            var Position_PERIOD = MeasureFile.Line.StringValue.IndexOf(Entity_PERIOD);

            var Position_COMMA = MeasureFile.Line.StringValue.LastIndexOf(Entity_COMMA);

            var invalid = false;

            invalid = invalid || Position_PERIOD.Equals(-1) is true;

            invalid = invalid || Position_COMMA.Equals(-1) is true;

            Boolean shouldReturnContiniousCheck;

            shouldReturnContiniousCheck = invalid is true;

            if (shouldReturnContiniousCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            var start = Position_PERIOD;

            var difference = (Position_COMMA - start);

            var MoreThan__SAFE_BOOLEAN = (difference > 0);

            shouldReturnContiniousCheck = MoreThan__SAFE_BOOLEAN is false;

            if (shouldReturnContiniousCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            MeasureFlag.MaterialHeaderFlag = true;

            var total = difference + 1;

            var sub = MeasureFile.Line.StringValue.Substring(start, total);

            MeasureValue.MaterialHeaderSubstring = ScopeStringSafe.Simple(sub);

            return;
        }
    }
}
