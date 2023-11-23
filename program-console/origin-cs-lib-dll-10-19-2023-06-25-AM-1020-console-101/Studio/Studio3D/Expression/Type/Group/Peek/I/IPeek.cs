using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public Expression IPeek(String String_VALUE, Expression[] Expression_ARRAY)
        {
            Expression expressionResult = default;

            foreach (Expression Expression_VALUE in Expression_ARRAY)
            {
                var format = ForgeDashlessFormat(Expression_VALUE.StringIdentity.StringValue);

                Boolean isEqualCheck, shouldContinueCheck;

                isEqualCheck = String_VALUE.Equals(format) is true;

                shouldContinueCheck = isEqualCheck is false;

                if (shouldContinueCheck is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                expressionResult = Expression_VALUE;

                continue;
            }

            return expressionResult;
        }
    }
}
