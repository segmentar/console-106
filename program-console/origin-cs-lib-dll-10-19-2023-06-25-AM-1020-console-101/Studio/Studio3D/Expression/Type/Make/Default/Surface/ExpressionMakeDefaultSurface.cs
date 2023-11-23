using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public static Expression MakeExpressionDefaultSurface(ExpressionStringSafe IdentityStringSafe__VALUE, Object ObjectIdentity__VALUE)
        {
            Expression expressionResult = default;

            expressionResult = MakeExpressionDefault(IdentityStringSafe__VALUE, ObjectIdentity__VALUE, ExpressionPolicy.ExpressionDebugPolicy);

            return expressionResult;
        }
    }
}
