using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public static String ForgeRepresentString(Expression item_EXPRESSION, Int32 item_LAYER)
        {
            String stringResult = default;

            var entity__ARROW_RIGHT = Convert.ToChar(62);

            var entity__LAYER_NUMBER = new String(entity__ARROW_RIGHT, item_LAYER);

            var entity__LINE_FEED = Convert.ToChar(10);

            var descriptor = String.Empty;

            descriptor = descriptor + entity__LAYER_NUMBER;
            
            descriptor = descriptor + item_EXPRESSION.StringIdentity.StringValueSafe;

            descriptor = descriptor + entity__LINE_FEED;

            foreach (Expression expression in item_EXPRESSION.ExpressionArrayList)
            {
                var zee = (item_LAYER + 1);

                String stringItem;

                stringItem = ForgeRepresentString(expression, zee);

                descriptor = descriptor + stringItem;

                continue;
            }

            stringResult = descriptor;

            return stringResult;
        }
    }
}
