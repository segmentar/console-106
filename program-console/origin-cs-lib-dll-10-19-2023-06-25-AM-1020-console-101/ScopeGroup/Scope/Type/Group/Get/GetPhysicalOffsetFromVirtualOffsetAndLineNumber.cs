using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static Int32 GetPhysicalOffsetFromVirtualOffsetAndLineNumber(Int32 LineNumber__ITEM, Int32 VirtualOffset__ITEM, String Text_ITEM)
        {
            Int32 integerResult = default;

            var ordinal = 1;

            var indexer = 0;

            var zeroth = -1;

            do
            {
                zeroth = zeroth + 1;

                Boolean shouldBreakCheck;

                shouldBreakCheck = MeasureFileArray.Text.StringValue.Length.Equals(indexer) is true;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                var character = MeasureFileArray.Text.StringValue[indexer];

                var Entity_LINE_FEED = Convert.ToChar(10);

                Boolean isEqualCheck;

                isEqualCheck = character.Equals(Entity_LINE_FEED) is true;

                if (isEqualCheck is true)
                {
                    ordinal = ordinal + 1;

                    zeroth = 0;
                }
                else
                    "false".ToString();

                var boolean_match_ENTITY_CHECK_is = true;

                boolean_match_ENTITY_CHECK_is = boolean_match_ENTITY_CHECK_is && LineNumber__ITEM.Equals(ordinal) is true;

                boolean_match_ENTITY_CHECK_is = boolean_match_ENTITY_CHECK_is && VirtualOffset__ITEM.Equals(zeroth) is true;

                if (boolean_match_ENTITY_CHECK_is is true)
                {
                    integerResult = indexer;
                }
                else
                    "false".ToString();

                indexer = indexer + 1;

                continue;

            } while (true);

            return integerResult;
        }
    }
}
