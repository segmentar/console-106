using Core;

namespace Core
{
    using System;

    public partial struct ExpressionStringSafe : IStringSafe
    {
        public String StringValue { get; set; }
        public String StringValueSafe { get; set; }

        public static ExpressionStringSafe Simple(String value_STRING)
        {
            ExpressionStringSafe stringSafeResult = default;

            String stringValue, stringValueSafe;

            stringValue = value_STRING;

            stringValueSafe = Expression.SolidString(stringValue);

            ExpressionStringSafe stringSafe;

            stringSafe = new ExpressionStringSafe();

            stringSafe.StringValue = stringValue;

            stringSafe.StringValueSafe = stringValueSafe;

            stringSafeResult = stringSafe;
            
            return stringSafeResult;
        }
    }
}
