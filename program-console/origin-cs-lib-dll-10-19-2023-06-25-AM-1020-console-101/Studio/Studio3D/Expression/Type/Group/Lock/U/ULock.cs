using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public Expression ULock(String String_VALUE)
        {
            Expression expressionResult = default;

            var last = IModLast();

            var AnswerContainIs___VALUE = false;

            var ExpressionCounter__VALUE = default(Expression);

            foreach (Expression expression in last.ExpressionArrayList)
            {
                ExpressionCounter__VALUE = expression;

                Boolean isEqualCheck, shouldContinueCheck;

                isEqualCheck = expression.StringIdentity.StringValue.Equals(String_VALUE) is true;

                shouldContinueCheck = isEqualCheck is false;

                if (shouldContinueCheck is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                AnswerContainIs___VALUE = true;

                break;
            }

            Boolean isContainContagentCheck;

            isContainContagentCheck = AnswerContainIs___VALUE is true;

            if (isContainContagentCheck)
            {
                IView(ExpressionCounter__VALUE);

                expressionResult = ExpressionCounter__VALUE;
            }
            else
            {
                expressionResult = ILock(String_VALUE);
            }

            return expressionResult;
        }
    }
}
