using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public ExpressionStringSafe SCPeek(String String_ITEM)
        {
            ExpressionStringSafe safeResult = default;

            var expression = CPeek(String_ITEM);

            var reflect = (Expression)(expression.ExpressionArrayList[0] as Object);

            var safe = reflect.StringIdentity;

            safeResult = safe;

            return safeResult;
        }
    }
}
