using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public Expression IUnlock(String String_VALUE)
        {
            Expression expressionResult = default;

            Expression expression;

            expression = ILock(String_VALUE);

            IView(expression);

            expressionResult = expression;

            return expressionResult;
        }
    }
}
