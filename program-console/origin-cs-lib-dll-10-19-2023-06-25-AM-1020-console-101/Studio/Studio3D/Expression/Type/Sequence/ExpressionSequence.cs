using Core;

namespace Core
{
    using System;

    public partial class ExpressionSequence
    {
        public Expression Result { get; set; } = default;

        public ExpressionSequence(ExpressionStringSafe IdentityStringSafe___VALUE, Object ObjectIdentity__VALUE, Boolean answer_DEBUG_is)
        {
            Debug(IdentityStringSafe___VALUE, ObjectIdentity__VALUE, answer_DEBUG_is);

            Expression expression;

            expression = new Expression(IdentityStringSafe___VALUE, ObjectIdentity__VALUE, answer_DEBUG_is);

            this.Result = expression;

            return;
        }

        ~ExpressionSequence()
        {
            return;
        }
    }
}
