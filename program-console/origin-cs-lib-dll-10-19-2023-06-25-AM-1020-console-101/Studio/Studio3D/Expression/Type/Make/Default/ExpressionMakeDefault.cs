using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public static Expression MakeExpressionDefault(ExpressionStringSafe IdentityStringSafe___VALUE, Object ObjectIdentity__VALUE, Boolean answer_DEBUG_is)
        {
            Expression expressionResult = default;

            var result = new ExpressionSequence(IdentityStringSafe___VALUE, ObjectIdentity__VALUE, answer_DEBUG_is).Result;

            ExpressionPolicy.ExpressionArrayList.Add(result);

            expressionResult = result;

            return expressionResult;
        }
    }
}
