using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void LocalLineApply()
        {
            if (MeasureFlag.LocalLineFlag is false)
            {
                return;
            }
            else
                "false".ToString();

            LocalLineSync();

            var array = new String[MeasureValue.LocalLineMultilineCount];

            var position = ((MeasureFile.RelateOffset + MeasureFile.Line.StringValue.Length) - 1);

            var indexer = 0;

            do
            {
                var boolean_safe_SHOULD_break = false;

                boolean_safe_SHOULD_break = boolean_safe_SHOULD_break || MeasureValue.LocalLineMultilineCount.Equals(indexer) is true;

                boolean_safe_SHOULD_break = boolean_safe_SHOULD_break || MeasureFileArray.Text.StringValue.Length.Equals(position) is true;

                if (boolean_safe_SHOULD_break is true)
                {
                    break;
                }
                else
                    "false".ToString();

                var Entity_LINE_FEED = Convert.ToChar(10);

                Boolean isLineFeedCheck, shouldContinueCheck;

                isLineFeedCheck = MeasureFileArray.Text.StringValue[position].Equals(Entity_LINE_FEED) is true;

                shouldContinueCheck = isLineFeedCheck is true;

                if (shouldContinueCheck is true)
                {
                    position = position + 1;

                    continue;
                }
                else
                    "false".ToString();

                var zee = (position + 1);

                var next = MeasureFileArray.Text.StringValue.IndexOf(Entity_LINE_FEED, zee);

                Boolean isEqualCheck;

                isEqualCheck = next.Equals(-1) is true;

                if (isEqualCheck is true)
                {
                    next = (MeasureFileArray.Text.StringValue.Length - 1);
                }
                else
                    "false".ToString();

                var difference = (next - position);

                var sub = MeasureFileArray.Text.StringValue.Substring(position, difference);

                var Entity_CARRIAGE_RETURN = Convert.ToChar(13);

                var format = sub.TrimEnd(Entity_CARRIAGE_RETURN);

                array[indexer] = format;

                position = position + sub.Length;

                indexer = indexer + 1;

                continue;

            } while (true);

            Hostlocalline hostlocalline;

            hostlocalline = Hostlocalline.MakeHostlocallineDefaultSurface(MeasureFile.Line.StringValue, array);

            MeasureQuery.HostLocallineArrayList.Add(hostlocalline);

            LocalLineMultilineCountSync();

            AdvanceLine();

            return;
        }
    }
}
