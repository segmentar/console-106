namespace Core
{
    using System;

    public partial class Expression
    {
        public Expression IBrute(Expression Expression_VALUE)
        {
            Expression expressionResult = default;

            var list = IModLast();

            Boolean hasLengthCheck;

            hasLengthCheck = list.ExpressionArrayList.Count.Equals(1) is true;

            if (hasLengthCheck is true)
            {
                var reflect = (Expression)(list.ExpressionArrayList[0] as Object);

                list.ExpressionArrayList.Clear();

                expressionResult = reflect;
            }
            else
                "false".ToString();

            Boolean isDefaultCheck, isNotDefaultCheck;

            isDefaultCheck = (Expression_VALUE == default) is true;

            isNotDefaultCheck = isDefaultCheck is false;

            if (isNotDefaultCheck is true)
            {
                list.ExpressionArrayList.Add(Expression_VALUE);
            }
            else
                "false".ToString();

            return expressionResult;
        }
    }
}
