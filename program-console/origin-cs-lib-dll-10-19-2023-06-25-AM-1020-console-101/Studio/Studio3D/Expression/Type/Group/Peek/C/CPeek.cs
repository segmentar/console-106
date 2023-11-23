using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public Expression CPeek(String String_ITEM)
        {
            Expression expressionResult = default;

            var last = IModLast();

            var array = last.ExpressionArrayList.ToArray(typeof(Expression));

            var reflect = (Expression[])(array as Array);

            Expression expression;

            expression = IPeek(String_ITEM, reflect);

            expressionResult = expression;

            return expressionResult;
        }
    }
}
