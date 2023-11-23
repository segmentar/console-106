using Core;

namespace Core
{
    using System;

    public partial class ExpressionSimple
    {
        public Expression Result { get; set; } = default;

        public ExpressionSimple()
        {
            return;
        }

        ~ExpressionSimple()
        {
            return;
        }
    }
}

namespace Core
{
    using System;

    public partial class ExpressionSimple
    {
        public ExpressionSimple(String StringIdentity__VALUE, Object ObjectIdentity__VALUE)
        {
            var IdentityStringSafe___VALUE = ExpressionStringSafe.Simple(StringIdentity__VALUE);

            Expression expression;

            expression = Expression.MakeExpressionDefaultSurface(IdentityStringSafe___VALUE, ObjectIdentity__VALUE);

            this.Result = expression;

            return;
        }
    }
}