using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void GetLine()
        {
            var Entity_LINE_FEED = Convert.ToChar(10);

            var Start_POSITION = MeasureFileArray.Text.StringValue.LastIndexOf(Entity_LINE_FEED, MeasureFile.PhysicalOffset);

            var End_POSITION = MeasureFileArray.Text.StringValue.IndexOf(Entity_LINE_FEED, MeasureFile.PhysicalOffset);

            Boolean hasNotStartPositionContagentCheck, hasNotEndPositionContagentCheck;

            hasNotStartPositionContagentCheck = Start_POSITION.Equals(-1) is true;

            hasNotEndPositionContagentCheck = End_POSITION.Equals(-1) is true;

            if (hasNotStartPositionContagentCheck)
            {
                Start_POSITION = 0;
            }
            else
            {
                Start_POSITION = Start_POSITION + 1;
            }

            if (hasNotEndPositionContagentCheck)
            {
                var aoth = MeasureFileArray.Text.StringValue.Length;

                var roth = (aoth - 1);

                End_POSITION = roth;
            }
            else
            {
                End_POSITION = End_POSITION - 1;
            }

            var Entity_CARRIAGE_RETURN = Convert.ToChar(13);

            Boolean isEqualCheck;

            isEqualCheck = MeasureFileArray.Text.StringValue[End_POSITION].Equals(Entity_CARRIAGE_RETURN) is true;

            if (isEqualCheck is true)
            {
                End_POSITION = End_POSITION + 1;
            }
            else
                "false".ToString();

            var difference = (End_POSITION - Start_POSITION);

            var total = (difference + 1);

            var max = Math.Max(total, 0);

            var sub = MeasureFileArray.Text.StringValue.Substring(Start_POSITION, max);
                
            MeasureFile.Line = ScopeStringSafe.Simple(sub);

            return;
        }
    }
}
