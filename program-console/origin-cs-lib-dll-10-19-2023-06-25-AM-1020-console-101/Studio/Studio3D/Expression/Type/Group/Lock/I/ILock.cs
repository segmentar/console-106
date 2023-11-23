using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public Expression ILock(String String_VALUE)
        {
            Expression expressionResult = default;

            var last = IModLast();

            Expression expression;

            expression = new ExpressionSimple(String_VALUE, default(Object)).Result;

            last.ExpressionArrayList.Add(expression);

            expressionResult = expression;

            return expressionResult;
        }
    }
}
