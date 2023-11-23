using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public Expression IModLast()
        {
            Expression expressionResult = default;

            var list = IMod();

            var value = list.Last.Value;

            Expression expression;

            expression = value;

            expressionResult = expression;

            return expressionResult;
        }
    }
}
