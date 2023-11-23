using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public Expression UPeek(String String_ITEM)
        {
            Expression expressionResult = default;

            var array = ExpressionAllSetSurface(this);

            Expression expression;

            expression = IPeek(String_ITEM, array);

            expressionResult = expression;

            return expressionResult;
        }
    }
}
