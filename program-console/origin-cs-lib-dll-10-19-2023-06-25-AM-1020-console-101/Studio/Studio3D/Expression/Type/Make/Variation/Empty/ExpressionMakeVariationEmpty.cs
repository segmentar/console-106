using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public static Expression MakeExpressionEmptyVariation()
        {
            Expression expressionResult = default;

            Expression expression;

            expression = new ExpressionSimple(String.Empty, default(Object)).Result;

            expressionResult = expression;

            return expressionResult;
        }
    }
}
