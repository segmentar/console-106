using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public Expression IBind(Expression Expression_VALUE, Object value_OBJECT)
        {
            Expression expressionResult = default;

            Expression_VALUE.ObjectIdentity = value_OBJECT;
             
            return expressionResult;
        }
    }
}
