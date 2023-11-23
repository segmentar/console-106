using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public Expression IModFirst()
        {
            Expression expressionResult = default;

            var list = IMod();

            var value = list.First.Value;

            Expression expression;

            expression = value;

            expressionResult = expression;

            return expressionResult;
        }
    }
}
