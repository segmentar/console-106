using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public static Expression MakeExpressionRootVariation()
        {
            Expression expressionResult = default;

            Expression expression;

            expression = new ExpressionSimple("root", default(Object)).Result;

            expressionResult = expression;

            return expressionResult;
        }
    }
}
