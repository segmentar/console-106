using Core;

namespace Core
{
    using System;

    public partial class Host
    {
        public static void ProcessContribute(Contribute item_CONTRIBUTE)
        {
            var Entity_COLON = Convert.ToChar(58);

            var Entity_DOUBLE_COLON = new String(Entity_COLON, 2);

            var separator = new String[] { Entity_DOUBLE_COLON };

            var split = item_CONTRIBUTE.Type.StringValue.Split(separator, StringSplitOptions.None);

            var first = split[0];

            var lower = first.ToLower();

            ProcessContributeHostType(item_CONTRIBUTE, lower);

            var aoth = split.Length;

            var boolean_match__EQUAL_OR_MORE_THAN = (aoth >= 2);

            Boolean hasLengthCheck;

            hasLengthCheck = boolean_match__EQUAL_OR_MORE_THAN is true;

            if (hasLengthCheck is true)
            {
                var second = split[1];

                if (second.Contains(HostConstant.SystemHostEndian) is true)
                {
                    Array.Reverse(item_CONTRIBUTE.ByteArray);
                }
                else
                    "false".ToString();
            }
            else
                "false".ToString();

            return;
        }
    }
}
